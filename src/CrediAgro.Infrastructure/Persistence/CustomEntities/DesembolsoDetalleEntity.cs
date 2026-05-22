
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DesembolsoDetalleEntity
    {
        public int desembolsoID { get; set; }
        public string cliente { get; set; }
        public byte[] foto { get; set; }
        public string fechaDesembolso { get; set; }
        public Decimal montoDesembolso { get; set; }
    }
}
