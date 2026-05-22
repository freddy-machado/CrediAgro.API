
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class EmpresaDatos
    {
        public int nStbEmpresaID { get; set; }
        public string cNombreEmpresa { get; set; }
        public string cNombreCortoEmpresa { get; set; }
        public string cRazonSocialEmpresa { get; set; }
        public string cDireccionEmpresa { get; set; }
        public string cNumeroRUCEmpresa { get; set; }
        public string cNumeroPatronalEmpresa { get; set; }
        public byte[] bLogoEmpresa { get; set; }
    }
}
