using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class ValorCatalogoRepository : Repository<StbValorCatalogo>, IValorCatalogoRepository
{
    public ValorCatalogoRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<StbValorCatalogo>> ListadoValoresCatalogosXCatalogoIdAsync(int catalogoId) =>
        await _dbSet.AsNoTracking()
            .Where(v => v.nStbCatalogoID == catalogoId)
            .ToListAsync();

    public async Task<IEnumerable<StbValorCatalogo>> ListadoValoresCatalogosXCatalogoNameAsync(string catalogoName) =>
        await (from v in _context.StbValorCatalogos.AsNoTracking()
               join c in _context.StbCatalogos.AsNoTracking() on v.nStbCatalogoID equals c.nStbCatalogoID
               where c.cNombre == catalogoName
               select v).ToListAsync();

    public async Task<StbValorCatalogo?> ObtenerCatalogoPorCodigoInternoAsync(string catalogoName, string codigoInterno) =>
        await (from v in _context.StbValorCatalogos.AsNoTracking()
               join c in _context.StbCatalogos.AsNoTracking() on v.nStbCatalogoID equals c.nStbCatalogoID
               where c.cNombre == catalogoName && v.cCodigoInterno == codigoInterno
               select v).FirstOrDefaultAsync();
}
