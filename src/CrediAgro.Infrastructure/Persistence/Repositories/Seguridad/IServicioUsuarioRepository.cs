using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface IServicioUsuarioRepository : IRepository<SsgServicioUsuario>
{
    Task<IEnumerable<SsgServicioUsuario>> ListadoServiciosUsuarioAsync();
    Task<IEnumerable<SsgServicioUsuario>> ListadoServiciosUsuarioPorModuloIdAsync(int moduloId);
}
