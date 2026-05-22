using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrPagoCuotaDetalle")]
public partial class ScrPagoCuotaDetalle
{
    [Key]
    public int nScrPagoCuotaDetalleID { get; set; }

    public int nScrPagoCuotaID { get; set; }

    public byte nNumeroCuota { get; set; }

    public int? nScrTablaproyeccionPagoID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaPagoProgramado { get; set; }

    public short nDiasVencidos { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoMantenimientoPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoInteres { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoMantenimientoInteres { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoMoraPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoMoraTotal { get; set; }

    [ForeignKey("nScrPagoCuotaID")]
    [InverseProperty("ScrPagoCuotaDetalles")]
    public virtual ScrPagoCuotum nScrPagoCuota { get; set; } = null!;

    [ForeignKey("nScrTablaproyeccionPagoID")]
    [InverseProperty("ScrPagoCuotaDetalles")]
    public virtual ScrTablaproyeccionPagoDinamica? nScrTablaproyeccionPago { get; set; }
}
