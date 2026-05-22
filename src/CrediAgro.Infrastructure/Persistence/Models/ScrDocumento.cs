using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("ScrDocumento")]
public partial class ScrDocumento
{
    [Key]
    public int nScrDocumentoID { get; set; }

    public int nStbTipoDocumento { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? cNombreDocumento { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? cObservacionDocumento { get; set; }

    [Column(TypeName = "image")]
    public byte[]? bImagen { get; set; }

    [InverseProperty("nScrDocumento")]
    public virtual ICollection<ScrDocumentoSolicitud> ScrDocumentoSolicituds { get; set; } = new List<ScrDocumentoSolicitud>();

    [ForeignKey("nStbTipoDocumento")]
    [InverseProperty("ScrDocumentos")]
    public virtual StbValorCatalogo nStbTipoDocumentoNavigation { get; set; } = null!;
}
