using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgCuentaRol")]
public partial class SsgCuentaRol
{
    [Key]
    public int SsgCuentaRolID { get; set; }

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

    public int objCuentaID { get; set; }

    public int objRolID { get; set; }

    [ForeignKey("objCuentaID")]
    [InverseProperty("SsgCuentaRols")]
    public virtual SsgCuentum objCuenta { get; set; } = null!;

    [ForeignKey("objRolID")]
    [InverseProperty("SsgCuentaRols")]
    public virtual SsgRol objRol { get; set; } = null!;
}
