using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Table("StbCategoriaCliente")]
public partial class StbCategoriaCliente
{
    [Key]
    public int nCategoriaClienteID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? cNombreCategoria { get; set; }
}
