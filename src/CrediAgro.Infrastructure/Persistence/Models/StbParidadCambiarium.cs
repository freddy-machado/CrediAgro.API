using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class StbParidadCambiarium
{
    [Key]
    public int nStbParidadCambiariaID { get; set; }

    public int nStbMonedaBaseID { get; set; }

    public int nStbMonedaCambioID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaTCambio { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal nMontoTCambio { get; set; }

    public byte nActivo { get; set; }

    public byte nOcupado { get; set; }

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

    [InverseProperty("nStbParidadCambiaria")]
    public virtual ICollection<ScrCredito> ScrCreditos { get; set; } = new List<ScrCredito>();

    [InverseProperty("nStbParidadCambiaria")]
    public virtual ICollection<ScrDesembolso> ScrDesembolsos { get; set; } = new List<ScrDesembolso>();

    [InverseProperty("nStbParidadCambiaria")]
    public virtual ICollection<ScrPagoCuotum> ScrPagoCuota { get; set; } = new List<ScrPagoCuotum>();
}
