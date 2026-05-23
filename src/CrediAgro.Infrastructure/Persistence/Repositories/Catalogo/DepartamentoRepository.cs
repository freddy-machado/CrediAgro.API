using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class DepartamentoRepository : Repository<StbDepartamento>, IDepartamentoRepository
{
    public DepartamentoRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<StbDepartamento>> ListadoDepartamentosAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();
}
