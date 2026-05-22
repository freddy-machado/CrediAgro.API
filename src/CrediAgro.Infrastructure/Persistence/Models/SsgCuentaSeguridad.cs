using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgCuentaSeguridad")]
public partial class SsgCuentaSeguridad
{
    [Key]
    public int nSsgCuentaSeguridadID { get; set; }

    public int nSsgCuentaID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [ForeignKey("nSsgCuentaID")]
    [InverseProperty("SsgCuentaSeguridads")]
    public virtual SsgCuentum nSsgCuenta { get; set; } = null!;
}
