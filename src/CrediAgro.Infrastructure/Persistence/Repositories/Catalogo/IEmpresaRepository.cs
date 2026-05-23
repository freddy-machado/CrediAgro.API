using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IEmpresaRepository : IRepository<vwEmpresa>
{
    Task<IEnumerable<vwEmpresa>> DatosEmpresaAsync();
    Task<EmpresaDatos?> EmpresaDatosAsync();
}
