
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RubroDetalleEntity
    {
        public int rubroID { get; set; }
        public int rubroDetalleID { get; set; }
        public string rubro { get; set; }
        public Decimal comisionPor { get; set; }
        public int plazoMeses { get; set; }
        public int numPagos { get; set; }
        public string frecuenciaPago { get; set; }
    }
}
