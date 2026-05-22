
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class TablaPagosEntity
    {
        //campos para generar la tabla
        public int? tablaPagoID { get; set; }
        public int? creditoID { get; set; }
        public string numeroPago { get; set; }
        public string fechaPago { get; set; }
        public Decimal? montoPrincipal { get; set; }
        public Decimal? montoMantenimiento { get; set; }
        public Decimal? montoInteres { get; set; }
        public Decimal? montoTotal { get; set; }
        public Decimal? montoSaldo { get; set; }
        public string estadoCuota { get; set; }

        //otros campos de la tabla
        public Decimal? montoInteresAbonado { get; set; }
        public Decimal? montoPagar { get; set; }
        public Decimal? montoAhorro { get; set; }
        public Decimal? saldoReal { get; set; }
        public Decimal? saldoActualizado { get; set; }
        public Decimal? montoPrincipalAbonado { get; set; }
        public Decimal? montoMantenimientoAbonado { get; set; }
        public Decimal? montoInteresReal { get; set; }
    }
}
