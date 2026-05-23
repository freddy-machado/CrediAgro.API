using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class AplicacionRepository : Repository<SsgAplicacion>, IAplicacionRepository
{
    public AplicacionRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgAplicacion>> ListadoAplicacionesAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();
}
