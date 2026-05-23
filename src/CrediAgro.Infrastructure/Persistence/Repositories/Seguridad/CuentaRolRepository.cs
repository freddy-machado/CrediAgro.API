using CrediAgro.Infrastructure.Persistence.Models;
using CrediAgro.Infrastructure.Persistence.Seguridad;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class CuentaRolRepository : Repository<SsgCuentaRol>, ICuentaRolRepository
{
    public CuentaRolRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<CuentaRolEntity>> ListadoCuentaRolesPorCuentaIdAsync(int cuentaId) =>
        await (from cr in _context.SsgCuentaRols.AsNoTracking()
               join c in _context.SsgCuenta.AsNoTracking() on cr.objCuentaID equals c.nSsgCuentaID
               join r in _context.SsgRols.AsNoTracking() on cr.objRolID equals r.SsgRolID
               where cr.objCuentaID == cuentaId
               select new CuentaRolEntity
               {
                   cuentaId_ = cr.objCuentaID,
                   rolId_ = cr.objRolID,
                   rol_ = r.Nombre,
                   cuenta_ = c.cLogin
               }).ToListAsync();

    public async Task<bool> VerificarCuentaRolExistenteAsync(int cuentaId, int rolId) =>
        await _dbSet.AsNoTracking()
            .AnyAsync(cr => cr.objCuentaID == cuentaId && cr.objRolID == rolId);
}
