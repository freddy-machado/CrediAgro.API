using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class CuentaRepository : Repository<SsgCuentum>, ICuentaRepository
{
    public CuentaRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<SsgCuentum?> ObtenerCuentaPorLoginAsync(string login) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(c => c.cLogin == login);

    public async Task<bool> VerificarLoginExistenteAsync(string login) =>
        await _dbSet.AsNoTracking()
            .AnyAsync(c => c.cLogin == login);

    public async Task<IEnumerable<SsgCuentum>> ListadoCuentasAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();
}
