using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class StbFrecuenciaPago
{
    [Key]
    public int nStbFrecuenciaPagoID { get; set; }

    public byte nPlazoMeses { get; set; }

    public byte nPagosAnios { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cDescripcion { get; set; }

    [InverseProperty("nStbFrecuenciaPago")]
    public virtual ICollection<StbRubroDetalle> StbRubroDetalles { get; set; } = new List<StbRubroDetalle>();
}
