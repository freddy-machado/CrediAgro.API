using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class DesembolsoRepository : Repository<ScrDesembolso>, IDesembolsoRepository
{
    public DesembolsoRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<ScrDesembolso?> ObtenerDesembolsoPorCreditoIdAsync(int creditoId) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(d => d.nScrSolicitudID == creditoId);

    public async Task<IEnumerable<DesembolsoEntity>> ListadoDesembolsosAsync() =>
        await (from d in _context.ScrDesembolsos.AsNoTracking()
               join c in _context.ScrCreditos.AsNoTracking() on d.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join mo in _context.StbMoneda.AsNoTracking() on d.nStbMonedaID equals mo.nStbMonedaID
               select new DesembolsoEntity
               {
                   desembolsoID = d.nScrDesembolsoID,
                   solicitudID = d.nScrSolicitudID,
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaDesembolso = d.dFechaDesembolso.ToString("dd/MM/yyyy"),
                   moneda = mo.cDescripcion,
                   montoDesembolso = d.nMontoDesembolso,
                   montoComision = d.nMontoComsion,
                   montoTotal = d.nMontoTotal,
                   clienteId = cl.nStbClienteID
               }).ToListAsync();

    public async Task<int> AutorizarDesembolsoAsync(int estadoAutorizadoId, int desembolsoId)
    {
        var desembolso = await _dbSet.FindAsync(desembolsoId);
        if (desembolso == null) return 0;
        desembolso.nStbEstadoDesembolsoID = estadoAutorizadoId;
        _context.ScrDesembolsos.Update(desembolso);
        return 1;
    }

    public async Task<int> AnularDesembolsoAsync(int estadoAnuladoId, int desembolsoId)
    {
        var desembolso = await _dbSet.FindAsync(desembolsoId);
        if (desembolso == null) return 0;
        desembolso.nStbEstadoDesembolsoID = estadoAnuladoId;
        _context.ScrDesembolsos.Update(desembolso);
        return 1;
    }

    public async Task<int> ActualizarEstadoDesembolsoAsync(int estadoDesembolso, int desembolsoId, DateTime fecha)
    {
        var desembolso = await _dbSet.FindAsync(desembolsoId);
        if (desembolso == null) return 0;
        desembolso.nStbEstadoDesembolsoID = estadoDesembolso;
        desembolso.dFechaPagado = fecha;
        _context.ScrDesembolsos.Update(desembolso);
        return 1;
    }
}
