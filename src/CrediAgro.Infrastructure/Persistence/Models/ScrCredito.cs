using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrCredito")]
public partial class ScrCredito
{
    [Key]
    public int nScrSolicitudID { get; set; }

    public int nStbClienteID { get; set; }

    public int nStbMonedaID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? nNumeroSolicitud { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaSolicitud { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaAprobacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaLiquidacion { get; set; }

    public int nStbParidadCambiariaID { get; set; }

    public int nStbRubroDetalleID { get; set; }

    public int? nStbNegocioClienteID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoSolicitaC { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoSolicitaU { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoApruebaC { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoApruebaU { get; set; }

    public int nStbEstadoSolicitudID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }

    public int? nStbFondoId { get; set; }

    [InverseProperty("nScrSolicitud")]
    public virtual ICollection<ScrDesembolso> ScrDesembolsos { get; set; } = new List<ScrDesembolso>();

    [InverseProperty("nScrSolicitud")]
    public virtual ICollection<ScrDocumentoSolicitud> ScrDocumentoSolicituds { get; set; } = new List<ScrDocumentoSolicitud>();

    [InverseProperty("nScrSolicitud")]
    public virtual ICollection<ScrExoneracion> ScrExoneracions { get; set; } = new List<ScrExoneracion>();

    [InverseProperty("nScrSolicitud")]
    public virtual ICollection<ScrTablaproyeccionPagoDinamica> ScrTablaproyeccionPagoDinamicas { get; set; } = new List<ScrTablaproyeccionPagoDinamica>();

    [InverseProperty("nScrSolicitud")]
    public virtual ICollection<ScrTablaproyeccionPago> ScrTablaproyeccionPagos { get; set; } = new List<ScrTablaproyeccionPago>();

    [InverseProperty("nStbSolicitud")]
    public virtual ICollection<StbFiador> StbFiadors { get; set; } = new List<StbFiador>();

    [ForeignKey("nStbClienteID")]
    [InverseProperty("ScrCreditos")]
    public virtual StbCliente nStbCliente { get; set; } = null!;

    [ForeignKey("nStbEstadoSolicitudID")]
    [InverseProperty("ScrCreditos")]
    public virtual StbValorCatalogo nStbEstadoSolicitud { get; set; } = null!;

    [ForeignKey("nStbParidadCambiariaID")]
    [InverseProperty("ScrCreditos")]
    public virtual StbParidadCambiarium nStbParidadCambiaria { get; set; } = null!;

    [ForeignKey("nStbRubroDetalleID")]
    [InverseProperty("ScrCreditos")]
    public virtual StbRubroDetalle nStbRubroDetalle { get; set; } = null!;
}
