using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class CreditoRepository : Repository<ScrCredito>, ICreditoRepository
{
    public CreditoRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<CreditoList>> ListadoCreditosAsync() =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               select new CreditoList
               {
                   creditoID = c.nScrSolicitudID,
                   numeroSolicitud = c.nNumeroSolicitud ?? "",
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion,
                   clienteId = cl.nStbClienteID
               }).ToListAsync();

    public async Task<bool> VerificarCreditoExistenteAsync(ScrCredito obj) =>
        await _dbSet.AsNoTracking()
            .AnyAsync(c => c.nStbClienteID == obj.nStbClienteID && c.nNumeroSolicitud == obj.nNumeroSolicitud);

    public async Task<IEnumerable<CreditoListCombo>> ListaCreditosComboAsync(int estadoDesembolsoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               where c.nStbEstadoSolicitudID == estadoDesembolsoId
               select new CreditoListCombo
               {
                   creditoID = c.nScrSolicitudID,
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion
               }).ToListAsync();

    public async Task<CreditoEntity?> ObtenerEntidadCreditoAsync(int creditoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               where c.nScrSolicitudID == creditoId
               select new CreditoEntity
               {
                   creditoID = c.nScrSolicitudID,
                   numeroSolicitud = c.nNumeroSolicitud ?? "",
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion
               }).FirstOrDefaultAsync();

    public async Task<IEnumerable<CreditoList>> ListadoCreditosPorEstadoIdAsync(int estadoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               where c.nStbEstadoSolicitudID == estadoId
               select new CreditoList
               {
                   creditoID = c.nScrSolicitudID,
                   numeroSolicitud = c.nNumeroSolicitud ?? "",
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion,
                   clienteId = cl.nStbClienteID
               }).ToListAsync();

    public async Task<IEnumerable<CreditoListCombo>> ListaCreditosEnProcesoComboFiadorAsync(int estadoCreditoId) =>
        await ListaCreditosComboAsync(estadoCreditoId);

    public async Task<CreditoListCombo?> CreditoComboFiadorPorCreditoIdAsync(int creditoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               where c.nScrSolicitudID == creditoId
               select new CreditoListCombo
               {
                   creditoID = c.nScrSolicitudID,
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion
               }).FirstOrDefaultAsync();

    public async Task<string> ObtenerNumeroCreditoAsync()
    {
        var count = await _dbSet.CountAsync();
        return (count + 1).ToString("D6");
    }

    public async Task<bool> VerificarCreditoFiadorAsync(int creditoId) =>
        await _context.StbFiadors.AsNoTracking()
            .AnyAsync(f => f.nStbSolicitudID == creditoId);

    public async Task<IEnumerable<CreditoListCombo>> ListaCreditosComboPorEstadosAsync(IEnumerable<string> codigos) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join es in _context.StbValorCatalogos.AsNoTracking() on c.nStbEstadoSolicitudID equals es.nStbValorCatalogoID
               join mo in _context.StbMoneda.AsNoTracking() on c.nStbMonedaID equals mo.nStbMonedaID
               where codigos.Contains(es.cCodigoInterno)
               select new CreditoListCombo
               {
                   creditoID = c.nScrSolicitudID,
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   fechaSolicitud = c.dFechaSolicitud.ToString("dd/MM/yyyy"),
                   rubro = r.cDescripcion,
                   montoSolicitado = c.nMontoSolicitaC ?? 0,
                   montoAprobado = c.nMontoApruebaC ?? 0,
                   estadoSolicitud = es.cDescripcion,
                   moneda = mo.cDescripcion
               }).ToListAsync();
}
