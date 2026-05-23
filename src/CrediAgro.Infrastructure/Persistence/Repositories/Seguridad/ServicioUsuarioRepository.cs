using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Seguridad;

public class ServicioUsuarioRepository : Repository<SsgServicioUsuario>, IServicioUsuarioRepository
{
    public ServicioUsuarioRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<SsgServicioUsuario>> ListadoServiciosUsuarioAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();

    public async Task<IEnumerable<SsgServicioUsuario>> ListadoServiciosUsuarioPorModuloIdAsync(int moduloId) =>
        await _dbSet.AsNoTracking()
            .Where(s => s.objModuloID == moduloId)
            .ToListAsync();
}
