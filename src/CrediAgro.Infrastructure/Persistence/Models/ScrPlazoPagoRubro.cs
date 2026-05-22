using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrPlazoPagoRubro")]
public partial class ScrPlazoPagoRubro
{
    [Key]
    public int nScrPlazoPagoRubroID { get; set; }

    public int nStbRubroID { get; set; }

    public int nStbPlazoPago { get; set; }

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

    [ForeignKey("nStbPlazoPago")]
    [InverseProperty("ScrPlazoPagoRubros")]
    public virtual StbValorCatalogo nStbPlazoPagoNavigation { get; set; } = null!;

    [ForeignKey("nStbRubroID")]
    [InverseProperty("ScrPlazoPagoRubros")]
    public virtual StbRubro nStbRubro { get; set; } = null!;
}
