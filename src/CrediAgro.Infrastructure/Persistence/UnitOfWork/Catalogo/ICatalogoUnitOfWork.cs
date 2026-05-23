using CrediAgro.Infrastructure.Persistence.Repositories.Catalogo;

namespace CrediAgro.Infrastructure.Persistence.UnitOfWork.Catalogo;

public interface ICatalogoUnitOfWork
{
    ICatalogoRepository Catalogos { get; }
    IClienteRepository Clientes { get; }
    IComarcaRepository Comarcas { get; }
    IDepartamentoRepository Departamentos { get; }
    IEmpresaRepository Empresas { get; }
    IFiadorRepository Fiadores { get; }
    IFrecuenciaPagoRepository FrecuenciaPagos { get; }
    IMonedaRepository Monedas { get; }
    IMunicipioRepository Municipios { get; }
    IPersonaRepository Personas { get; }
    IRubroRepository Rubros { get; }
    IRubroDetalleRepository RubroDetalles { get; }
    ITipoCambioRepository TiposCambio { get; }
    IValorCatalogoRepository ValoresCatalogo { get; }

    Task<int> SaveChangesAsync();
}
