using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class MunicipioRepository : Repository<StbMunicipio>, IMunicipioRepository
{
    public MunicipioRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<StbMunicipio>> ListadoMunicipiosXDepartamentoAsync(int departamentoId) =>
        await _dbSet.AsNoTracking()
            .Where(m => m.nStbDepartamentoID == departamentoId)
            .ToListAsync();
}
