using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IRolAccionRepository : IRepository<SsgRolAccion>
{
    Task<IEnumerable<SsgRolAccion>> ListadoAccionesPorRolIdAsync(int rolId);
    Task<bool> VerificarAccionPorRolYAccionIdAsync(int rolId, int accionId);
}
