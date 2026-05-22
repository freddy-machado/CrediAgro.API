using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class SsgOperacionAuditorium
{
    [Key]
    public int nSsgOperacionAuditoriaID { get; set; }

    [StringLength(60)]
    public string sNombreOperacion { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string sUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? sUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }
}
