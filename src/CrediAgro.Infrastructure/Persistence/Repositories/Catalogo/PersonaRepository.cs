using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.CustomTabEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class PersonaRepository : Repository<StbPersona>, IPersonaRepository
{
    public PersonaRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<PersonaList>> ListadoPersonasAsync() =>
        await (from p in _context.StbPersonas.AsNoTracking()
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               select new PersonaList
               {
                   PersonaID = p.nStbPersonaID,
                   Nombre1 = p.cNombre1,
                   Nombre2 = p.cNombre2 ?? "",
                   Apellido1 = p.cApellido1 ?? "",
                   Apellido2 = p.cApellido2 ?? "",
                   Direccion = p.cDireccion ?? "",
                   Activo = p.nPersonaActiva == 1,
                   Municipio = m.sNombre,
                   Cedula = p.cNumeroCedula ?? "",
                   fechaNacimiento = p.dFechaNacApertura.HasValue ? p.dFechaNacApertura.Value.ToString("dd/MM/yyyy") : ""
               }).ToListAsync();

    public async Task<IEnumerable<PersonaCombo>> ListadoPersonasComboAsync() =>
        await (from p in _context.StbPersonas.AsNoTracking()
               select new PersonaCombo
               {
                   personaID = p.nStbPersonaID,
                   personaName = (p.cNombre1 + " " + (p.cNombre2 ?? "") + " " + (p.cApellido1 ?? "") + " " + (p.cApellido2 ?? "")).Trim()
               }).ToListAsync();

    public async Task<PersonaList?> ObtenerPersonaGenericaAsync(int personaId) =>
        await (from p in _context.StbPersonas.AsNoTracking()
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               where p.nStbPersonaID == personaId
               select new PersonaList
               {
                   PersonaID = p.nStbPersonaID,
                   Nombre1 = p.cNombre1,
                   Nombre2 = p.cNombre2 ?? "",
                   Apellido1 = p.cApellido1 ?? "",
                   Apellido2 = p.cApellido2 ?? "",
                   Direccion = p.cDireccion ?? "",
                   Activo = p.nPersonaActiva == 1,
                   Municipio = m.sNombre,
                   Cedula = p.cNumeroCedula ?? "",
                   fechaNacimiento = p.dFechaNacApertura.HasValue ? p.dFechaNacApertura.Value.ToString("dd/MM/yyyy") : ""
               }).FirstOrDefaultAsync();

    public async Task<PersonaTab?> PersonaTabAsync(int id) =>
        await (from p in _context.StbPersonas.AsNoTracking()
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               where p.nStbPersonaID == id
               select new PersonaTab
               {
                   fechaNacimiento = p.dFechaNacApertura.HasValue ? p.dFechaNacApertura.Value.ToString("dd/MM/yyyy") : "",
                   cedula = p.cNumeroCedula ?? "",
                   municipio = m.sNombre,
                   direccion = p.cDireccion ?? ""
               }).FirstOrDefaultAsync();
}
