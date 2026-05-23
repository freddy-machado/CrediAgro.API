using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class TablaProyeccionRepository : Repository<ScrTablaproyeccionPago>, ITablaProyeccionRepository
{
    public TablaProyeccionRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<TablaPagosEntity>> ObtenerTablaPorCreditoIdAsync(int creditoId) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrSolicitudID == creditoId
               orderby tp.nNumeroCuota
               select new TablaPagosEntity
               {
                   tablaPagoID = tp.nScrTablaproyeccionPagoID,
                   creditoID = tp.nScrSolicitudID,
                   numeroPago = tp.nNumeroCuota.ToString(),
                   fechaPago = tp.dFechaPago.ToString("dd/MM/yyyy"),
                   montoPrincipal = tp.nMontoPrincipal,
                   montoMantenimiento = tp.nMontoMantenimientoPrincipal,
                   montoInteres = tp.nMontoInteres,
                   montoTotal = tp.nMontoTotal,
                   montoSaldo = tp.nMontoSaldo,
                   estadoCuota = tp.cEstadoPago ?? "",
                   montoPrincipalAbonado = tp.nMontoPrincipalAbonado,
                   montoMantenimientoAbonado = tp.nMontoMantenimientoAbonadoPrincipal,
                   montoInteresAbonado = tp.nMontoInteresAbonado,
                   montoPagar = tp.nMontoTotal - tp.nMontoPagado
               }).ToListAsync();

    public async Task<TablaPagosEntity?> CuotaPendientePagoPorTablaIdAsync(int creditoId) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrSolicitudID == creditoId && tp.cEstadoPago != "P"
               orderby tp.nNumeroCuota
               select new TablaPagosEntity
               {
                   tablaPagoID = tp.nScrTablaproyeccionPagoID,
                   creditoID = tp.nScrSolicitudID,
                   numeroPago = tp.nNumeroCuota.ToString(),
                   fechaPago = tp.dFechaPago.ToString("dd/MM/yyyy"),
                   montoPrincipal = tp.nMontoPrincipal,
                   montoInteres = tp.nMontoInteres,
                   montoTotal = tp.nMontoTotal,
                   montoSaldo = tp.nMontoSaldo,
                   estadoCuota = tp.cEstadoPago ?? ""
               }).FirstOrDefaultAsync();

    public async Task<SaldoRealYMmtoValor?> ObtenerSaldoRealYMmtoValorAsync(int tablaPagoId) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrTablaproyeccionPagoID == tablaPagoId
               select new SaldoRealYMmtoValor
               {
                   mmtoValor = tp.nMontoTotal,
                   saldoReal = tp.nMontoSaldo
               }).FirstOrDefaultAsync();

    public async Task<TablaPagosEntity?> SiguienteCuotaPendientePagoPorTablaIdAsync(int creditoId, int numPago) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrSolicitudID == creditoId
                     && tp.cEstadoPago != "P"
                     && tp.nNumeroCuota > numPago
               orderby tp.nNumeroCuota
               select new TablaPagosEntity
               {
                   tablaPagoID = tp.nScrTablaproyeccionPagoID,
                   creditoID = tp.nScrSolicitudID,
                   numeroPago = tp.nNumeroCuota.ToString(),
                   fechaPago = tp.dFechaPago.ToString("dd/MM/yyyy"),
                   montoPrincipal = tp.nMontoPrincipal,
                   montoInteres = tp.nMontoInteres,
                   montoTotal = tp.nMontoTotal,
                   montoSaldo = tp.nMontoSaldo,
                   estadoCuota = tp.cEstadoPago ?? ""
               }).FirstOrDefaultAsync();

    public async Task<DatosPrestamoEntity?> ObtenerDatosPrestamoAsync(int creditoId) =>
        await (from c in _context.ScrCreditos.AsNoTracking()
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on c.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where c.nScrSolicitudID == creditoId
               select new DatosPrestamoEntity
               {
                   solicitudID_ = c.nScrSolicitudID,
                   nMonto_ = c.nMontoApruebaC,
                   plazo_ = rd.nPlazo,
                   interes_ = rd.nTasaInteres,
                   frecuencia_ = rd.nStbFrecuenciaPagoID,
                   tipoCambio_ = tc.nMontoTCambio,
                   rubro_ = r.cDescripcion,
                   fechaInicio_ = c.dFechaSolicitud,
                   fechaVence_ = c.dFechaLiquidacion ?? c.dFechaSolicitud
               }).FirstOrDefaultAsync();
}
