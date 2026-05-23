using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbModalidad")]
public partial class StbModalidad
{
    [Key]
    public int nStbModalidadID { get; set; }

    [StringLength(4)]
    public string cCodigo { get; set; } = null!;

    [StringLength(50)]
    public string? cDescripcion { get; set; }

    public int? nPlazo { get; set; }

    public byte? nActivo { get; set; }

    [StringLength(100)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [StringLength(100)]
    public string? UsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }
}
