using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class MonedaRepository : Repository<StbMonedum>, IMonedaRepository
{
    public MonedaRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<StbMonedum?> ObtenerMonedaPorCodigoAsync(string codigo) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(m => m.cCodigoInterno == codigo);
}
