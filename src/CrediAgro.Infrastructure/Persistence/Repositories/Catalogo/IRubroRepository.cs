using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IRubroRepository : IRepository<StbRubro>
{
    Task<StbRubroDetalle?> VerificarRubroDetallePorRubroIdAsync(int rubroId);
}
