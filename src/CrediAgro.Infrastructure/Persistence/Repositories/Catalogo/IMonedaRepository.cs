using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IMonedaRepository : IRepository<StbMonedum>
{
    Task<StbMonedum?> ObtenerMonedaPorCodigoAsync(string codigo);
}
