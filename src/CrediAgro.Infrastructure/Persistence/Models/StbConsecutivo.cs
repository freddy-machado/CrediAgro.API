using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
public partial class StbConsecutivo
{
    [StringLength(30)]
    [Unicode(false)]
    public string? cStbTabla { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cNomenclatura { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? nNoDocumento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }
}
