using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.CustomTabEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IPersonaRepository : IRepository<StbPersona>
{
    Task<IEnumerable<PersonaList>> ListadoPersonasAsync();
    Task<IEnumerable<PersonaCombo>> ListadoPersonasComboAsync();
    Task<PersonaList?> ObtenerPersonaGenericaAsync(int personaId);
    Task<PersonaTab?> PersonaTabAsync(int id);
}
