using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
public partial class vwCliente
{
    public int nStbClienteID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string cCodigoCliente { get; set; } = null!;

    public int nStbPersonaID { get; set; }

    [StringLength(403)]
    [Unicode(false)]
    public string nombresApellidos { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string sexo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string cDireccion { get; set; } = null!;

    public bool nTrabaja { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string cLugarTrabajo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string cDireccionTrabajo { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string puesto { get; set; } = null!;

    [Column(TypeName = "numeric(12, 2)")]
    public decimal nSueldoMensual { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string cObservaciones { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string prestamoActivo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dFechaDesdeDireccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaHastaDireccion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dFechaNacApertura { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string cTelefono1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string cCelular1 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string cNumeroCedula { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string cSiglas { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string cNumeroRUC { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string cEMail { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? bFoto { get; set; }

    public int edad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string estadoCivil { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string escolaridad { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string profesion { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string tipoVivienda { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string municipio { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string periodoDireccion { get; set; } = null!;
}
