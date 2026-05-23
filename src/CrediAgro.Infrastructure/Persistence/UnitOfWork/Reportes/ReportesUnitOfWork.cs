using CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Reportes;

public class ReportesUnitOfWork : IReportesUnitOfWork
{
    public IReportesCatalogosRepository ReportesCatalogos { get; }
    public IReportesCreditoRepository ReportesCredito { get; }

    public ReportesUnitOfWork(SCreditoCmDbContext context)
    {
        ReportesCatalogos = new ReportesCatalogosRepository(context);
        ReportesCredito = new ReportesCreditoRepository(context);
    }
}
