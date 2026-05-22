using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgRol")]
public partial class SsgRol
{
    [Key]
    public int SsgRolID { get; set; }

    [StringLength(50)]
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

    public int objAplicacionID { get; set; }

    [InverseProperty("objRol")]
    public virtual ICollection<SsgCuentaRol> SsgCuentaRols { get; set; } = new List<SsgCuentaRol>();

    [InverseProperty("objRol")]
    public virtual ICollection<SsgRolAccion> SsgRolAccions { get; set; } = new List<SsgRolAccion>();

    [ForeignKey("objAplicacionID")]
    [InverseProperty("SsgRols")]
    public virtual SsgAplicacion objAplicacion { get; set; } = null!;
}
