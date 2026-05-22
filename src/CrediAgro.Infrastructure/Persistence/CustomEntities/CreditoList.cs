
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class CreditoList
    {
        public int creditoID { get; set; }
        public string numeroSolicitud { get; set; }
        public string cliente { get; set; }
        public string fechaSolicitud { get; set; }
        public string rubro { get; set; }
        public decimal montoSolicitado { get; set; }
        public decimal montoAprobado { get; set; }
        public string estadoSolicitud { get; set; }
        public string moneda { get; set; }
        public int clienteId { get; set; }
    }
}
