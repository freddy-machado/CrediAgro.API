
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class EstadosCreditoEntity
    {
        public int nEstadoProcesoCredito { get; set; }
        public int nEstadoAutorizadaCredito { get; set; }
        public int nEstadoAutorizadaAdmonCredito { get; set; }
        public int nEstadoRechazadaCredito { get; set; }
        public int nEstadoAnuladaProcesoCredito { get; set; }
        public int nEstadoAnuladaCursoPagoCredito { get; set; }
        public int nEstadoDesembolsoHechoCredito { get; set; }

        public string cEstadoProcesoCredito { get; set; }
        public string cEstadoAutorizadaCredito { get; set; }
        public string cEstadoAutorizadaAdmonCredito { get; set; }
        public string cEstadoRechazadaCredito { get; set; }
        public string cEstadoAnuladaProcesoCredito { get; set; }
        public string cEstadoAnuladaCursoPagoCredito { get; set; }
        public string cEstadoDesembolsoHechoCredito { get; set; }
    }
}
