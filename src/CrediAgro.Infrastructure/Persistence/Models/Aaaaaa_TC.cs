using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
[Table("Aaaaaa_TC")]
public partial class Aaaaaa_TC
{
    public double? nStbParidadCambiariaID { get; set; }

    public double? nStbMonedaBaseID { get; set; }

    public double? nStbMonedaCambioID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaTCambio { get; set; }

    public double? nMontoTCambio { get; set; }

    public double? nActivo { get; set; }

    public double? nOcupado { get; set; }

    [StringLength(255)]
    public string? cUsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaCreacion { get; set; }

    [StringLength(255)]
    public string? cUsuarioModificacion { get; set; }

    [StringLength(255)]
    public string? dFechaModificacion { get; set; }
}
