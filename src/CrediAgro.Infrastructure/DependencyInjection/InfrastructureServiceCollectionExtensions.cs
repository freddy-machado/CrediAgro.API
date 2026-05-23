using CrediAgro.Infrastructure.Persistence;
using CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;
using CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;
using CrediAgro.Infrastructure.Persistence.Repositories.Reportes;
using CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;
using CrediAgro.Infrastructure.Persistence.UnitOfWork.Catalogo;
using CrediAgro.Infrastructure.Persistence.UnitOfWork.Movimiento;
using CrediAgro.Infrastructure.Persistence.UnitOfWork.Reportes;
using CrediAgro.Infrastructure.Persistence.UnitOfWork.Seguridad;
using Microsoft.Extensions.DependencyInjection;

namespace CrediAgro.Infrastructure.DependencyInjection;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Catalogo repositories
        services.AddScoped<ICatalogoRepository, CatalogoRepository>();
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IComarcaRepository, ComarcaRepository>();
        services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        services.AddScoped<IFiadorRepository, FiadorRepository>();
        services.AddScoped<IFrecuenciaPagoRepository, FrecuenciaPagoRepository>();
        services.AddScoped<IMonedaRepository, MonedaRepository>();
        services.AddScoped<IMunicipioRepository, MunicipioRepository>();
        services.AddScoped<IPersonaRepository, PersonaRepository>();
        services.AddScoped<IRubroRepository, RubroRepository>();
        services.AddScoped<IRubroDetalleRepository, RubroDetalleRepository>();
        services.AddScoped<ITipoCambioRepository, TipoCambioRepository>();
        services.AddScoped<IValorCatalogoRepository, ValorCatalogoRepository>();

        // Movimiento repositories
        services.AddScoped<ICreditoRepository, CreditoRepository>();
        services.AddScoped<IDesembolsoRepository, DesembolsoRepository>();
        services.AddScoped<IDesembolsoDetalleRepository, DesembolsoDetalleRepository>();
        services.AddScoped<IDocumentosRepository, DocumentosRepository>();
        services.AddScoped<IDocumentoSolicitudRepository, DocumentoSolicitudRepository>();
        services.AddScoped<IPagoCuotaRepository, PagoCuotaRepository>();
        services.AddScoped<IPagoCuotaDetalleRepository, PagoCuotaDetalleRepository>();
        services.AddScoped<ITablaProyeccionRepository, TablaProyeccionRepository>();

        // Seguridad repositories
        services.AddScoped<IAccionRepository, AccionRepository>();
        services.AddScoped<IAplicacionRepository, AplicacionRepository>();
        services.AddScoped<ICuentaRepository, CuentaRepository>();
        services.AddScoped<ICuentaRolRepository, CuentaRolRepository>();
        services.AddScoped<IModuloRepository, ModuloRepository>();
        services.AddScoped<IRolAccionRepository, RolAccionRepository>();
        services.AddScoped<IRolRepository, RolRepository>();
        services.AddScoped<IServicioUsuarioRepository, ServicioUsuarioRepository>();

        // Reportes repositories
        services.AddScoped<IReportesCatalogosRepository, ReportesCatalogosRepository>();
        services.AddScoped<IReportesCreditoRepository, ReportesCreditoRepository>();

        // UnitOfWork per module
        services.AddScoped<ICatalogoUnitOfWork, CatalogoUnitOfWork>();
        services.AddScoped<IMovimientoUnitOfWork, MovimientoUnitOfWork>();
        services.AddScoped<ISeguridadUnitOfWork, SeguridadUnitOfWork>();
        services.AddScoped<IReportesUnitOfWork, ReportesUnitOfWork>();

        return services;
    }
}
