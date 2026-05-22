
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class EstadoCuentaEntity
    {
        public int NSCRSOLICITUDID { get; set; }
        public int NSTBCLIENTEID { get; set; }
        public string CNOMBRE1 { get; set; }
        public string CNOMBRE2 { get; set; }
        public string CAPELLIDO1 { get; set; }
        public string CAPELLIDO2 { get; set; }
        public Decimal NMONTOAPRUEBAC { get; set; }
        public DateTime DFECHAPAGADO { get; set; }
        public DateTime DFECHAPAGO { get; set; }
        public string RUBRO { get; set; }
        public Decimal NTASAINTERES { get; set; }
        public byte NPLAZO { get; set; }
        public byte NPLAZOMESES { get; set; }
        public byte APAGOSANIOS { get; set; }
        public int N_INDICE { get; set; }
        public DateTime D_FECHA_CORTE { get; set; }
        public int N_PAGO_ID { get; set; }
        public Decimal N_TIPO_CAMBIO { get; set; }
        public Decimal N_MANTENIMIENTO_DEVENGADO_AM { get; set; }
        public Decimal N_MANTENIMIENTO_ABONADO_AM { get; set; }
        public Decimal N_AMORTIZACION_ABONADA { get; set; }
        public Decimal N_DESEMBOLSO_ACTUALIZADO { get; set; }
        public Int16 N_DIAS_ENTRE_FECHA { get; set; }
        public Decimal N_INTERES_DEVENGADO_ACUMULADO { get; set; }
        public Decimal N_INTERES_ABONADO { get; set; }
        public Decimal N_SALDO_TOTAL { get; set; }
        public Decimal N_MONTO_PAGO { get; set; }
    }
}
