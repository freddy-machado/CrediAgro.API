using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
public partial class vwEmpresa
{
    [StringLength(150)]
    [Unicode(false)]
    public string cNombreInstitucion { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string cNombreCorto { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string cDireccion { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? bLogo { get; set; }
}
