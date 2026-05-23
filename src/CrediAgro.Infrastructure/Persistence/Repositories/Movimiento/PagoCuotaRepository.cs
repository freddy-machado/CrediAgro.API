using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class PagoCuotaRepository : Repository<ScrPagoCuotum>, IPagoCuotaRepository
{
    public PagoCuotaRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<int> VerificarPagoCuotaAsync(int tablaproyeccionPagoId) =>
        await _context.ScrPagoCuotaDetalles.AsNoTracking()
            .CountAsync(pd => pd.nScrTablaproyeccionPagoID == tablaproyeccionPagoId);

    public async Task<IEnumerable<CuotaPendientePagoGrid>> CuotasPendientePagoAsync(int creditoId, DateTime fechaPago, decimal monto) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrSolicitudID == creditoId
                     && tp.cEstadoPago != "P"
                     && tp.dFechaPago <= fechaPago
               select new CuotaPendientePagoGrid
               {
                   N_CUOTA = tp.nNumeroCuota,
                   N_AMORTIZACION_ID = tp.nScrTablaproyeccionPagoID,
                   D_FECHA_PAGO = tp.dFechaPago,
                   N_SALDO_AMORTIZACION = tp.nMontoPrincipal - (tp.nMontoPrincipalAbonado ?? 0),
                   N_SALDO_MANTENIMIENTO = tp.nMontoMantenimientoPrincipal - (tp.nMontoMantenimientoAbonadoPrincipal ?? 0),
                   N_SALDO_INTERES = tp.nMontoInteres - tp.nMontoInteresAbonado,
                   N_MORA = tp.nMontoMora ?? 0,
                   N_MONTO_PAGO = monto,
                   C_ESTATUS = tp.cEstadoPago ?? "P"
               }).ToListAsync();

    public async Task<string> ObtenerNumeroPagoCuotaAsync()
    {
        var count = await _dbSet.CountAsync();
        return (count + 1).ToString("D8");
    }

    public async Task<IEnumerable<PagoCuotaEntity>> ListaPagosCuotasPrestamoAsync(int creditoId) =>
        await (from pc in _context.ScrPagoCuota.AsNoTracking()
               join pd in _context.ScrPagoCuotaDetalles.AsNoTracking() on pc.nScrPagoCuotaID equals pd.nScrPagoCuotaID
               join tp in _context.ScrTablaproyeccionPagos.AsNoTracking() on pd.nScrTablaproyeccionPagoID equals tp.nScrTablaproyeccionPagoID
               where pc.nScrSolicitudID == creditoId && pc.nActivo == 1
               select new PagoCuotaEntity
               {
                   PAGOID = pc.nScrPagoCuotaID,
                   SOLICITUDID = pc.nScrSolicitudID,
                   FECHAPAGO = pc.dFechaPago,
                   NUMERODOCUMENTO = pc.cNumeroDocumento ?? "",
                   TABLAPAGOID = tp.nScrTablaproyeccionPagoID,
                   NUMEROCUOTA = tp.nNumeroCuota,
                   PRINCIPAL = pd.nMontoPrincipal,
                   INTERES = pd.nMontoInteres,
                   MORA = pd.nMontoMoraPrincipal,
                   MANTENIMIENTO = pd.nMontoMantenimientoPrincipal,
                   TOTAL = pc.nMontoPago ?? 0
               }).ToListAsync();

    public async Task<int> AnularPagoCuotaAsync(int cuotaId, int creditoId)
    {
        var pago = await _dbSet.FindAsync(cuotaId);
        if (pago == null || pago.nScrSolicitudID != creditoId) return 0;
        pago.nActivo = 0;
        _context.ScrPagoCuota.Update(pago);
        return 1;
    }

    public async Task<ReciboClassEntity?> ObtenerDatosPagoCuotaReciboAsync(int pagoId) =>
        await (from pc in _context.ScrPagoCuota.AsNoTracking()
               join c in _context.ScrCreditos.AsNoTracking() on pc.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join mo in _context.StbMoneda.AsNoTracking() on pc.nStbMonedaID equals mo.nStbMonedaID
               join rd in _context.StbRubroDetalles.AsNoTracking() on c.nStbRubroDetalleID equals rd.nStbRubroDetalleID
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join tc in _context.StbParidadCambiaria.AsNoTracking() on pc.nStbParidadCambiariaID equals tc.nStbParidadCambiariaID
               where pc.nScrPagoCuotaID == pagoId
               select new ReciboClassEntity
               {
                   CUOTAID = pc.nScrPagoCuotaID,
                   NORECIBO = pc.cNumeroDocumento ?? "",
                   CLIENTE = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   MONTOPAGADO = pc.nMontoPago ?? 0,
                   MONEDA = mo.cDescripcion,
                   CONCEPTO = pc.cConceptoPago ?? "",
                   TIPOCAMBIO = tc.nMontoTCambio,
                   FECHAPAGO = pc.dFechaPago,
                   NOPRESTAMO = c.nNumeroSolicitud ?? "",
                   RUBRO = r.cDescripcion
               }).FirstOrDefaultAsync();

    public async Task<IEnumerable<DistribucionPagoEntity>> ObtenerDistribucionPagoAsync(DateTime fechaPago, int creditoId) =>
        await (from tp in _context.ScrTablaproyeccionPagos.AsNoTracking()
               where tp.nScrSolicitudID == creditoId && tp.dFechaPago <= fechaPago && tp.cEstadoPago != "P"
               select new DistribucionPagoEntity
               {
                   N_SOLICITUD_ID = tp.nScrSolicitudID,
                   N_NUMERO_CUOTA = tp.nNumeroCuota,
                   D_FECHA_CORTE = tp.dFechaPago,
                   N_SALDO_AMORTIZACION = tp.nMontoPrincipal - (tp.nMontoPrincipalAbonado ?? 0),
                   N_MONTO_PAGO = tp.nMontoTotal - tp.nMontoPagado
               }).ToListAsync();
}
