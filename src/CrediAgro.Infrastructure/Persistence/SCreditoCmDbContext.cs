using CrediAgro.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;


namespace CrediAgro.Infrastructure.Persistence;

public partial class SCreditoCmDbContext : DbContext
{
    public SCreditoCmDbContext(DbContextOptions<SCreditoCmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aaaaaa_TC> Aaaaaa_TCs { get; set; }

    public virtual DbSet<ScrCredito> ScrCreditos { get; set; }

    public virtual DbSet<ScrDesembolso> ScrDesembolsos { get; set; }

    public virtual DbSet<ScrDesembolsoPago> ScrDesembolsoPagos { get; set; }

    public virtual DbSet<ScrDocumento> ScrDocumentos { get; set; }

    public virtual DbSet<ScrDocumentoSolicitud> ScrDocumentoSolicituds { get; set; }

    public virtual DbSet<ScrExoneracion> ScrExoneracions { get; set; }

    public virtual DbSet<ScrFrecuenciaPagoRubro> ScrFrecuenciaPagoRubros { get; set; }

    public virtual DbSet<ScrInteresRubro> ScrInteresRubros { get; set; }

    public virtual DbSet<ScrPagoCuotaDetalle> ScrPagoCuotaDetalles { get; set; }

    public virtual DbSet<ScrPagoCuotum> ScrPagoCuota { get; set; }

    public virtual DbSet<ScrPlazoPagoRubro> ScrPlazoPagoRubros { get; set; }

    public virtual DbSet<ScrTablaControlPrestamo> ScrTablaControlPrestamos { get; set; }

    public virtual DbSet<ScrTablaproyeccionPago> ScrTablaproyeccionPagos { get; set; }

    public virtual DbSet<ScrTablaproyeccionPagoDinamica> ScrTablaproyeccionPagoDinamicas { get; set; }

    public virtual DbSet<SsgAccion> SsgAccions { get; set; }

    public virtual DbSet<SsgAplicacion> SsgAplicacions { get; set; }

    public virtual DbSet<SsgCuentaRol> SsgCuentaRols { get; set; }

    public virtual DbSet<SsgCuentaSeguridad> SsgCuentaSeguridads { get; set; }

    public virtual DbSet<SsgCuentum> SsgCuenta { get; set; }

    public virtual DbSet<SsgModulo> SsgModulos { get; set; }

    public virtual DbSet<SsgOperacionAuditorium> SsgOperacionAuditoria { get; set; }

    public virtual DbSet<SsgRol> SsgRols { get; set; }

    public virtual DbSet<SsgRolAccion> SsgRolAccions { get; set; }

    public virtual DbSet<SsgServicioUsuario> SsgServicioUsuarios { get; set; }

    public virtual DbSet<StbBarrioComarca> StbBarrioComarcas { get; set; }

    public virtual DbSet<StbCatalogo> StbCatalogos { get; set; }

    public virtual DbSet<StbCategoriaCliente> StbCategoriaClientes { get; set; }

    public virtual DbSet<StbCliente> StbClientes { get; set; }

    public virtual DbSet<StbConsecutivo> StbConsecutivos { get; set; }

    public virtual DbSet<StbDepartamento> StbDepartamentos { get; set; }

    public virtual DbSet<StbEmpresa> StbEmpresas { get; set; }

    public virtual DbSet<StbErrorresLog> StbErrorresLogs { get; set; }

    public virtual DbSet<StbFiador> StbFiadors { get; set; }

    public virtual DbSet<StbFrecuenciaPago> StbFrecuenciaPagos { get; set; }

    public virtual DbSet<StbLog> StbLogs { get; set; }

    public virtual DbSet<StbModalidad> StbModalidads { get; set; }

    public virtual DbSet<StbMonedum> StbMoneda { get; set; }

    public virtual DbSet<StbMunicipio> StbMunicipios { get; set; }

    public virtual DbSet<StbNegocio> StbNegocios { get; set; }

    public virtual DbSet<StbParametro> StbParametros { get; set; }

    public virtual DbSet<StbParidadCambiarium> StbParidadCambiaria { get; set; }

    public virtual DbSet<StbPersona> StbPersonas { get; set; }

    public virtual DbSet<StbRubro> StbRubros { get; set; }

    public virtual DbSet<StbRubroDetalle> StbRubroDetalles { get; set; }

    public virtual DbSet<StbValorCatalogo> StbValorCatalogos { get; set; }

    public virtual DbSet<tc_junio> tc_junios { get; set; }

    public virtual DbSet<vwCliente> vwClientes { get; set; }

    public virtual DbSet<vwEmpresa> vwEmpresas { get; set; }

    public virtual DbSet<vwFaidore> vwFaidores { get; set; }

    public virtual DbSet<vwRubro> vwRubros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ScrCredito>(entity =>
        {
            entity.HasKey(e => e.nScrSolicitudID).HasName("PK_ScrSolicitud");

            entity.HasOne(d => d.nStbCliente).WithMany(p => p.ScrCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrSolicitud_StbCliente");

            entity.HasOne(d => d.nStbEstadoSolicitud).WithMany(p => p.ScrCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrSolicitud_StbValorCatalogo");

            entity.HasOne(d => d.nStbParidadCambiaria).WithMany(p => p.ScrCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrSolicitud_StbParidadCambiaria");

            entity.HasOne(d => d.nStbRubroDetalle).WithMany(p => p.ScrCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrCredito_StbRubroDetalle");
        });

        modelBuilder.Entity<ScrDesembolso>(entity =>
        {
            entity.HasOne(d => d.nScrSolicitud).WithMany(p => p.ScrDesembolsos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDesembolso_ScrSolicitud");

            entity.HasOne(d => d.nStbMoneda).WithMany(p => p.ScrDesembolsos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDesembolso_StbMoneda");

            entity.HasOne(d => d.nStbParidadCambiaria).WithMany(p => p.ScrDesembolsos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDesembolso_StbParidadCambiaria");
        });

        modelBuilder.Entity<ScrDesembolsoPago>(entity =>
        {
            entity.HasOne(d => d.nScrDesembolso).WithMany(p => p.ScrDesembolsoPagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDesembolsoPago_ScrDesembolso");

            entity.HasOne(d => d.nStbFormaPago).WithMany(p => p.ScrDesembolsoPagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDesembolsoPago_StbValorCatalogo");
        });

        modelBuilder.Entity<ScrDocumento>(entity =>
        {
            entity.HasKey(e => e.nScrDocumentoID).HasName("PK_ScrDocumento1");

            entity.HasOne(d => d.nStbTipoDocumentoNavigation).WithMany(p => p.ScrDocumentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDocumento_StbValorCatalogo");
        });

        modelBuilder.Entity<ScrDocumentoSolicitud>(entity =>
        {
            entity.HasKey(e => e.nDocumentoReferenciaID).HasName("PK_ScrDocumento");

            entity.HasOne(d => d.nScrDocumento).WithMany(p => p.ScrDocumentoSolicituds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDocumentoSolicitud_ScrDocumentoSolicitud");

            entity.HasOne(d => d.nScrSolicitud).WithMany(p => p.ScrDocumentoSolicituds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrDocumentoSolicitud_ScrSolicitud");
        });

        modelBuilder.Entity<ScrExoneracion>(entity =>
        {
            entity.HasKey(e => e.nScrExoneracionID).HasName("PK__ScrExone__42D148FA86CFA042");

            entity.Property(e => e.cAplicaExhonera).IsFixedLength();
            entity.Property(e => e.cTipoExhonera).IsFixedLength();
            entity.Property(e => e.nMontoExhonera).HasComputedColumnSql("(case [cTipoExhonera] when 'PR' then round([nBaseMontoExhonera]*([nPorcentaje]/(100.0)),(2)) when 'MT' then round([nBaseMontoExhonera],(2))  end)", false);

            entity.HasOne(d => d.nScrSolicitud).WithMany(p => p.ScrExoneracions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrExoneracion_ScrCredito");
        });

        modelBuilder.Entity<ScrFrecuenciaPagoRubro>(entity =>
        {
            entity.HasKey(e => e.nScrFrecuenciaPagoRubroID).HasName("PK__ScrFrecu__0799A6D1648A27D5");

            entity.HasOne(d => d.nStbFrecuenciaPagoNavigation).WithMany(p => p.ScrFrecuenciaPagoRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrFrecuenciaPagoRubro_StbValorCatalogo");

            entity.HasOne(d => d.nStbRubro).WithMany(p => p.ScrFrecuenciaPagoRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrFrecuenciaPagoRubro_StbRubro");
        });

        modelBuilder.Entity<ScrInteresRubro>(entity =>
        {
            entity.HasOne(d => d.nStbInteres).WithMany(p => p.ScrInteresRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrInteresRubro_StbValorCatalogo");

            entity.HasOne(d => d.nStbRubro).WithMany(p => p.ScrInteresRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrInteresRubro_StbRubro");
        });

        modelBuilder.Entity<ScrPagoCuotaDetalle>(entity =>
        {
            entity.HasOne(d => d.nScrPagoCuota).WithMany(p => p.ScrPagoCuotaDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrPagoCuotaDetalle_ScrPagoCuota");

            entity.HasOne(d => d.nScrTablaproyeccionPago).WithMany(p => p.ScrPagoCuotaDetalles).HasConstraintName("FK_ScrPagoCuotaDetalle_ScrTablaproyeccionPago");
        });

        modelBuilder.Entity<ScrPagoCuotum>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("trgConsecutivoPagoCuota"));

            entity.HasOne(d => d.nStbMoneda).WithMany(p => p.ScrPagoCuota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrPagoCuota_StbMoneda");

            entity.HasOne(d => d.nStbParidadCambiaria).WithMany(p => p.ScrPagoCuota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrPagoCuota_StbParidadCambiaria");
        });

        modelBuilder.Entity<ScrPlazoPagoRubro>(entity =>
        {
            entity.HasOne(d => d.nStbPlazoPagoNavigation).WithMany(p => p.ScrPlazoPagoRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrPlazoPagoRubro_StbValorCatalogo");

            entity.HasOne(d => d.nStbRubro).WithMany(p => p.ScrPlazoPagoRubros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrPlazoPagoRubro_StbRubro");
        });

        modelBuilder.Entity<ScrTablaControlPrestamo>(entity =>
        {
            entity.Property(e => e.N_AMORTIZACION_ABONADA).HasDefaultValue(0.00m);
            entity.Property(e => e.N_AMORTIZACION_ABONADA_ACUMULADA).HasDefaultValue(0.00m);
            entity.Property(e => e.N_AMORTIZACION_DEVEGADA_ACUMULADA).HasDefaultValue(0.00m);
            entity.Property(e => e.N_AMORTIZACION_DEVENGADA).HasDefaultValue(0.00m);
            entity.Property(e => e.N_AMORTIZACION_PENDIENTE).HasDefaultValue(0.00m);
            entity.Property(e => e.N_AMORTIZACION_PENDIENTE_ACUMULADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_DESEMBOLSO_ACTUALIZADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_ABONADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_ABONADO_ACUMULADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_DEVENGADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_DEVENGADO_ACUMULADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_PENDIENTE).HasDefaultValue(0.00m);
            entity.Property(e => e.N_INTERES_PENDIENTE_ACUMULADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_ABONADO_ACUMULADO_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_ABONADO_ACUMULADO_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_ABONADO_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_ABONADO_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_DEVENGADO_ACUMULADO_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_DEVENGADO_ACUMULADO_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_DEVENGADO_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_DEVENGADO_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_PENDIENTE_ACUMULADO_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_PENDIENTE_ACUMULADO_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_PENDIENTE_AM).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MANTENIMIENTO_PENDIENTE_IC).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MONTO_PAGO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_MONTO_PAGO_ACUMULADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_PRINCIPAL_PAGADO).HasDefaultValue(0.00m);
            entity.Property(e => e.N_SALDO_AMORTIZACION).HasDefaultValue(0.00m);
            entity.Property(e => e.N_SALDO_INTERES).HasDefaultValue(0.00m);
            entity.Property(e => e.N_SALDO_TOTAL).HasDefaultValue(0.00m);
        });

        modelBuilder.Entity<ScrTablaproyeccionPago>(entity =>
        {
            entity.Property(e => e.nMontoMantenimientoInteres).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMantenimientoInteresAbonado).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMora).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMoraAbonado).HasDefaultValue(0.00m);

            entity.HasOne(d => d.nScrSolicitud).WithMany(p => p.ScrTablaproyeccionPagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrTablaproyeccionPago_ScrSolicitud");
        });

        modelBuilder.Entity<ScrTablaproyeccionPagoDinamica>(entity =>
        {
            entity.Property(e => e.nMontoMantenimientoInteres).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMantenimientoInteresAbonado).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMora).HasDefaultValue(0.00m);
            entity.Property(e => e.nMontoMoraAbonado).HasDefaultValue(0.00m);

            entity.HasOne(d => d.nScrSolicitud).WithMany(p => p.ScrTablaproyeccionPagoDinamicas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScrTablaproyeccionPagoDinamica_ScrSolicitud");
        });

        modelBuilder.Entity<SsgAccion>(entity =>
        {
            entity.HasOne(d => d.objServicioUsuario).WithMany(p => p.SsgAccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgAccion_SsgServicioUsuario");
        });

        modelBuilder.Entity<SsgCuentaRol>(entity =>
        {
            entity.HasOne(d => d.objCuenta).WithMany(p => p.SsgCuentaRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgCuentaRol_SsgCuenta");

            entity.HasOne(d => d.objRol).WithMany(p => p.SsgCuentaRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgCuentaRol_SsgRol");
        });

        modelBuilder.Entity<SsgCuentaSeguridad>(entity =>
        {
            entity.HasOne(d => d.nSsgCuenta).WithMany(p => p.SsgCuentaSeguridads)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgCuentaSeguridad_SsgCuenta");
        });

        modelBuilder.Entity<SsgModulo>(entity =>
        {
            entity.HasOne(d => d.objAplicacion).WithMany(p => p.SsgModulos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgModulo_SsgAplicacion");
        });

        modelBuilder.Entity<SsgRol>(entity =>
        {
            entity.HasOne(d => d.objAplicacion).WithMany(p => p.SsgRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgRol_SsgAplicacion");
        });

        modelBuilder.Entity<SsgRolAccion>(entity =>
        {
            entity.HasOne(d => d.objRol).WithMany(p => p.SsgRolAccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgRolAccion_SsgRol");
        });

        modelBuilder.Entity<SsgServicioUsuario>(entity =>
        {
            entity.HasOne(d => d.objModulo).WithMany(p => p.SsgServicioUsuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SsgServicioUsuario_SsgModulo");
        });

        modelBuilder.Entity<StbBarrioComarca>(entity =>
        {
            entity.Property(e => e.dFechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<StbCliente>(entity =>
        {
            entity.HasKey(e => e.nStbClienteID).HasName("PK__StbClien__344A182E95EA8720");

            entity.HasOne(d => d.nStbPersona).WithMany(p => p.StbClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbCliente_StbPersona");

            entity.HasOne(d => d.nStbPuestoNavigation).WithMany(p => p.StbClientenStbPuestoNavigations).HasConstraintName("FK_StbCliente_StbValorCatalogo");

            entity.HasOne(d => d.nStbViviendaNavigation).WithMany(p => p.StbClientenStbViviendaNavigations).HasConstraintName("FK_StbCliente_StbValorCatalogo1");
        });

        modelBuilder.Entity<StbFiador>(entity =>
        {
            entity.HasKey(e => e.nStbFiadorID).HasName("PK__StbFiado__ED4CCC138B5B30EE");

            entity.HasOne(d => d.nStbParentescoNavigation).WithMany(p => p.StbFiadornStbParentescoNavigations).HasConstraintName("FK_StbFiador_StbValorCatalogo2");

            entity.HasOne(d => d.nStbPersona).WithMany(p => p.StbFiadors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbFiador_StbPersona");

            entity.HasOne(d => d.nStbPuestoNavigation).WithMany(p => p.StbFiadornStbPuestoNavigations).HasConstraintName("FK_StbFiador_StbValorCatalogo");

            entity.HasOne(d => d.nStbSolicitud).WithMany(p => p.StbFiadors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbFiador_ScrSolicitud");

            entity.HasOne(d => d.nStbViviendaNavigation).WithMany(p => p.StbFiadornStbViviendaNavigations).HasConstraintName("FK_StbFiador_StbValorCatalogo1");
        });

        modelBuilder.Entity<StbMunicipio>(entity =>
        {
            entity.HasOne(d => d.nStbDepartamento).WithMany(p => p.StbMunicipios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbMunicipio_StbDepartamento");
        });

        modelBuilder.Entity<StbNegocio>(entity =>
        {
            entity.HasKey(e => e.nStbNegocioID).HasName("PK__StbNegoc__74A62E53A22221F2");

            entity.HasOne(d => d.nStbCliente).WithMany(p => p.StbNegocios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbNegocio_StbCliente");
        });

        modelBuilder.Entity<StbPersona>(entity =>
        {
            entity.HasKey(e => e.nStbPersonaID).HasName("PK__StbPerso__3D47506DEDE9D15A");

            entity.HasOne(d => d.nStbEscolaridad).WithMany(p => p.StbPersonanStbEscolaridads).HasConstraintName("FK_StbPersona_StbValorCatalogo");

            entity.HasOne(d => d.nStbEstadoCivil).WithMany(p => p.StbPersonanStbEstadoCivils).HasConstraintName("FK_StbPersona_StbValorCatalogo2");

            entity.HasOne(d => d.nStbMunicipio).WithMany(p => p.StbPersonas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbPersona_StbMunicipio1");

            entity.HasOne(d => d.nStbProfesionOficioNavigation).WithMany(p => p.StbPersonanStbProfesionOficioNavigations).HasConstraintName("FK_StbPersona_StbValorCatalogo1");
        });

        modelBuilder.Entity<StbRubroDetalle>(entity =>
        {
            entity.Property(e => e.nTasaInteres).HasDefaultValue(0.00m);

            entity.HasOne(d => d.nStbFrecuenciaPago).WithMany(p => p.StbRubroDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbRubroDetalle_StbFrecuenciaPagos");

            entity.HasOne(d => d.nStbRubro).WithMany(p => p.StbRubroDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbRubroDetalle_StbRubro");
        });

        modelBuilder.Entity<StbValorCatalogo>(entity =>
        {
            entity.HasOne(d => d.nStbCatalogo).WithMany(p => p.StbValorCatalogos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StbValorCatalogo_StbCatalogo");
        });

        modelBuilder.Entity<vwCliente>(entity =>
        {
            entity.ToView("vwClientes");
        });

        modelBuilder.Entity<vwEmpresa>(entity =>
        {
            entity.ToView("vwEmpresa");
        });

        modelBuilder.Entity<vwFaidore>(entity =>
        {
            entity.ToView("vwFaidores");
        });

        modelBuilder.Entity<vwRubro>(entity =>
        {
            entity.ToView("vwRubros");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
