using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class RolAccionRepository : Repository<SsgRolAccion>, IRolAccionRepository
{
    public RolAccionRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgRolAccion>> ListadoAccionesPorRolIdAsync(int rolId) =>
        await _dbSet.AsNoTracking()
            .Where(ra => ra.objRolID == rolId)
            .ToListAsync();

    public async Task<bool> VerificarAccionPorRolYAccionIdAsync(int rolId, int accionId) =>
        await _dbSet.AsNoTracking()
            .AnyAsync(ra => ra.objRolID == rolId && ra.objAccionID == accionId);
}
