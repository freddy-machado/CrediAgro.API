using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbValorCatalogo")]
public partial class StbValorCatalogo
{
    [Key]
    public int nStbValorCatalogoID { get; set; }

    public int nStbCatalogoID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string cCodigoInterno { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string cDescripcion { get; set; } = null!;

    public bool nActivo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModificacion { get; set; }

    [InverseProperty("nStbEstadoSolicitud")]
    public virtual ICollection<ScrCredito> ScrCreditos { get; set; } = new List<ScrCredito>();

    [InverseProperty("nStbFormaPago")]
    public virtual ICollection<ScrDesembolsoPago> ScrDesembolsoPagos { get; set; } = new List<ScrDesembolsoPago>();

    [InverseProperty("nStbTipoDocumentoNavigation")]
    public virtual ICollection<ScrDocumento> ScrDocumentos { get; set; } = new List<ScrDocumento>();

    [InverseProperty("nStbFrecuenciaPagoNavigation")]
    public virtual ICollection<ScrFrecuenciaPagoRubro> ScrFrecuenciaPagoRubros { get; set; } = new List<ScrFrecuenciaPagoRubro>();

    [InverseProperty("nStbInteres")]
    public virtual ICollection<ScrInteresRubro> ScrInteresRubros { get; set; } = new List<ScrInteresRubro>();

    [InverseProperty("nStbPlazoPagoNavigation")]
    public virtual ICollection<ScrPlazoPagoRubro> ScrPlazoPagoRubros { get; set; } = new List<ScrPlazoPagoRubro>();

    [InverseProperty("nStbPuestoNavigation")]
    public virtual ICollection<StbCliente> StbClientenStbPuestoNavigations { get; set; } = new List<StbCliente>();

    [InverseProperty("nStbViviendaNavigation")]
    public virtual ICollection<StbCliente> StbClientenStbViviendaNavigations { get; set; } = new List<StbCliente>();

    [InverseProperty("nStbParentescoNavigation")]
    public virtual ICollection<StbFiador> StbFiadornStbParentescoNavigations { get; set; } = new List<StbFiador>();

    [InverseProperty("nStbPuestoNavigation")]
    public virtual ICollection<StbFiador> StbFiadornStbPuestoNavigations { get; set; } = new List<StbFiador>();

    [InverseProperty("nStbViviendaNavigation")]
    public virtual ICollection<StbFiador> StbFiadornStbViviendaNavigations { get; set; } = new List<StbFiador>();

    [InverseProperty("nStbEscolaridad")]
    public virtual ICollection<StbPersona> StbPersonanStbEscolaridads { get; set; } = new List<StbPersona>();

    [InverseProperty("nStbEstadoCivil")]
    public virtual ICollection<StbPersona> StbPersonanStbEstadoCivils { get; set; } = new List<StbPersona>();

    [InverseProperty("nStbProfesionOficioNavigation")]
    public virtual ICollection<StbPersona> StbPersonanStbProfesionOficioNavigations { get; set; } = new List<StbPersona>();

    [ForeignKey("nStbCatalogoID")]
    [InverseProperty("StbValorCatalogos")]
    public virtual StbCatalogo nStbCatalogo { get; set; } = null!;
}
