
namespace CrediAgro.Infrastructure.Persistence.CustomTabEntities
{
    public class ClienteTab
    {
        public string fechaNacimiento { get; set; }
        public string cedula { get; set; }
        public string sexo { get; set; }
        public string municipio { get; set; }
        public string direccion { get; set; }
        public string estadoCivil { get; set; }
        public string profesion { get; set; }
        public byte[] foto { get; set; }
    }
}
