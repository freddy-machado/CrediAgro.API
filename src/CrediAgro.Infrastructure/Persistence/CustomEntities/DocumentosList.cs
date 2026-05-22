
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DocumentosList
    {
        public int documentoID { get; set; }
        public string tipoDocumento { get; set; }
        public string nombreDocumento { get; set; }
        public byte[] foto { get; set; }
    }
}
