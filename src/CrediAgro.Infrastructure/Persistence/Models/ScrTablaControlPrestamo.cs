using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrediAgro.Infrastructure.Persistence.Models;

[Keyless]
[Table("ScrTablaControlPrestamo")]
public partial class ScrTablaControlPrestamo
{
    public int N_INDICE { get; set; }

    public int? N_SOLICITUD_ID { get; set; }

    public int? N_PAGO_ID { get; set; }

    public int? N_NUMERO_CUOTA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? D_FECHA_CORTE { get; set; }

    [Column(TypeName = "numeric(8, 4)")]
    public decimal? N_TIPO_CAMBIO { get; set; }

    public short? N_DIAS_ENTRE_FECHA { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_SALDO_TOTAL { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_DESEMBOLSO_ACTUALIZADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_PRINCIPAL_PAGADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_SALDO_DOLARES { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_SALDO_AMORTIZACION { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MONTO_PAGO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MONTO_PAGO_ACUMULADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_DEVENGADO_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_DEVENGADO_ACUMULADO_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_ABONADO_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_ABONADO_ACUMULADO_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_PENDIENTE_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_PENDIENTE_ACUMULADO_AM { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_DEVENGADA { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_DEVEGADA_ACUMULADA { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_ABONADA { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_ABONADA_ACUMULADA { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_PENDIENTE { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_AMORTIZACION_PENDIENTE_ACUMULADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_SALDO_INTERES { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_DEVENGADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_DEVENGADO_ACUMULADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_ABONADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_ABONADO_ACUMULADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_PENDIENTE { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_INTERES_PENDIENTE_ACUMULADO { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_DEVENGADO_IC { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_DEVENGADO_ACUMULADO_IC { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_ABONADO_IC { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_ABONADO_ACUMULADO_IC { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_PENDIENTE_IC { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? N_MANTENIMIENTO_PENDIENTE_ACUMULADO_IC { get; set; }
}
