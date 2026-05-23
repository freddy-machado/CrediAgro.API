using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class AccionRepository : Repository<SsgAccion>, IAccionRepository
{
    public AccionRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgAccion>> ListadoAccionesAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();

    public async Task<IEnumerable<SsgAccion>> ListadoAccionesPorServicioUsuarioIdAsync(int servicioUsuarioId) =>
        await _dbSet.AsNoTracking()
            .Where(a => a.objServicioUsuarioID == servicioUsuarioId)
            .ToListAsync();
}
