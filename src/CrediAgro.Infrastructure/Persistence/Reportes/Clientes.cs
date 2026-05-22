
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class Clientes
    {
        public int nStbClienteID { get; set; }
        public string cCodigoCliente { get; set; }
        public int nStbPersonaID { get; set; }
        public string nombresApellidos { get; set; }
        public string sexo { get; set; }
        public string cDireccion { get; set; }
        public bool nTrabaja { get; set; }
        public string cLugarTrabajo { get; set; }
        public string cDireccionTrabajo { get; set; }
        public string puesto { get; set; }
        public decimal nSueldoMensual { get; set; }
        public string cObservaciones { get; set; }
        public string prestamoActivo { get; set; }
        public DateTime dFechaDesdeDireccion { get; set; }
        public DateTime dFechaHastaDireccion { get; set; }
        public DateTime dFechaNacApertura { get; set; }
        public string cTelefono1 { get; set; }
        public string cCelular1 { get; set; }
        public string cNumeroCedula { get; set; }
        public string cSiglas { get; set; }
        public string cNumeroRUC { get; set; }
        public string cEMail { get; set; }
        public byte[] bFoto { get; set; }
        public int edad { get; set; }
        public string estadoCivil { get; set; }
        public string escolaridad { get; set; }
        public string profesion { get; set; }
        public string tipoVivienda { get; set; }
        public string municipio { get; set; }
        public string periodoDireccion { get; set; }
    }
}
