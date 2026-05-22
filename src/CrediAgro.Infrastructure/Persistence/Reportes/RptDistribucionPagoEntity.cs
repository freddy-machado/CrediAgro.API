
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class RptDistribucionPagoEntity
    {
        public int N_SOLICITUD_ID { get; set; }
        public string CLIENTE { get; set; }
        public Decimal N_MONTO_APRUEBA { get; set; }
        public string DESLIZAMIENTO { get; set; }
        public DateTime DFECHAPAGADO { get; set; }
        public Byte NPLAZOMESES { get; set; }
        public Decimal NTASAINTERES { get; set; }
        public DateTime VENCE { get; set; }
        public Byte FRECUENCIA { get; set; }
        public Byte NUMPAGOS { get; set; }
        public Decimal NMONTOTCAMBIO { get; set; }
        public string RUBRO { get; set; }
        public int N_INDICE { get; set; }
        public DateTime D_FECHA_CORTE { get; set; }
        public Decimal N_TIPO_CAMBIO { get; set; }
        public Int16 N_DIAS_ENTRE_FECHA { get; set; }
        public Decimal N_SALDO_TOTAL { get; set; }
        public Decimal N_DESEMBOLSO_ACTUALIZADO { get; set; }
        public Decimal N_SALDO_AMORTIZACION { get; set; }
        public Decimal N_MANTENIMIENTO_DEVENGADO_AM { get; set; }
        public Decimal N_MANTENIMIENTO_DEVENGADO_ACUMULADO_AM { get; set; }
        public Decimal N_MANTENIMIENTO_ABONADO_AM { get; set; }
        public Decimal N_MANTENIMIENTO_ABONADO_ACUMULADO_AM { get; set; }
        public Decimal N_MANTENIMIENTO_PENDIENTE_AM { get; set; }
        public Decimal N_MANTENIMIENTO_PENDIENTE_ACUMULADO_AM { get; set; }
        public Decimal N_AMORTIZACION_DEVENGADA { get; set; }
        public Decimal N_AMORTIZACION_DEVEGADA_ACUMULADA { get; set; }
        public Decimal N_AMORTIZACION_ABONADA { get; set; }
        public Decimal N_AMORTIZACION_ABONADA_ACUMULADA { get; set; }
        public Decimal N_AMORTIZACION_PENDIENTE { get; set; }
        public Decimal N_AMORTIZACION_PENDIENTE_ACUMULADO { get; set; }
        public Decimal N_INTERES_DEVENGADO { get; set; }
        public Decimal N_INTERES_DEVENGADO_ACUMULADO { get; set; }
        public Decimal N_INTERES_ABONADO { get; set; }
        public Decimal N_INTERES_ABONADO_ACUMULADO { get; set; }
        public Decimal N_INTERES_PENDIENTE { get; set; }
        public Decimal N_INTERES_PENDIENTE_ACUMULADO { get; set; }
    }
}
