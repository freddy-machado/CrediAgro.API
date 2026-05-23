using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class ModuloRepository : Repository<SsgModulo>, IModuloRepository
{
    public ModuloRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgModulo>> ListadoModulosAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();

    public async Task<IEnumerable<SsgModulo>> ListadoModulosPorAplicacionIdAsync(int aplicacionId) =>
        await _dbSet.AsNoTracking()
            .Where(m => m.objAplicacionID == aplicacionId)
            .ToListAsync();
}
