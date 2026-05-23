using CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Movimiento;

public class MovimientoUnitOfWork : IMovimientoUnitOfWork
{
    private readonly SCreditoCmDbContext _context;

    public ICreditoRepository Creditos { get; }
    public IDesembolsoRepository Desembolsos { get; }
    public IDesembolsoDetalleRepository DesembolsoDetalles { get; }
    public IDocumentosRepository Documentos { get; }
    public IDocumentoSolicitudRepository DocumentoSolicitudes { get; }
    public IPagoCuotaRepository PagoCuotas { get; }
    public IPagoCuotaDetalleRepository PagoCuotaDetalles { get; }
    public ITablaProyeccionRepository TablaProyecciones { get; }

    public MovimientoUnitOfWork(SCreditoCmDbContext context)
    {
        _context = context;
        Creditos = new CreditoRepository(context);
        Desembolsos = new DesembolsoRepository(context);
        DesembolsoDetalles = new DesembolsoDetalleRepository(context);
        Documentos = new DocumentosRepository(context);
        DocumentoSolicitudes = new DocumentoSolicitudRepository(context);
        PagoCuotas = new PagoCuotaRepository(context);
        PagoCuotaDetalles = new PagoCuotaDetalleRepository(context);
        TablaProyecciones = new TablaProyeccionRepository(context);
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
}
