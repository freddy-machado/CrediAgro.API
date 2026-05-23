using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbCliente")]
public partial class StbCliente
{
    [Key]
    public int nStbClienteID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cCodigoCliente { get; set; }

    public int nStbPersonaID { get; set; }

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

    public int? nStbPromotor { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string? cObservaciones { get; set; }

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

    public byte? nTienePrestamoActivo { get; set; }

    [InverseProperty("nStbCliente")]
    public virtual ICollection<ScrCredito> ScrCreditos { get; set; } = new List<ScrCredito>();

    [InverseProperty("nStbCliente")]
    public virtual ICollection<StbNegocio> StbNegocios { get; set; } = new List<StbNegocio>();

    [ForeignKey("nStbPersonaID")]
    [InverseProperty("StbClientes")]
    public virtual StbPersona nStbPersona { get; set; } = null!;

    [ForeignKey("nStbPuesto")]
    [InverseProperty("StbClientenStbPuestoNavigations")]
    public virtual StbValorCatalogo? nStbPuestoNavigation { get; set; }

    [ForeignKey("nStbVivienda")]
    [InverseProperty("StbClientenStbViviendaNavigations")]
    public virtual StbValorCatalogo? nStbViviendaNavigation { get; set; }
}
