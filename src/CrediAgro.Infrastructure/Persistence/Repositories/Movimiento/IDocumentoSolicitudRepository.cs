using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface IDocumentoSolicitudRepository : IRepository<ScrDocumentoSolicitud>
{
    Task<IEnumerable<ScrDocumento>> ListaDocumentosSinAsociarAsync();
    Task<IEnumerable<ScrDocumento>> ListaDocumentosAsociadosClienteAsync(int clienteId);
    Task<bool> VerificarDocumentoSolicitudPorCreditoIdAsync(int creditoId);
    Task<IEnumerable<DocumentosAsociados>> ListaDocumentosAsociadosCreditoAsync(int creditoId);
}
