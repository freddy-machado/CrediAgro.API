using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgModulo")]
public partial class SsgModulo
{
    [Key]
    public int SsgModuloID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CodInterno { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? CodReporte { get; set; }

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

    public int objAplicacionID { get; set; }

    [InverseProperty("objModulo")]
    public virtual ICollection<SsgServicioUsuario> SsgServicioUsuarios { get; set; } = new List<SsgServicioUsuario>();

    [ForeignKey("objAplicacionID")]
    [InverseProperty("SsgModulos")]
    public virtual SsgAplicacion objAplicacion { get; set; } = null!;
}
