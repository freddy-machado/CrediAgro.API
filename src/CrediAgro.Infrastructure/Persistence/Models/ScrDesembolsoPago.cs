using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrDesembolsoPago")]
public partial class ScrDesembolsoPago
{
    [Key]
    public int nScrDesembolsoPagoID { get; set; }

    public int nScrDesembolsoID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaPago { get; set; }

    public int nStbFormaPagoID { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal nMontoPago { get; set; }

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

    public byte? nEstado { get; set; }

    [ForeignKey("nScrDesembolsoID")]
    [InverseProperty("ScrDesembolsoPagos")]
    public virtual ScrDesembolso nScrDesembolso { get; set; } = null!;

    [ForeignKey("nStbFormaPagoID")]
    [InverseProperty("ScrDesembolsoPagos")]
    public virtual StbValorCatalogo nStbFormaPago { get; set; } = null!;
}
