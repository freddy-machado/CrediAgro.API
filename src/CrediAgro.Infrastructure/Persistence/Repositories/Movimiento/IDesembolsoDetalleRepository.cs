using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface IDesembolsoDetalleRepository : IRepository<ScrDesembolsoPago>
{
    Task<IEnumerable<DesembolsoPagoEntityList>> ListaPagosDesembolsoAsync(int desembolsoId);
    Task<DesembolsoDetalleEntity?> PagoDesembolsoPorDesembolsoIdAsync(int desembolsoId);
    Task<decimal> CalculaMontoPagadoDelDesembolsoAsync(int desembolsoId);
    Task<DateTime> ObtenerFechaPagoDesembolsoPorCreditoIdAsync(int creditoId);
}
