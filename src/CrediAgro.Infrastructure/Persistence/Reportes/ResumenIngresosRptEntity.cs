
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class ResumenIngresosRptEntity
    {
        public DateTime FECHAPAGO { get; set; }
        public string NORECIBO { get; set; }
        public string RUBRO { get; set; }
        public Decimal TIPOCAMBIO { get; set; }
        public int SOLICITUDID { get; set; }
        public int CLIENTEID { get; set; }
        public string CLIENTE { get; set; }
        public Decimal PRINCIPALCOR { get; set; }
        public Decimal MMTOCOR { get; set; }
        public Decimal INTERESCOR { get; set; }
        public Decimal TOTALCOR { get; set; }
        public Decimal PRINCIPALDOL { get; set; }
        public Decimal MMTODOL { get; set; }
        public Decimal INTERESDOL { get; set; }
        public Decimal TOTALDOL { get; set; }
        public int FONDOID { get; set; }
        public int RUBROID { get; set; }
        public int COMARCAID { get; set; }
    }
}
