using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.CustomTabEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public interface IClienteRepository : IRepository<StbCliente>
{
    Task<StbCliente?> VerificaClientePersonaIdAsync(int personaId);
    Task<IEnumerable<ClienteList>> ListadoClientesAsync();
    Task<IEnumerable<ClienteCombo>> ListadoClientesComboAsync();
    Task<ClienteTab?> ClienteTabAsync(int id);
    Task<bool> VerificaClienteCreditoActivoPorPersonaIdAsync(int personaId);
    Task<bool> VerificaClienteHaTenidoCreditoAsync(int clienteId);
    Task<bool> ActualizarEstadoTrabajaClienteAsync(int clienteId, bool estado);
}
