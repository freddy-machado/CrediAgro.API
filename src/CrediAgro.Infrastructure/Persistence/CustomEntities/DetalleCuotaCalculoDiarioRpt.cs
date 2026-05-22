
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DetalleCuotaCalculoDiarioRpt
    {
        public int nScrSolicitudID { get; set; }
        public string cliente { get; set; }
        public Decimal nTasaInteres { get; set; }
        public Decimal nComision { get; set; }
        public Int16 frecuencia { get; set; }
        public Int16 nPlazoMeses { get; set; }
        public Int16 nPagosAnios { get; set; }
        public Int16 NumPagos { get; set; }
        public string moneda { get; set; }
        public Decimal nMontoApruebaC { get; set; }
        public DateTime dFechaPagado { get; set; }
        public string estado { get; set; }
        public decimal nMontoTCambio { get; set; }
        public string rubro { get; set; }
        public string proceso { get; set; }
        public DateTime dFecha { get; set; }
        public decimal nTipoCambio { get; set; }
        public decimal nMontoEntregado { get; set; }
        public decimal nMmtoValor { get; set; }
        public decimal nAmortizacionPrincipal { get; set; }
        public decimal nMontoAcumuladoAntes { get; set; }
        public decimal nMontoAcumulado { get; set; }
        public DateTime dFechaDesde { get; set; }
        public DateTime dFechaHasta { get; set; }
        public Int16 nDias { get; set; }
        public decimal nInteresCorriente { get; set; }
        public decimal nMoratorios { get; set; }
        public decimal nMmtoInteres { get; set; }
        public decimal nAmortizacionInteres { get; set; }
        public decimal nInteresAcumulado { get; set; }
        public decimal nSaldoTotal { get; set; }
        public string nFuenteSaldos { get; set; }
        public Int16 nEstado { get; set; }
        public int nScrPagoCuotaID { get; set; }
    }
}
