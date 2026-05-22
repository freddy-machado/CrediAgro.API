
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RubroDetalleList
    {
        public int detalleId { get; set; }
        public int rubroId { get; set; }
        public string rubro { get; set; }
        public string frecuenciaPago { get; set; }
        public Decimal tasaInteres { get; set; } // rubro detalle
        public int plazo { get; set; } // rubro detalle
        public int numeroPagos { get; set; }
        public bool estado { get; set; }
    }
}
