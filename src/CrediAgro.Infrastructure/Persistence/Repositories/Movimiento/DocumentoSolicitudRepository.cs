using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Movimiento;

public class DocumentoSolicitudRepository : Repository<ScrDocumentoSolicitud>, IDocumentoSolicitudRepository
{
    public DocumentoSolicitudRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<ScrDocumento>> ListaDocumentosSinAsociarAsync() =>
        await _context.ScrDocumentos.AsNoTracking()
            .Where(d => !_context.ScrDocumentoSolicituds.Any(ds => ds.nScrDocumentoID == d.nScrDocumentoID))
            .ToListAsync();

    public async Task<IEnumerable<ScrDocumento>> ListaDocumentosAsociadosClienteAsync(int clienteId) =>
        await (from ds in _context.ScrDocumentoSolicituds.AsNoTracking()
               join d in _context.ScrDocumentos.AsNoTracking() on ds.nScrDocumentoID equals d.nScrDocumentoID
               join c in _context.ScrCreditos.AsNoTracking() on ds.nScrSolicitudID equals c.nScrSolicitudID
               where c.nStbClienteID == clienteId
               select d).ToListAsync();

    public async Task<bool> VerificarDocumentoSolicitudPorCreditoIdAsync(int creditoId) =>
        await _dbSet.AsNoTracking()
            .AnyAsync(ds => ds.nScrSolicitudID == creditoId);

    public async Task<IEnumerable<DocumentosAsociados>> ListaDocumentosAsociadosCreditoAsync(int creditoId) =>
        await (from ds in _context.ScrDocumentoSolicituds.AsNoTracking()
               join d in _context.ScrDocumentos.AsNoTracking() on ds.nScrDocumentoID equals d.nScrDocumentoID
               join c in _context.ScrCreditos.AsNoTracking() on ds.nScrSolicitudID equals c.nScrSolicitudID
               join cl in _context.StbClientes.AsNoTracking() on c.nStbClienteID equals cl.nStbClienteID
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               where ds.nScrSolicitudID == creditoId
               select new DocumentosAsociados
               {
                   creditoSolicitudID = ds.nDocumentoReferenciaID,
                   creditoID = ds.nScrSolicitudID,
                   documentoID = ds.nScrDocumentoID,
                   noSolicitud = c.nNumeroSolicitud ?? "",
                   cliente = (p.cNombre1 + " " + (p.cApellido1 ?? "")).Trim(),
                   documento = d.cNombreDocumento ?? "",
                   documentoFoto = d.bImagen
               }).ToListAsync();
}
