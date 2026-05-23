using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IDepartamentoRepository : IRepository<StbDepartamento>
{
    Task<IEnumerable<StbDepartamento>> ListadoDepartamentosAsync();
}
