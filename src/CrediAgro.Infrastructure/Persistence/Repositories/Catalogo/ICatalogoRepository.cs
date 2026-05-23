using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface ICatalogoRepository : IRepository<StbCatalogo>
{
    Task<IEnumerable<StbCatalogo>> ListadoCatalogosAsync();
    Task<StbCatalogo?> ObtenerCatalogoPorNombreAsync(string catalogoName);
}
