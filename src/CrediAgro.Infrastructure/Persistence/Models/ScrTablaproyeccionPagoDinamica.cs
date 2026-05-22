using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrTablaproyeccionPagoDinamica")]
public partial class ScrTablaproyeccionPagoDinamica
{
    [Key]
    public int nScrTablaproyeccionPagoDinamicaID { get; set; }

    public int nScrSolicitudID { get; set; }

    public byte nNumeroCuota { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaPago { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoPrincipalAbonado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoMantenimientoPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoMantenimientoAbonadoPrincipal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoInteres { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoInteresAbonado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoMora { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoMoraAbonado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoMantenimientoInteres { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMontoMantenimientoInteresAbonado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoTotal { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoPagado { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoSaldo { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cEstadoPago { get; set; }

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

    [InverseProperty("nScrTablaproyeccionPago")]
    public virtual ICollection<ScrPagoCuotaDetalle> ScrPagoCuotaDetalles { get; set; } = new List<ScrPagoCuotaDetalle>();

    [ForeignKey("nScrSolicitudID")]
    [InverseProperty("ScrTablaproyeccionPagoDinamicas")]
    public virtual ScrCredito nScrSolicitud { get; set; } = null!;
}
