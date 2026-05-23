using CrediAgro.Infrastructure.Persistence.Reportes;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

public interface IReportesCatalogosRepository
{
    Task<IEnumerable<Clientes>> ReporteListadoClientesAsync();
}
