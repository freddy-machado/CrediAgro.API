
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class TablaProyeccionRptEntity
    {
        public int nScrTablaproyeccionPagoID { get; set; }
        public int nScrSolicitudID { get; set; }
        public byte nNumeroCuota { get; set; }
        public DateTime dFechaPago { get; set; }
        public Decimal nMontoPrincipal { get; set; }
        public Decimal nMontoPrincipalAbonado { get; set; }
        public Decimal nMontoMantenimientoPrincipal { get; set; }
        public Decimal nMontoMantenimientoAbonadoPrincipal { get; set; }
        public Decimal nMontoInteres { get; set; }
        public Decimal nMontoInteresAbonado { get; set; }
        public Decimal nMontoMora { get; set; }
        public Decimal nMontoMoraAbonado { get; set; }
        public Decimal nMontoMantenimientoInteres { get; set; }
        public Decimal nMontoMantenimientoInteresAbonado { get; set; }
        public Decimal nMontoTotal { get; set; }
        public Decimal nMontoPagado { get; set; }
        public Decimal nMontoSaldo { get; set; }
    }
}
