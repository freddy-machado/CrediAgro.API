
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class CarteraRptEntity
    {
        public int SOLICITUDID { get; set; }
        public int CLIENTEID { get; set; }
        public string CLIENTE { get; set; }
        public decimal MONTOCOR { get; set; }
        public decimal MONTOUSD { get; set; }
        public DateTime FECHAENTREGA { get; set; }
        public DateTime FECHAVENCE { get; set; }
        public decimal INTERESCOR { get; set; }
        public decimal INTERESDOL { get; set; }
        public decimal MMTOCOR { get; set; }
        public decimal MMTODOL { get; set; }
        public decimal PRINCIPALCOR { get; set; }
        public decimal PRINCIPALDOL { get; set; }
        public decimal SALDOCOR { get; set; }
        public decimal SALDODOL { get; set; }
        public int FONDOID { get; set; }
        public int RUBROID { get; set; }
        public int COMARCAID { get; set; }
        public decimal SALDOICOR { get; set; }
        public decimal SALDOIDOL { get; set; }
        public decimal SALDOAMCOR { get; set; }
        public decimal SALDOAMDOL { get; set; }
    }
}
