using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IMunicipioRepository : IRepository<StbMunicipio>
{
    Task<IEnumerable<StbMunicipio>> ListadoMunicipiosXDepartamentoAsync(int departamentoId);
}
