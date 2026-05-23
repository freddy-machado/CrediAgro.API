using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.CustomTabEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class ClienteRepository : Repository<StbCliente>, IClienteRepository
{
    public ClienteRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<StbCliente?> VerificaClientePersonaIdAsync(int personaId) =>
        await _dbSet.AsNoTracking()
            .FirstOrDefaultAsync(c => c.nStbPersonaID == personaId);

    public async Task<IEnumerable<ClienteList>> ListadoClientesAsync() =>
        await (from c in _context.StbClientes.AsNoTracking()
               join p in _context.StbPersonas.AsNoTracking() on c.nStbPersonaID equals p.nStbPersonaID
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               select new ClienteList
               {
                   clienteID = c.nStbClienteID,
                   personaID = c.nStbPersonaID,
                   clienteName = (p.cNombre1 + " " + (p.cNombre2 ?? "") + " " + (p.cApellido1 ?? "") + " " + (p.cApellido2 ?? "")).Trim(),
                   municipio = m.sNombre,
                   lugarTrabajo = c.cLugarTrabajo ?? "",
                   observacion = c.cObservaciones ?? ""
               }).ToListAsync();

    public async Task<IEnumerable<ClienteCombo>> ListadoClientesComboAsync() =>
        await (from c in _context.StbClientes.AsNoTracking()
               join p in _context.StbPersonas.AsNoTracking() on c.nStbPersonaID equals p.nStbPersonaID
               select new ClienteCombo
               {
                   clienteID = c.nStbClienteID,
                   clienteName = (p.cNombre1 + " " + (p.cNombre2 ?? "") + " " + (p.cApellido1 ?? "") + " " + (p.cApellido2 ?? "")).Trim()
               }).ToListAsync();

    public async Task<ClienteTab?> ClienteTabAsync(int id) =>
        await (from c in _context.StbClientes.AsNoTracking()
               join p in _context.StbPersonas.AsNoTracking() on c.nStbPersonaID equals p.nStbPersonaID
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               where c.nStbClienteID == id
               select new ClienteTab
               {
                   fechaNacimiento = p.dFechaNacApertura.HasValue ? p.dFechaNacApertura.Value.ToString("dd/MM/yyyy") : "",
                   cedula = p.cNumeroCedula ?? "",
                   municipio = m.sNombre,
                   direccion = p.cDireccion ?? ""
               }).FirstOrDefaultAsync();

    public async Task<bool> VerificaClienteCreditoActivoPorPersonaIdAsync(int personaId)
    {
        var cliente = await _context.StbClientes.AsNoTracking()
            .FirstOrDefaultAsync(c => c.nStbPersonaID == personaId);
        if (cliente == null) return false;
        return await _context.ScrCreditos.AsNoTracking()
            .AnyAsync(cr => cr.nStbClienteID == cliente.nStbClienteID);
    }

    public async Task<bool> VerificaClienteHaTenidoCreditoAsync(int clienteId) =>
        await _context.ScrCreditos.AsNoTracking()
            .AnyAsync(cr => cr.nStbClienteID == clienteId);

    public async Task<bool> ActualizarEstadoTrabajaClienteAsync(int clienteId, bool estado)
    {
        var cliente = await _dbSet.FindAsync(clienteId);
        if (cliente == null) return false;
        cliente.nTrabaja = estado;
        _context.StbClientes.Update(cliente);
        return true;
    }
}
