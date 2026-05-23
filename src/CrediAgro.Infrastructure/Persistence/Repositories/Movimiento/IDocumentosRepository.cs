using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public interface IDocumentosRepository : IRepository<ScrDocumento>
{
    Task<IEnumerable<DocumentosList>> ListadoDocumentosAsync();
}
