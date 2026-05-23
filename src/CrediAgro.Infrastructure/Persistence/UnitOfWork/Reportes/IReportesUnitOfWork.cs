using CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Reportes;

public interface IReportesUnitOfWork
{
    IReportesCatalogosRepository ReportesCatalogos { get; }
    IReportesCreditoRepository ReportesCredito { get; }
}
