using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbRubroDetalle")]
public partial class StbRubroDetalle
{
    [Key]
    public int nStbRubroDetalleID { get; set; }

    public int nStbRubroID { get; set; }

    public byte? nNoCreditos { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? nTasaInteres { get; set; }

    public byte nPlazo { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal nMonto { get; set; }

    [Column(TypeName = "numeric(8, 2)")]
    public decimal? nComision { get; set; }

    public int nStbFrecuenciaPagoID { get; set; }

    public DateOnly dFechaInicio { get; set; }

    public DateOnly? dFechaFin { get; set; }

    public byte? nEstado { get; set; }

    [InverseProperty("nStbRubroDetalle")]
    public virtual ICollection<ScrCredito> ScrCreditos { get; set; } = new List<ScrCredito>();

    [ForeignKey("nStbFrecuenciaPagoID")]
    [InverseProperty("StbRubroDetalles")]
    public virtual StbFrecuenciaPago nStbFrecuenciaPago { get; set; } = null!;

    [ForeignKey("nStbRubroID")]
    [InverseProperty("StbRubroDetalles")]
    public virtual StbRubro nStbRubro { get; set; } = null!;
}
