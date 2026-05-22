using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbNegocio")]
public partial class StbNegocio
{
    [Key]
    public int nStbNegocioID { get; set; }

    public int nStbClienteID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string cNombreNegocio { get; set; } = null!;

    [StringLength(350)]
    [Unicode(false)]
    public string cDireccionNegocio { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? cMatricula { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cTelefono { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaDesdeDireccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaDesdeDedica { get; set; }

    public byte? nEmpleadosNegocio { get; set; }

    public bool? nTieneSocios { get; set; }

    public byte? nSocios { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nPromedioVentas { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nGastos { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nSalarios { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nMateriales { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nOtrosGastos { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nUtilidades { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? nOtrosIngresos { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cUsuarioCreacion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaCreacion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? cUsuarioModifcacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dFechaModifcacion { get; set; }

    [ForeignKey("nStbClienteID")]
    [InverseProperty("StbNegocios")]
    public virtual StbCliente nStbCliente { get; set; } = null!;
}
