using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class FrecuenciaPagoRepository : Repository<StbFrecuenciaPago>, IFrecuenciaPagoRepository
{
    public FrecuenciaPagoRepository(SCreditoCmDbContext context) : base(context) { }
}
