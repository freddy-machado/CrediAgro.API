using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
[Table("StbErrorresLog")]
public partial class StbErrorresLog
{
    [StringLength(100)]
    [Unicode(false)]
    public string? OBJETO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORNUMBER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORSEVERITY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORSTATES { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORPROCC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORLINE { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ERRORMESSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FECHA { get; set; }
}
