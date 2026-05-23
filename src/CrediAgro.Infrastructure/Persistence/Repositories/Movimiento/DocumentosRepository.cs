using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class DocumentosRepository : Repository<ScrDocumento>, IDocumentosRepository
{
    public DocumentosRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<DocumentosList>> ListadoDocumentosAsync() =>
        await (from d in _context.ScrDocumentos.AsNoTracking()
               join vc in _context.StbValorCatalogos.AsNoTracking() on d.nStbTipoDocumento equals vc.nStbValorCatalogoID
               select new DocumentosList
               {
                   documentoID = d.nScrDocumentoID,
                   tipoDocumento = vc.cDescripcion,
                   nombreDocumento = d.cNombreDocumento ?? "",
                   foto = d.bImagen
               }).ToListAsync();
}
