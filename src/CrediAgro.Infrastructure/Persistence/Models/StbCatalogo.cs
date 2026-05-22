using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbCatalogo")]
public partial class StbCatalogo
{
    [Key]
    public int nStbCatalogoID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cNombre { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string cDescripcion { get; set; } = null!;

    public bool nActivo { get; set; }

    public bool nReservado { get; set; }

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

    [InverseProperty("nStbCatalogo")]
    public virtual ICollection<StbValorCatalogo> StbValorCatalogos { get; set; } = new List<StbValorCatalogo>();
}
