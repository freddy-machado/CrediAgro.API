using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class CatalogoRepository : Repository<StbCatalogo>, ICatalogoRepository
{
    public CatalogoRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<StbCatalogo>> ListadoCatalogosAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();

    public async Task<StbCatalogo?> ObtenerCatalogoPorNombreAsync(string catalogoName) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(c => c.cNombre == catalogoName);
}
