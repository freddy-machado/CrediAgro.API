using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
[Table("StbLog")]
public partial class StbLog
{
    public int IdStbLog { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Thread { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Level { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Logger { get; set; } = null!;

    [StringLength(4000)]
    [Unicode(false)]
    public string Message { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? Exception { get; set; }

    [StringLength(80)]
    public string? user { get; set; }

    [StringLength(80)]
    public string? IP { get; set; }

    [StringLength(80)]
    public string? HOSTNAME { get; set; }

    [StringLength(100)]
    public string? MACADDRESS { get; set; }
}
