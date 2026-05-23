using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class PagoCuotaDetalleRepository : Repository<ScrPagoCuotaDetalle>, IPagoCuotaDetalleRepository
{
    public PagoCuotaDetalleRepository(SCreditoCmDbContext context) : base(context) { }
}
