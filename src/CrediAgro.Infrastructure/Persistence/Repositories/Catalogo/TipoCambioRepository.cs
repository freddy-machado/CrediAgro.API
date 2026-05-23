using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class TipoCambioRepository : Repository<StbParidadCambiarium>, ITipoCambioRepository
{
    public TipoCambioRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<StbParidadCambiarium?> ObtenerTipoCambioFechaAsync(DateTime fecha) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(tc => tc.dFechaTCambio.Date == fecha.Date);

    public async Task<IEnumerable<TipoCambioList>> ListaTiposCambioAsync() =>
        await (from tc in _context.StbParidadCambiaria.AsNoTracking()
               select new TipoCambioList
               {
                   id = tc.nStbParidadCambiariaID,
                   anio = tc.dFechaTCambio.Year.ToString(),
                   mes = tc.dFechaTCambio.Month.ToString("D2"),
                   fecha = tc.dFechaTCambio,
                   monto = tc.nMontoTCambio
               }).ToListAsync();
}
