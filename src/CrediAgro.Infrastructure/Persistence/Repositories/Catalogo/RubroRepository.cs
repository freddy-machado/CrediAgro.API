using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class RubroRepository : Repository<StbRubro>, IRubroRepository
{
    public RubroRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<StbRubroDetalle?> VerificarRubroDetallePorRubroIdAsync(int rubroId) =>
        await _context.StbRubroDetalles.AsNoTracking()
            .FirstOrDefaultAsync(rd => rd.nStbRubroID == rubroId);
}
