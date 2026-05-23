using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface ICuentaRepository : IRepository<SsgCuentum>
{
    Task<SsgCuentum?> ObtenerCuentaPorLoginAsync(string login);
    Task<bool> VerificarLoginExistenteAsync(string login);
    Task<IEnumerable<SsgCuentum>> ListadoCuentasAsync();
}
