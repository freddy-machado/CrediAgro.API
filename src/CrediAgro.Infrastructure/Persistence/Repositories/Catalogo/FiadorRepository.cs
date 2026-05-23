using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class FiadorRepository : Repository<StbFiador>, IFiadorRepository
{
    public FiadorRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<bool> VerificaFiadorPersonaIdAsync(int personaId) =>
        await _dbSet.AsNoTracking().AnyAsync(f => f.nStbPersonaID == personaId);

    public async Task<IEnumerable<FiadorList>> ListadoFiadoresAsync() =>
        await (from f in _context.StbFiadors.AsNoTracking()
               join p in _context.StbPersonas.AsNoTracking() on f.nStbPersonaID equals p.nStbPersonaID
               join m in _context.StbMunicipios.AsNoTracking() on p.nStbMunicipioID equals m.nStbMunicipioID
               select new FiadorList
               {
                   fiadorID = f.nStbFiadorID,
                   personaID = f.nStbPersonaID,
                   fiadorName = (p.cNombre1 + " " + (p.cNombre2 ?? "") + " " + (p.cApellido1 ?? "") + " " + (p.cApellido2 ?? "")).Trim(),
                   municipio = m.sNombre,
                   lugarTrabajo = f.cLugarTrabajo ?? ""
               }).ToListAsync();

    public async Task<bool> VerificaFiadorPorCreditoAsync(int creditoId) =>
        await _dbSet.AsNoTracking().AnyAsync(f => f.nStbSolicitudID == creditoId);

    public async Task<bool> VerificarFiadorCreditoProcesoAsync(int creditoId) =>
        await _dbSet.AsNoTracking().AnyAsync(f => f.nStbSolicitudID == creditoId);

    public async Task<bool> VerificarCreditosValidosPorFiadorAsync(int fiadorId) =>
        await _dbSet.AsNoTracking().AnyAsync(f => f.nStbFiadorID == fiadorId);

    public async Task<IEnumerable<StbFiador>> FiadoresPrestamoActivoAsync(int personaId) =>
        await _dbSet.AsNoTracking().Where(f => f.nStbPersonaID == personaId).ToListAsync();
}
