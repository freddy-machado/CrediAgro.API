
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class PagoCuotaEntity
    {
        public int PAGOID { get; set; }
        public int SOLICITUDID { get; set; }
        public DateTime FECHAPAGO { get; set; }
        public string NUMERODOCUMENTO { get; set; }
        public int TABLAPAGOID { get; set; }
        public byte NUMEROCUOTA { get; set; }
        public Decimal PRINCIPAL { get; set; }
        public Decimal INTERES { get; set; }
        public Decimal MORA { get; set; }
        public Decimal MANTENIMIENTO { get; set; }
        public Decimal TOTAL { get; set; }
    }
}
