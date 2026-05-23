using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CrediAgro.Infrastructure.Persistence.Models;

public partial class StbMonedum
{
    [Key]
    public int nStbMonedaID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string cCodigoInterno { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string cSimbolo { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string cDescripcion { get; set; } = null!;

    public byte nNacional { get; set; }

    public byte nActivo { get; set; }

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

    [InverseProperty("nStbMoneda")]
    public virtual ICollection<ScrDesembolso> ScrDesembolsos { get; set; } = new List<ScrDesembolso>();

    [InverseProperty("nStbMoneda")]
    public virtual ICollection<ScrPagoCuotum> ScrPagoCuota { get; set; } = new List<ScrPagoCuotum>();
}
