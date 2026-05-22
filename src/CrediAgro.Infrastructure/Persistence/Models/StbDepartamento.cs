using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbDepartamento")]
public partial class StbDepartamento
{
    [Key]
    public int nStbDepartamentoID { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string sCodigo { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string sNombre { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? sNombreColor { get; set; }

    public byte nActivo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sSerieDelegacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string sUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? sUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }

    [InverseProperty("nStbDepartamento")]
    public virtual ICollection<StbMunicipio> StbMunicipios { get; set; } = new List<StbMunicipio>();
}
