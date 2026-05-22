
namespace CrediAgro.Infrastructure.Persistence.Seguridad
{
    public class AccionServicioUsuarioEntity
    {
        public int accionId { get; set; }
        public int servicioUsuarioId { get; set; }
        public string accion { get; set; }
        public string servicioUsuario { get; set; }
        public bool activo { get; set; }
    }
}
