using CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Seguridad;

public class SeguridadUnitOfWork : ISeguridadUnitOfWork
{
    private readonly SCreditoCmDbContext _context;

    public IAccionRepository Acciones { get; }
    public IAplicacionRepository Aplicaciones { get; }
    public ICuentaRepository Cuentas { get; }
    public ICuentaRolRepository CuentaRoles { get; }
    public IModuloRepository Modulos { get; }
    public IRolAccionRepository RolAcciones { get; }
    public IRolRepository Roles { get; }
    public IServicioUsuarioRepository ServicioUsuarios { get; }

    public SeguridadUnitOfWork(SCreditoCmDbContext context)
    {
        _context = context;
        Acciones = new AccionRepository(context);
        Aplicaciones = new AplicacionRepository(context);
        Cuentas = new CuentaRepository(context);
        CuentaRoles = new CuentaRolRepository(context);
        Modulos = new ModuloRepository(context);
        RolAcciones = new RolAccionRepository(context);
        Roles = new RolRepository(context);
        ServicioUsuarios = new ServicioUsuarioRepository(context);
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
}
