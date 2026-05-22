
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DesembolsoEntity
    {
        public int desembolsoID { get; set; }
        public int solicitudID { get; set; }
        public string cliente { get; set; }
        public string fechaDesembolso { get; set; }
        public string moneda { get; set; }
        public Decimal? montoDesembolso { get; set; }
        public Decimal? montoComision { get; set; }
        public Decimal? montoTotal { get; set; }
        public string estado { get; set; }
        public int clienteId { get; set; }
    }
}
