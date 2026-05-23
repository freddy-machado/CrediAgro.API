using CrediAgro.Infrastructure.Persistence.Reportes;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Reportes;

public class ReportesCatalogosRepository : IReportesCatalogosRepository
{
    private readonly SCreditoCmDbContext _context;

    public ReportesCatalogosRepository(SCreditoCmDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Clientes>> ReporteListadoClientesAsync() =>
        await (from cl in _context.StbClientes.AsNoTracking()
               join p in _context.StbPersonas.AsNoTracking() on cl.nStbPersonaID equals p.nStbPersonaID
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               select new Clientes
               {
                   nStbClienteID = cl.nStbClienteID,
                   nStbPersonaID = p.nStbPersonaID,
                   nombresApellidos = (p.cNombre1 + " " + (p.cNombre2 ?? "") + " " + (p.cApellido1 ?? "") + " " + (p.cApellido2 ?? "")).Trim(),
                   cNumeroCedula = p.cNumeroCedula ?? "",
                   cDireccion = p.cDireccion ?? "",
                   nTrabaja = cl.nTrabaja ?? false,
                   cLugarTrabajo = cl.cLugarTrabajo ?? "",
                   cObservaciones = cl.cObservaciones ?? "",
                   cTelefono1 = p.cTelefono1 ?? "",
                   cCelular1 = p.cCelular1 ?? "",
                   cEMail = p.cEMail ?? "",
                   bFoto = p.bFoto,
                   municipio = m.sNombre,
                   dFechaNacApertura = p.dFechaNacApertura ?? DateTime.MinValue
               }).ToListAsync();
}
