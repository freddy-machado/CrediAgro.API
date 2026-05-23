using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface IDesembolsoRepository : IRepository<ScrDesembolso>
{
    Task<ScrDesembolso?> ObtenerDesembolsoPorCreditoIdAsync(int creditoId);
    Task<IEnumerable<DesembolsoEntity>> ListadoDesembolsosAsync();
    Task<int> AutorizarDesembolsoAsync(int estadoAutorizadoId, int desembolsoId);
    Task<int> AnularDesembolsoAsync(int estadoAnuladoId, int desembolsoId);
    Task<int> ActualizarEstadoDesembolsoAsync(int estadoDesembolso, int desembolsoId, DateTime fecha);
}
