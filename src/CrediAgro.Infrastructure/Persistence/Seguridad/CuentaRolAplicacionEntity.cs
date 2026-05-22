
namespace CrediAgro.Infrastructure.Persistence.Seguridad
{
    public class CuentaRolAplicacionEntity
    {
        public int cuentaId_ { get; set; }
        public int rolId_ { get; set; }
        public string rol_ { get; set; }
        public string cuenta_ { get; set; }
        public string aplicacion_ { get; set; }
        public bool activa { get; set; }
    }
}
