using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbEmpresa")]
public partial class StbEmpresa
{
    [Key]
    public int nStbEmpresaID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string cNombreInstitucion { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string cNombreCorto { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string cRazonSocial { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string cDireccion { get; set; } = null!;

    [StringLength(100)]
    public string cNumeroRUC { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? cNumeroPatronal { get; set; }

    [Column(TypeName = "image")]
    public byte[]? bLogo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificaion { get; set; }
}
