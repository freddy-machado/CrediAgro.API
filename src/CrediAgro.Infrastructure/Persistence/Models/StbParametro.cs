using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbParametro")]
public partial class StbParametro
{
    [Key]
    public int nStbParametroId { get; set; }

    public int nStbEmpresaID { get; set; }

    [Column(TypeName = "numeric(3, 0)")]
    public decimal nCodigoParametro { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string cValorParametro { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? cDescripcion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }
}
