using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class ComarcaRepository : Repository<StbBarrioComarca>, IComarcaRepository
{
    public ComarcaRepository(SCreditoCmDbContext context) : base(context) { }
}
