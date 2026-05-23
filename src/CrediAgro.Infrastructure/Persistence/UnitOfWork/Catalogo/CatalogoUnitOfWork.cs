using CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Catalogo;

public class CatalogoUnitOfWork : ICatalogoUnitOfWork
{
    private readonly SCreditoCmDbContext _context;

    public ICatalogoRepository Catalogos { get; }
    public IClienteRepository Clientes { get; }
    public IComarcaRepository Comarcas { get; }
    public IDepartamentoRepository Departamentos { get; }
    public IEmpresaRepository Empresas { get; }
    public IFiadorRepository Fiadores { get; }
    public IFrecuenciaPagoRepository FrecuenciaPagos { get; }
    public IMonedaRepository Monedas { get; }
    public IMunicipioRepository Municipios { get; }
    public IPersonaRepository Personas { get; }
    public IRubroRepository Rubros { get; }
    public IRubroDetalleRepository RubroDetalles { get; }
    public ITipoCambioRepository TiposCambio { get; }
    public IValorCatalogoRepository ValoresCatalogo { get; }

    public CatalogoUnitOfWork(SCreditoCmDbContext context)
    {
        _context = context;
        Catalogos = new CatalogoRepository(context);
        Clientes = new ClienteRepository(context);
        Comarcas = new ComarcaRepository(context);
        Departamentos = new DepartamentoRepository(context);
        Empresas = new EmpresaRepository(context);
        Fiadores = new FiadorRepository(context);
        FrecuenciaPagos = new FrecuenciaPagoRepository(context);
        Monedas = new MonedaRepository(context);
        Municipios = new MunicipioRepository(context);
        Personas = new PersonaRepository(context);
        Rubros = new RubroRepository(context);
        RubroDetalles = new RubroDetalleRepository(context);
        TiposCambio = new TipoCambioRepository(context);
        ValoresCatalogo = new ValorCatalogoRepository(context);
    }

    public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
}
