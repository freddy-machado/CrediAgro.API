using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrExoneracion")]
public partial class ScrExoneracion
{
    [Key]
    public int nScrExoneracionID { get; set; }

    public int nScrSolicitudID { get; set; }

    public int? nScrPagoCuotaID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaRegistroExonera { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cTipoExhonera { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cAplicaExhonera { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? nPorcentaje { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? nBaseMontoExhonera { get; set; }

    [Column(TypeName = "numeric(24, 9)")]
    public decimal? nMontoExhonera { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cMotivoExoneracion { get; set; }

    public byte? nEstadoExoneracion { get; set; }

    [ForeignKey("nScrSolicitudID")]
    [InverseProperty("ScrExoneracions")]
    public virtual ScrCredito nScrSolicitud { get; set; } = null!;
}
