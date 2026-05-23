using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class DesembolsoDetalleRepository : Repository<ScrDesembolsoPago>, IDesembolsoDetalleRepository
{
    public DesembolsoDetalleRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<DesembolsoPagoEntityList>> ListaPagosDesembolsoAsync(int desembolsoId) =>
        await (from dp in _context.ScrDesembolsoPagos.AsNoTracking()
               join vc in _context.StbValorCatalogos.AsNoTracking() on dp.nStbFormaPagoID equals vc.nStbValorCatalogoID
               where dp.nScrDesembolsoID == desembolsoId
               select new DesembolsoPagoEntityList
               {
                   desembolsoPagoID = dp.nScrDesembolsoPagoID,
                   desembolsoID = dp.nScrDesembolsoID,
                   fecha = dp.dFechaPago.ToString("dd/MM/yyyy"),
                   monto = dp.nMontoPago,
                   tipoPago = vc.cDescripcion,
                   tipoPagoID = dp.nStbFormaPagoID
               }).ToListAsync();

    public async Task<DesembolsoDetalleEntity?> PagoDesembolsoPorDesembolsoIdAsync(int desembolsoId) =>
        await (from dp in _context.ScrDesembolsoPagos.AsNoTracking()
               join d in _context.ScrDesembolsos.AsNoTracking() on dp.nScrDesembolsoID equals d.nScrDesembolsoID
               join c in _context.ScrCreditos.AsNoTracking() on d.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               where dp.nScrDesembolsoID == desembolsoId
               select new DesembolsoDetalleEntity
               {
                   desembolsoID = dp.nScrDesembolsoID,
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaDesembolso = d.dFechaDesembolso.ToString("dd/MM/yyyy"),
                   montoDesembolso = d.nMontoDesembolso ?? 0
               }).FirstOrDefaultAsync();

    public async Task<decimal> CalculaMontoPagadoDelDesembolsoAsync(int desembolsoId) =>
        await _context.ScrDesembolsoPagos.AsNoTracking()
            .Where(dp => dp.nScrDesembolsoID == desembolsoId)
            .SumAsync(dp => dp.nMontoPago);

    public async Task<DateTime> ObtenerFechaPagoDesembolsoPorCreditoIdAsync(int creditoId)
    {
        var desembolso = await _context.ScrDesembolsos.AsNoTracking()
            .FirstOrDefaultAsync(d => d.nScrSolicitudID == creditoId);
        if (desembolso == null) return DateTime.MinValue;

        var pago = await _context.ScrDesembolsoPagos.AsNoTracking()
            .FirstOrDefaultAsync(dp => dp.nScrDesembolsoID == desembolso.nScrDesembolsoID);
        return pago?.dFechaPago ?? DateTime.MinValue;
    }
}
