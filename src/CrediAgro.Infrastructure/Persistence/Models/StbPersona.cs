using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbPersona")]
public partial class StbPersona
{
    [Key]
    public int nStbPersonaID { get; set; }

    [StringLength(20)]
    public string cCodigoPersona { get; set; } = null!;

    public int nStbTipoPersonaID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string cNombre1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? cNombre2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cApellido1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cApellido2 { get; set; }

    public byte nPersonaActiva { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? cDireccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaDesdeDireccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaHastaDireccion { get; set; }

    public int? nStbEscolaridadID { get; set; }

    public int? nStbProfesionOficio { get; set; }

    public int? nStbEstadoCivilID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaNacApertura { get; set; }

    public int? nSexo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cTelefono1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cExtension { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cTelefono2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cCelular1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cCelular2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cFax { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? cNumeroCedula { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cSiglas { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? cNumeroRUC { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? cEMail { get; set; }

    public int nStbMunicipioID { get; set; }

    [Column(TypeName = "image")]
    public byte[]? bFoto { get; set; }

    public byte? nEsSocia { get; set; }

    public int? nStbBarrioComarcaID { get; set; }

    [InverseProperty("nStbPersona")]
    public virtual ICollection<StbCliente> StbClientes { get; set; } = new List<StbCliente>();

    [InverseProperty("nStbPersona")]
    public virtual ICollection<StbFiador> StbFiadors { get; set; } = new List<StbFiador>();

    [ForeignKey("nStbEscolaridadID")]
    [InverseProperty("StbPersonanStbEscolaridads")]
    public virtual StbValorCatalogo? nStbEscolaridad { get; set; }

    [ForeignKey("nStbEstadoCivilID")]
    [InverseProperty("StbPersonanStbEstadoCivils")]
    public virtual StbValorCatalogo? nStbEstadoCivil { get; set; }

    [ForeignKey("nStbMunicipioID")]
    [InverseProperty("StbPersonas")]
    public virtual StbMunicipio nStbMunicipio { get; set; } = null!;

    [ForeignKey("nStbProfesionOficio")]
    [InverseProperty("StbPersonanStbProfesionOficioNavigations")]
    public virtual StbValorCatalogo? nStbProfesionOficioNavigation { get; set; }
}
