using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrDesembolso")]
public partial class ScrDesembolso
{
    [Key]
    public int nScrDesembolsoID { get; set; }

    public int nScrSolicitudID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaDesembolso { get; set; }

    public int nStbMonedaID { get; set; }

    public int nStbParidadCambiariaID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoDesembolso { get; set; }

    public double? nPorcentajeComision { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoComsion { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoTotal { get; set; }

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

    public int? nStbEstadoDesembolsoID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaPagado { get; set; }

    [InverseProperty("nScrDesembolso")]
    public virtual ICollection<ScrDesembolsoPago> ScrDesembolsoPagos { get; set; } = new List<ScrDesembolsoPago>();

    [ForeignKey("nScrSolicitudID")]
    [InverseProperty("ScrDesembolsos")]
    public virtual ScrCredito nScrSolicitud { get; set; } = null!;

    [ForeignKey("nStbMonedaID")]
    [InverseProperty("ScrDesembolsos")]
    public virtual StbMonedum nStbMoneda { get; set; } = null!;

    [ForeignKey("nStbParidadCambiariaID")]
    [InverseProperty("ScrDesembolsos")]
    public virtual StbParidadCambiarium nStbParidadCambiaria { get; set; } = null!;
}
