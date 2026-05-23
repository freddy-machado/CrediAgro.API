using CrediAgro.Infrastructure.Persistence.Reportes;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

public class ReportesCreditoRepository : IReportesCreditoRepository
{
    private readonly SCreditoCmDbContext _context;

    public ReportesCreditoRepository(SCreditoCmDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CarteraRptEntity>> ReporteCarteraAsync(int? rubroId, int? comarcaId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join bc in _context.StbBarrioComarcas.AsNoTracking() on p.nStbBarrioComarcaID equals bc.nStbComarcaID into bcGroup
               from bc in bcGroup.DefaultIfEmpty()
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on c.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where (!rubroId.HasValue || rd.nStbRubroID == rubroId)
                     && (!comarcaId.HasValue || bc.nStbComarcaID == comarcaId)
               select new CarteraRptEntity
               {
                   SOLICITUDID = c.nScrSolicitudID,
                   CLIENTEID = cl.nStbClienteID,
                   CLIENTE = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   MONTOCOR = c.nMontoApruebaC ?? 0,
                   MONTOUSD = (c.nMontoApruebaC ?? 0) / tc.nMontoTCambio,
                   FECHAENTREGA = c.dFechaSolicitud,
                   FECHAVENCE = c.dFechaLiquidacion ?? c.dFechaSolicitud,
                   RUBROID = rd.nStbRubroID
               }).ToListAsync();

    public async Task<IEnumerable<DesembolsoRptEntity>> ReporteDesembolsosAsync(DateTime fechaInicio, DateTime fechaFin) =>
        await (from d in _context.ScrDesembolsos.AsNoTracking()
               join c in _context.ScrCreditos.AsNoTracking() on d.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on d.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where d.dFechaDesembolso >= fechaInicio && d.dFechaDesembolso <= fechaFin
               select new DesembolsoRptEntity
               {
                   SOLICITUDID = c.nScrSolicitudID,
                   CLIENTEID = cl.nStbClienteID,
                   DESEMBOLSOID = d.nScrDesembolsoID,
                   CLIENTE = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   MONTOCOR = d.nMontoDesembolso ?? 0,
                   MONTOUSD = (d.nMontoDesembolso ?? 0) / tc.nMontoTCambio,
                   RUBRO = r.cDescripcion,
                   TIPOCAMBIO = tc.nMontoTCambio
               }).ToListAsync();

    public async Task<IEnumerable<TablaPagoRptEntity>> ReporteTablaPagosAsync(int creditoId) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               join c in _context.ScrCreditos.AsNoTracking() on tp.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join fp in _context.StbFrecuenciaPagos.AsNoTracking() on rd.nStbFrecuenciaPagoID equals fp.nStbFrecuenciaPagoID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on c.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where tp.nScrSolicitudID == creditoId
               orderby tp.nNumeroCuota
               select new TablaPagoRptEntity
               {
                   SOLICITUDID = c.nScrSolicitudID,
                   CLIENTEID = cl.nStbClienteID,
                   CLIENTE = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   MONTOCOR = c.nMontoApruebaC ?? 0,
                   MONTOUSD = (c.nMontoApruebaC ?? 0) / tc.nMontoTCambio,
                   TASAINTERES = rd.nTasaInteres ?? 0,
                   PLAZO = rd.nPlazo,
                   NUMPAGOS = fp.nPagosAnios,
                   FRECUENCIA = fp.cDescripcion ?? "",
                   FECHAENTREGA = c.dFechaSolicitud,
                   FECHAVENCE = c.dFechaLiquidacion ?? c.dFechaSolicitud,
                   TIPOCAMBIO = tc.nMontoTCambio,
                   NOCUOTA = tp.nNumeroCuota,
                   FECHAPAGO = tp.dFechaPago,
                   PRINCIPAL = tp.nMontoPrincipal,
                   MMTO = tp.nMontoMantenimientoPrincipal,
                   MONTOINTERES = tp.nMontoInteres,
                   TOTAL = tp.nMontoTotal,
                   SALDO = tp.nMontoSaldo
               }).ToListAsync();

    public async Task<IEnumerable<EstadoCuentaEntity>> ReporteEstadoCuentaAsync(int creditoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join fp in _context.StbFrecuenciaPagos.AsNoTracking() on rd.nStbFrecuenciaPagoID equals fp.nStbFrecuenciaPagoID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on c.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where c.nScrSolicitudID == creditoId
               select new EstadoCuentaEntity
               {
                   NSCRSOLICITUDID = c.nScrSolicitudID,
                   NSTBCLIENTEID = cl.nStbClienteID,
                   CNOMBRE1 = p.cNombre1,
                   CNOMBRE2 = p.cNombre2 ?? "",
                   CAPELLIDO1 = p.cApellido1 ?? "",
                   CAPELLIDO2 = p.cApellido2 ?? "",
                   NMONTOAPRUEBAC = c.nMontoApruebaC ?? 0,
                   RUBRO = r.cDescripcion,
                   NTASAINTERES = rd.nTasaInteres ?? 0,
                   NPLAZO = rd.nPlazo,
                   NPLAZOMESES = fp.nPlazoMeses,
                   APAGOSANIOS = fp.nPagosAnios,
                   N_TIPO_CAMBIO = tc.nMontoTCambio,
                   DFECHAPAGO = c.dFechaSolicitud
               }).ToListAsync();
}
