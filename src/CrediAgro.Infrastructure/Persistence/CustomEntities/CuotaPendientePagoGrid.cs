
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class CuotaPendientePagoGrid
    {
        public int N_CUOTA { get; set; }
        public int N_AMORTIZACION_ID { get; set; }
        public DateTime D_FECHA_PAGO { get; set; }
        public int N_DIAS_VENCIDOS { get; set; }
        public Decimal N_SALDO_AMORTIZACION { get; set; }
        public Decimal N_ABONO_AMORTIZACION { get; set; }
        public Decimal N_SALDO_MANTENIMIENTO { get; set; }
        public Decimal N_ABONO_MANTENIMIENTO { get; set; }
        public Decimal N_SALDO_INTERES { get; set; }
        public Decimal N_ABONO_INTERES { get; set; }
        public Decimal N_MORA { get; set; }
        public Decimal N_ABONO_MORA { get; set; }
        public Decimal N_MONTO_PAGO { get; set; }
        public Decimal N_MONTO_EXHONERA_MR { get; set; }
        public string C_ESTATUS { get; set; }
    }
}
