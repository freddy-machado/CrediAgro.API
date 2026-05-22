using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgServicioUsuario")]
public partial class SsgServicioUsuario
{
    [Key]
    public int SsgServicioUsuarioID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CodInterno { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string UsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? UsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    public int objModuloID { get; set; }

    [InverseProperty("objServicioUsuario")]
    public virtual ICollection<SsgAccion> SsgAccions { get; set; } = new List<SsgAccion>();

    [ForeignKey("objModuloID")]
    [InverseProperty("SsgServicioUsuarios")]
    public virtual SsgModulo objModulo { get; set; } = null!;
}
