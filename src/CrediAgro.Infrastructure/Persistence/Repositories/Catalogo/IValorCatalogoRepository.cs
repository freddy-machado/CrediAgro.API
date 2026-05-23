using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IValorCatalogoRepository : IRepository<StbValorCatalogo>
{
    Task<IEnumerable<StbValorCatalogo>> ListadoValoresCatalogosXCatalogoIdAsync(int catalogoId);
    Task<IEnumerable<StbValorCatalogo>> ListadoValoresCatalogosXCatalogoNameAsync(string catalogoName);
    Task<StbValorCatalogo?> ObtenerCatalogoPorCodigoInternoAsync(string catalogoName, string codigoInterno);
}
