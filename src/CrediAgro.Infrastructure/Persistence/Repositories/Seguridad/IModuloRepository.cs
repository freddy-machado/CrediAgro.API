using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IModuloRepository : IRepository<SsgModulo>
{
    Task<IEnumerable<SsgModulo>> ListadoModulosAsync();
    Task<IEnumerable<SsgModulo>> ListadoModulosPorAplicacionIdAsync(int aplicacionId);
}
