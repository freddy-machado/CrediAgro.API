using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface ITablaProyeccionRepository : IRepository<ScrTablaproyeccionPago>
{
    Task<IEnumerable<TablaPagosEntity>> ObtenerTablaPorCreditoIdAsync(int creditoId);
    Task<TablaPagosEntity?> CuotaPendientePagoPorTablaIdAsync(int creditoId);
    Task<SaldoRealYMmtoValor?> ObtenerSaldoRealYMmtoValorAsync(int tablaPagoId);
    Task<TablaPagosEntity?> SiguienteCuotaPendientePagoPorTablaIdAsync(int creditoId, int numPago);
    Task<DatosPrestamoEntity?> ObtenerDatosPrestamoAsync(int creditoId);
}
