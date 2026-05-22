
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DatosPrestamoConPagosRealizadosEntity
    {
        public int SOICITUDID { get; set; }
        public string RUBRO { get; set; }
        public DateTime FECHAINICIA { get; set; }
        public DateTime FECHAFIN { get; set; }
        public Decimal INTERES { get; set; }
        public byte NOPAGOS { get; set; }
        public byte PLAZO { get; set; }
        public Decimal MONTOAPROBADO { get; set; }
        public Decimal MONTOPAGADO { get; set; }
    }
}
