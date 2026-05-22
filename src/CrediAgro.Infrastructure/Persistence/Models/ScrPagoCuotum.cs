using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class ScrPagoCuotum
{
    [Key]
    public int nScrPagoCuotaID { get; set; }

    public int nScrSolicitudID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaPago { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? cNumeroDocumento { get; set; }

    public int nStbParidadCambiariaID { get; set; }

    public int nStbMonedaID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoPago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cConceptoPago { get; set; }

    public byte nActivo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cMotivoAnulacion { get; set; }

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

    [InverseProperty("nScrPagoCuota")]
    public virtual ICollection<ScrPagoCuotaDetalle> ScrPagoCuotaDetalles { get; set; } = new List<ScrPagoCuotaDetalle>();

    [ForeignKey("nStbMonedaID")]
    [InverseProperty("ScrPagoCuota")]
    public virtual StbMonedum nStbMoneda { get; set; } = null!;

    [ForeignKey("nStbParidadCambiariaID")]
    [InverseProperty("ScrPagoCuota")]
    public virtual StbParidadCambiarium nStbParidadCambiaria { get; set; } = null!;
}
