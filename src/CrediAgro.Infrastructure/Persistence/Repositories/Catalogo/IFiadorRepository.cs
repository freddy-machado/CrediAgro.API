using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IFiadorRepository : IRepository<StbFiador>
{
    Task<bool> VerificaFiadorPersonaIdAsync(int personaId);
    Task<IEnumerable<FiadorList>> ListadoFiadoresAsync();
    Task<bool> VerificaFiadorPorCreditoAsync(int creditoId);
    Task<bool> VerificarFiadorCreditoProcesoAsync(int creditoId);
    Task<bool> VerificarCreditosValidosPorFiadorAsync(int fiadorId);
    Task<IEnumerable<StbFiador>> FiadoresPrestamoActivoAsync(int personaId);
}
