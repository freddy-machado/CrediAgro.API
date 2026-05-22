
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class TipoCambioExcel
    {
        public int nStbMonedaBaseID { get; set; }
        public int nStbMonedaCambioID { get; set; }
        public DateTime dFechaTCambio { get; set; }
        public Decimal nMontoTCambio { get; set; }
        public int nActivo { get; set; }
        public int nOcupado { get; set; }
        public string cUsuarioCreacion { get; set; }
        public DateTime dFechaCreacion { get; set; }
    }
}
