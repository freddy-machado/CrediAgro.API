using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class RubroDetalleRepository : Repository<StbRubroDetalle>, IRubroDetalleRepository
{
    public RubroDetalleRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<StbRubroDetalle?> ObtenerRubroDetallePorRubroIdAsync(int rubroId) =>
        await _dbSet.AsNoTracking().FirstOrDefaultAsync(rd => rd.nStbRubroID == rubroId);

    public async Task<StbRubro?> ObtenerRubroPorRubroDetalleIdAsync(int rubroDetalleId) =>
        await (from rd in _context.StbRubroDetalles.AsNoTracking()
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               where rd.nStbRubroDetalleID == rubroDetalleId
               select r).FirstOrDefaultAsync();

    public async Task<RubroDetalleEntity?> ObtenerRubroDetalleEntityPorRubroDetalleIdAsync(int rubroDetalleId) =>
        await (from rd in _context.StbRubroDetalles.AsNoTracking()
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join fp in _context.StbFrecuenciaPagos.AsNoTracking() on rd.nStbFrecuenciaPagoID equals fp.nStbFrecuenciaPagoID
               where rd.nStbRubroDetalleID == rubroDetalleId
               select new RubroDetalleEntity
               {
                   rubroID = r.nStbRubroID,
                   rubroDetalleID = rd.nStbRubroDetalleID,
                   rubro = r.cDescripcion,
                   comisionPor = rd.nComision ?? 0,
                   plazoMeses = rd.nPlazo,
                   frecuenciaPago = fp.cDescripcion
               }).FirstOrDefaultAsync();

    public async Task<IEnumerable<RubroDetalleList>> ListaDetalleRubrosPorRubroIdAsync(int rubroId) =>
        await (from rd in _context.StbRubroDetalles.AsNoTracking()
               join r in _context.StbRubros.AsNoTracking() on rd.nStbRubroID equals r.nStbRubroID
               join fp in _context.StbFrecuenciaPagos.AsNoTracking() on rd.nStbFrecuenciaPagoID equals fp.nStbFrecuenciaPagoID
               where rd.nStbRubroID == rubroId
               select new RubroDetalleList
               {
                   detalleId = rd.nStbRubroDetalleID,
                   rubroId = rd.nStbRubroID,
                   rubro = r.cDescripcion,
                   frecuenciaPago = fp.cDescripcion,
                   tasaInteres = rd.nTasaInteres ?? 0,
                   plazo = rd.nPlazo,
                   estado = rd.nEstado == 1
               }).ToListAsync();

    public async Task<int> AnularRubroDetalleAsync(int rubroDetalleId)
    {
        var rd = await _dbSet.FindAsync(rubroDetalleId);
        if (rd == null) return 0;
        rd.nEstado = 0;
        _context.StbRubroDetalles.Update(rd);
        return 1;
    }

    public async Task<bool> VerificarRubroDetalleEnCreditoAsync(int rubroDetalleId) =>
        await _context.ScrCreditos.AsNoTracking()
            .AnyAsync(c => c.nStbRubroDetalleID == rubroDetalleId);
}
