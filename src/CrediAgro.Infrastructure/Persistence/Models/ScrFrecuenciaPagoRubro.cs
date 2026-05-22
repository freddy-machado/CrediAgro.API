using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrFrecuenciaPagoRubro")]
public partial class ScrFrecuenciaPagoRubro
{
    [Key]
    public int nScrFrecuenciaPagoRubroID { get; set; }

    public int nStbRubroID { get; set; }

    public int nStbFrecuenciaPago { get; set; }

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

    [ForeignKey("nStbFrecuenciaPago")]
    [InverseProperty("ScrFrecuenciaPagoRubros")]
    public virtual StbValorCatalogo nStbFrecuenciaPagoNavigation { get; set; } = null!;

    [ForeignKey("nStbRubroID")]
    [InverseProperty("ScrFrecuenciaPagoRubros")]
    public virtual StbRubro nStbRubro { get; set; } = null!;
}
