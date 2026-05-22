using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgAplicacion")]
public partial class SsgAplicacion
{
    [Key]
    public int SsgAplicacionID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CodInterno { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [InverseProperty("objAplicacion")]
    public virtual ICollection<SsgModulo> SsgModulos { get; set; } = new List<SsgModulo>();

    [InverseProperty("objAplicacion")]
    public virtual ICollection<SsgRol> SsgRols { get; set; } = new List<SsgRol>();
}
