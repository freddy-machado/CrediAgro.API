using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class SsgCuentum
{
    [Key]
    public int nSsgCuentaID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string cLogin { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string cClave { get; set; } = null!;

    public bool nActivo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaExpiracion { get; set; }

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

    public byte? nExpira { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cNombre { get; set; }

    [InverseProperty("objCuenta")]
    public virtual ICollection<SsgCuentaRol> SsgCuentaRols { get; set; } = new List<SsgCuentaRol>();

    [InverseProperty("nSsgCuenta")]
    public virtual ICollection<SsgCuentaSeguridad> SsgCuentaSeguridads { get; set; } = new List<SsgCuentaSeguridad>();
}
