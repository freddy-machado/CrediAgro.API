using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface ITipoCambioRepository : IRepository<StbParidadCambiarium>
{
    Task<StbParidadCambiarium?> ObtenerTipoCambioFechaAsync(DateTime fecha);
    Task<IEnumerable<TipoCambioList>> ListaTiposCambioAsync();
}
