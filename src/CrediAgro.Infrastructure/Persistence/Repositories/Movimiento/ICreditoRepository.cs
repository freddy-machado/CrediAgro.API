using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface ICreditoRepository : IRepository<ScrCredito>
{
    Task<IEnumerable<CreditoList>> ListadoCreditosAsync();
    Task<bool> VerificarCreditoExistenteAsync(ScrCredito obj);
    Task<IEnumerable<CreditoListCombo>> ListaCreditosComboAsync(int estadoDesembolsoId);
    Task<CreditoEntity?> ObtenerEntidadCreditoAsync(int creditoId);
    Task<IEnumerable<CreditoList>> ListadoCreditosPorEstadoIdAsync(int estadoId);
    Task<IEnumerable<CreditoListCombo>> ListaCreditosEnProcesoComboFiadorAsync(int estadoCreditoId);
    Task<CreditoListCombo?> CreditoComboFiadorPorCreditoIdAsync(int creditoId);
    Task<string> ObtenerNumeroCreditoAsync();
    Task<bool> VerificarCreditoFiadorAsync(int creditoId);
    Task<IEnumerable<CreditoListCombo>> ListaCreditosComboPorEstadosAsync(IEnumerable<string> codigos);
}
