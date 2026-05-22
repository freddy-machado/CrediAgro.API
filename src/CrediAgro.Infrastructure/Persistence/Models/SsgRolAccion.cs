using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgRolAccion")]
public partial class SsgRolAccion
{
    [Key]
    public int SsgRolAccionID { get; set; }

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

    public int objAccionID { get; set; }

    public int objRolID { get; set; }

    [ForeignKey("objRolID")]
    [InverseProperty("SsgRolAccions")]
    public virtual SsgRol objRol { get; set; } = null!;
}
