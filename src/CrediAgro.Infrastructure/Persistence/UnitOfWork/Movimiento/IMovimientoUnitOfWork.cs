using CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Movimiento;

public interface IMovimientoUnitOfWork
{
    ICreditoRepository Creditos { get; }
    IDesembolsoRepository Desembolsos { get; }
    IDesembolsoDetalleRepository DesembolsoDetalles { get; }
    IDocumentosRepository Documentos { get; }
    IDocumentoSolicitudRepository DocumentoSolicitudes { get; }
    IPagoCuotaRepository PagoCuotas { get; }
    IPagoCuotaDetalleRepository PagoCuotaDetalles { get; }
    ITablaProyeccionRepository TablaProyecciones { get; }

    Task<int> SaveChangesAsync();
}
