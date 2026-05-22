
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class ReciboClassEntity
    {
        public int CUOTAID { get; set; }
        public string NORECIBO { get; set; }
        public string CLIENTE { get; set; }
        public Decimal MONTOPAGADO { get; set; }
        public string MONEDA { get; set; }
        public string CONCEPTO { get; set; }
        public Decimal TIPOCAMBIO { get; set; }
        public Decimal PRINCIPAL { get; set; }
        public Decimal MANTENIMIENTO { get; set; }
        public Decimal INTERES { get; set; }
        public DateTime FECHAPAGO { get; set; }
        public string NOPRESTAMO { get; set; }
        public string RUBRO { get; set; }
        public Decimal SALDO { get; set; }
        public string MONTOLETRAS { get; set; }
        public string FONDO { get; set; }
    }
}
