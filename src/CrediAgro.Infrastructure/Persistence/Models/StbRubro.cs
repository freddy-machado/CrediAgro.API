using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbRubro")]
public partial class StbRubro
{
    [Key]
    public int nStbRubroID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string cDescripcion { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? cDescripcionCorta { get; set; }

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

    [InverseProperty("nStbRubro")]
    public virtual ICollection<ScrFrecuenciaPagoRubro> ScrFrecuenciaPagoRubros { get; set; } = new List<ScrFrecuenciaPagoRubro>();

    [InverseProperty("nStbRubro")]
    public virtual ICollection<ScrInteresRubro> ScrInteresRubros { get; set; } = new List<ScrInteresRubro>();

    [InverseProperty("nStbRubro")]
    public virtual ICollection<ScrPlazoPagoRubro> ScrPlazoPagoRubros { get; set; } = new List<ScrPlazoPagoRubro>();

    [InverseProperty("nStbRubro")]
    public virtual ICollection<StbRubroDetalle> StbRubroDetalles { get; set; } = new List<StbRubroDetalle>();
}
