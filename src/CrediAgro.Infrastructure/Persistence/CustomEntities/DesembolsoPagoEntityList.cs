
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DesembolsoPagoEntityList
    {
        public int desembolsoPagoID { get; set; }
        public int desembolsoID { get; set; }
        public string fecha { get; set; }
        public Decimal monto { get; set; }
        public string tipoPago { get; set; }
        public int tipoPagoID { get; set; }
    }
}
