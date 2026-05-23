using CrediAgro.Infrastructure.Persistence.CustomEntities;
using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

public class EmpresaRepository : Repository<vwEmpresa>, IEmpresaRepository
{
    public EmpresaRepository(SCreditoCmDbContext context) : base(context) { }

    public async Task<IEnumerable<vwEmpresa>> DatosEmpresaAsync() =>
        await _dbSet.AsNoTracking().ToListAsync();

    public async Task<EmpresaDatos?> EmpresaDatosAsync() =>
        await (from e in _context.StbEmpresas.AsNoTracking()
               select new EmpresaDatos
               {
                   nStbEmpresaID = e.nStbEmpresaID,
                   cNombreEmpresa = e.cNombreInstitucion,
                   cNombreCortoEmpresa = e.cNombreCorto,
                   cRazonSocialEmpresa = e.cRazonSocial,
                   cDireccionEmpresa = e.cDireccion,
                   cNumeroRUCEmpresa = e.cNumeroRUC,
                   cNumeroPatronalEmpresa = e.cNumeroPatronal ?? "",
                   bLogoEmpresa = e.bLogo
               }).FirstOrDefaultAsync();
}
