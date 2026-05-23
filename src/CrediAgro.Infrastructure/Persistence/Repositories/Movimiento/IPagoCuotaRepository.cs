using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface IPagoCuotaRepository : IRepository<ScrPagoCuotum>
{
    Task<int> VerificarPagoCuotaAsync(int tablaproyeccionPagoId);
    Task<IEnumerable<CuotaPendientePagoGrid>> CuotasPendientePagoAsync(int creditoId, DateTime fechaPago, decimal monto);
    Task<string> ObtenerNumeroPagoCuotaAsync();
    Task<IEnumerable<PagoCuotaEntity>> ListaPagosCuotasPrestamoAsync(int creditoId);
    Task<int> AnularPagoCuotaAsync(int cuotaId, int creditoId);
    Task<ReciboClassEntity?> ObtenerDatosPagoCuotaReciboAsync(int pagoId);
    Task<IEnumerable<DistribucionPagoEntity>> ObtenerDistribucionPagoAsync(DateTime fechaPago, int creditoId);
}
