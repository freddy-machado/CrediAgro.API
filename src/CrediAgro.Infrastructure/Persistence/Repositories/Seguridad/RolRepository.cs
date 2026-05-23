using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class RolRepository : Repository<SsgRol>, IRolRepository
{
    public RolRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgRol>> ListadoRolesAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();
}
