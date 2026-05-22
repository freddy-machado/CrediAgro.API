using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
public partial class vwRubro
{
    public int nStbRubroID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string rubro { get; set; } = null!;

    public int nStbRubroDetalleID { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? nTasaInteres { get; set; }

    public int nStbFrecuenciaPagoID { get; set; }

    public byte plazoMeses { get; set; }

    public byte noPagos { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? frecuenciaPagos { get; set; }

    public byte? nEstado { get; set; }
}
