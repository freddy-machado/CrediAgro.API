using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
[Table("tc-junio")]
public partial class tc_junio
{
    public double? nStbMonedaBaseID { get; set; }

    public double? nStbMonedaCambioID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaTCambio { get; set; }

    public double? nMontoTCambio { get; set; }

    public double? nActivo { get; set; }

    public double? nOcupado { get; set; }

    [StringLength(255)]
    public string? cUsuarioCreacion { get; set; }

    public double? dFechaCreacion { get; set; }

    [StringLength(255)]
    public string? fm { get; set; }

    [StringLength(255)]
    public string? um { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fecha { get; set; }
}
