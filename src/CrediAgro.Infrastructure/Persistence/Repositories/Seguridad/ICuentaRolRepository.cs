using CrediAgro.Infrastructure.Persistence.Models;
using CrediAgro.Infrastructure.Persistence.Seguridad;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public interface ICuentaRolRepository : IRepository<SsgCuentaRol>
{
    Task<IEnumerable<CuentaRolEntity>> ListadoCuentaRolesPorCuentaIdAsync(int cuentaId);
    Task<bool> VerificarCuentaRolExistenteAsync(int cuentaId, int rolId);
}
