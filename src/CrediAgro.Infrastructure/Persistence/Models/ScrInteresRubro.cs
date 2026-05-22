using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrInteresRubro")]
public partial class ScrInteresRubro
{
    [Key]
    public int nScrInteresRubroID { get; set; }

    public int nStbInteresID { get; set; }

    public int nStbRubroID { get; set; }

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

    [ForeignKey("nStbInteresID")]
    [InverseProperty("ScrInteresRubros")]
    public virtual StbValorCatalogo nStbInteres { get; set; } = null!;

    [ForeignKey("nStbRubroID")]
    [InverseProperty("ScrInteresRubros")]
    public virtual StbRubro nStbRubro { get; set; } = null!;
}
