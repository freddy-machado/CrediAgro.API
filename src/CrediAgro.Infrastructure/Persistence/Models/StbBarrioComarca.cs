using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbBarrioComarca")]
public partial class StbBarrioComarca
{
    [Key]
    public int nStbComarcaID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cCodigoComarca { get; set; }

    public int nStbMunicipio { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string cNombreComarca { get; set; } = null!;

    public byte nActivo { get; set; }

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
}
