using CrediAgro.Infrastructure.Persistence.Reportes;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

public interface IReportesCreditoRepository
{
    Task<IEnumerable<CarteraRptEntity>> ReporteCarteraAsync(int? rubroId, int? comarcaId);
    Task<IEnumerable<DesembolsoRptEntity>> ReporteDesembolsosAsync(DateTime fechaInicio, DateTime fechaFin);
    Task<IEnumerable<TablaPagoRptEntity>> ReporteTablaPagosAsync(int creditoId);
    Task<IEnumerable<EstadoCuentaEntity>> ReporteEstadoCuentaAsync(int creditoId);
}
