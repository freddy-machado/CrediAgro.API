
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class ResumenEgresosRptEntity
    {
        public int SOLICITUDID { get; set; }
        public int CLIENTEID { get; set; }
        public int DESEMBOLSOID { get; set; }
        public string CLIENTE { get; set; }
        public Decimal MONTOCOR { get; set; }
        public Decimal MONTOUSD { get; set; }
        public string RUBRO { get; set; }
        public Decimal TIPOCAMBIO { get; set; }
    }
}
