using CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Reportes;

public class ReportesUnitOfWork : IReportesUnitOfWork
{
    private readonly SCreditoCmDbContext _context;

    public IReportesCatalogosRepository ReportesCatalogos { get; }
    public IReportesCreditoRepository ReportesCredito { get; }

    public ReportesUnitOfWork(SCreditoCmDbContext context)
    {
        _context = context;
        ReportesCatalogos = new ReportesCatalogosRepository(context);
        ReportesCredito = new ReportesCreditoRepository(context);
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
}
