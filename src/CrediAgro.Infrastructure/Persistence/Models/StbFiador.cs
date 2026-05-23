using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbFiador")]
public partial class StbFiador
{
    [Key]
    public int nStbFiadorID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cCodigoFiador { get; set; }

    public int nStbPersonaID { get; set; }

    public int nStbSolicitudID { get; set; }

    public bool? nTrabaja { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cLugarTrabajo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? cDireccionTrabajo { get; set; }

    public int? nStbPuesto { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? nSueldoMensual { get; set; }

    public int? nStbVivienda { get; set; }

    public int? nStbParentesco { get; set; }

    public bool? nOtrosIngresos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cFuenteIngresos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cEsFiadorActualDe { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaConoceClienteDesde { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaConoceClienteHasta { get; set; }

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

    public byte? nEstado { get; set; }

    [ForeignKey("nStbParentesco")]
    [InverseProperty("StbFiadornStbParentescoNavigations")]
    public virtual StbValorCatalogo? nStbParentescoNavigation { get; set; }

    [ForeignKey("nStbPersonaID")]
    [InverseProperty("StbFiadors")]
    public virtual StbPersona nStbPersona { get; set; } = null!;

    [ForeignKey("nStbPuesto")]
    [InverseProperty("StbFiadornStbPuestoNavigations")]
    public virtual StbValorCatalogo? nStbPuestoNavigation { get; set; }

    [ForeignKey("nStbSolicitudID")]
    [InverseProperty("StbFiadors")]
    public virtual ScrCredito nStbSolicitud { get; set; } = null!;

    [ForeignKey("nStbVivienda")]
    [InverseProperty("StbFiadornStbViviendaNavigations")]
    public virtual StbValorCatalogo? nStbViviendaNavigation { get; set; }
}
