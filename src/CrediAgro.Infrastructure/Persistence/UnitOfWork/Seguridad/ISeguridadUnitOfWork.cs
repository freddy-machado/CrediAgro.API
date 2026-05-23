using CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Seguridad;

public interface ISeguridadUnitOfWork
{
    IAccionRepository Acciones { get; }
    IAplicacionRepository Aplicaciones { get; }
    ICuentaRepository Cuentas { get; }
    ICuentaRolRepository CuentaRoles { get; }
    IModuloRepository Modulos { get; }
    IRolAccionRepository RolAcciones { get; }
    IRolRepository Roles { get; }
    IServicioUsuarioRepository ServicioUsuarios { get; }

    Task<int> SaveChangesAsync();
}
