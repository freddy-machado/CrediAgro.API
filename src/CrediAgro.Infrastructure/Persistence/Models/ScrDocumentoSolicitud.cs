using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrDocumentoSolicitud")]
public partial class ScrDocumentoSolicitud
{
    [Key]
    public int nDocumentoReferenciaID { get; set; }

    public int nScrSolicitudID { get; set; }

    public int nScrDocumentoID { get; set; }

    public bool nRequisitoObligatorio { get; set; }

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

    [ForeignKey("nScrDocumentoID")]
    [InverseProperty("ScrDocumentoSolicituds")]
    public virtual ScrDocumento nScrDocumento { get; set; } = null!;

    [ForeignKey("nScrSolicitudID")]
    [InverseProperty("ScrDocumentoSolicituds")]
    public virtual ScrCredito nScrSolicitud { get; set; } = null!;
}
