using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IRubroDetalleRepository : IRepository<StbRubroDetalle>
{
    Task<StbRubroDetalle?> ObtenerRubroDetallePorRubroIdAsync(int rubroId);
    Task<StbRubro?> ObtenerRubroPorRubroDetalleIdAsync(int rubroDetalleId);
    Task<RubroDetalleEntity?> ObtenerRubroDetalleEntityPorRubroDetalleIdAsync(int rubroDetalleId);
    Task<IEnumerable<RubroDetalleList>> ListaDetalleRubrosPorRubroIdAsync(int rubroId);
    Task<int> AnularRubroDetalleAsync(int rubroDetalleId);
    Task<bool> VerificarRubroDetalleEnCreditoAsync(int rubroDetalleId);
}
