using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IAccionRepository : IRepository<SsgAccion>
{
    Task<IEnumerable<SsgAccion>> ListadoAccionesAsync();
    Task<IEnumerable<SsgAccion>> ListadoAccionesPorServicioUsuarioIdAsync(int servicioUsuarioId);
}
