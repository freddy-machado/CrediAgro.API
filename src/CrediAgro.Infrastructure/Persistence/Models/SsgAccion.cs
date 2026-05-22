using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("SsgAccion")]
public partial class SsgAccion
{
    [Key]
    public int SsgAccionID { get; set; }

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

    public int objServicioUsuarioID { get; set; }

    [ForeignKey("objServicioUsuarioID")]
    [InverseProperty("SsgAccions")]
    public virtual SsgServicioUsuario objServicioUsuario { get; set; } = null!;
}
