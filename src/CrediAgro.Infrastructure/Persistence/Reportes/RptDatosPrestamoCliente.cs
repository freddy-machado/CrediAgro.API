
namespace CrediAgro.Infrastructure.Persistence.Reportes
{
    public class RptDatosPrestamoCliente
    {
        public int N_SOLICITUD_ID { get; set; }
        public string cliente { get; set; }
        public Decimal nMontoApruebaC { get; set; }
        public string deslizamiento { get; set; }
        public DateTime dFechaPagado { get; set; }
        public Byte nPlazoMeses { get; set; }
        public Decimal nTasaInteres { get; set; }
        public DateTime vence { get; set; }
        public Byte frecuencia { get; set; }
        public Byte NumPagos { get; set; }
        public Decimal nMontoTCambio { get; set; }
        public string rubro { get; set; }
    }
}
