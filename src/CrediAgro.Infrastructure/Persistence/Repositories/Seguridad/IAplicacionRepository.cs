using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IAplicacionRepository : IRepository<SsgAplicacion>
{
    Task<IEnumerable<SsgAplicacion>> ListadoAplicacionesAsync();
}
