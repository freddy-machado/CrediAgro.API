
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class TipoCambioList
    {
        public int id { get; set; }
        public string anio { get; set; }
        public string mes { get; set; }
        public DateTime fecha { get; set; }
        public Decimal monto { get; set; }
    }
}
