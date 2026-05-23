using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IRolRepository : IRepository<SsgRol>
{
    Task<IEnumerable<SsgRol>> ListadoRolesAsync();
}
