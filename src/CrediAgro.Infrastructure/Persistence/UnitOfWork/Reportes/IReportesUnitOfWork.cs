using CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Reportes;

public interface IReportesUnitOfWork
{
    IReportesCatalogosRepository ReportesCatalogos { get; }
    IReportesCreditoRepository ReportesCredito { get; }

    /// <summary>
    /// Reportes module is primarily read-only; SaveChangesAsync is provided for cases
    /// where reporting operations require persisting state.
    /// </summary>
    Task<int> SaveChangesAsync();
}
