using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbMunicipio")]
public partial class StbMunicipio
{
    [Key]
    public int nStbMunicipioID { get; set; }

    public int nStbDepartamentoID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sCodigo { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string sNombre { get; set; } = null!;

    public byte nActivo { get; set; }

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

    [InverseProperty("nStbMunicipio")]
    public virtual ICollection<StbPersona> StbPersonas { get; set; } = new List<StbPersona>();

    [ForeignKey("nStbDepartamentoID")]
    [InverseProperty("StbMunicipios")]
    public virtual StbDepartamento nStbDepartamento { get; set; } = null!;
}
