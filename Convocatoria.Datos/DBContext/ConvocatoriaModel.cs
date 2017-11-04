namespace Convocatoria.Datos.DBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Convocatoria.Datos.Entities;

    public partial class ConvocatoriaModel : DbContext
    {
        public ConvocatoriaModel()
            : base("name=ConvocatoriaModel")
        {
        }

        public virtual DbSet<TI_ANEXOHOJAVIDA> TI_ANEXOHOJAVIDA { get; set; }
        public virtual DbSet<TM_ACADEMICA> TM_ACADEMICA { get; set; }
        public virtual DbSet<TM_CONVOCATORIACARGO> TM_CONVOCATORIACARGO { get; set; }
        public virtual DbSet<TM_CONVOCATORIAMODULO> TM_CONVOCATORIAMODULO { get; set; }
        public virtual DbSet<TM_CRONOGRAMA> TM_CRONOGRAMA { get; set; }
        public virtual DbSet<TM_CRONOGRAMAACTIVIDAD> TM_CRONOGRAMAACTIVIDAD { get; set; }
        public virtual DbSet<TM_DOCENTE> TM_DOCENTE { get; set; }
        public virtual DbSet<TM_EXPERIENCIAOTROS> TM_EXPERIENCIAOTROS { get; set; }
        public virtual DbSet<TM_HOJAVIDA> TM_HOJAVIDA { get; set; }
        public virtual DbSet<TM_HOJAVIDAOTRASEXPERIENCIAS> TM_HOJAVIDAOTRASEXPERIENCIAS { get; set; }
        public virtual DbSet<TM_INSCRIPCIONCONVOCATORIA> TM_INSCRIPCIONCONVOCATORIA { get; set; }
        public virtual DbSet<TM_INVESTIGACION> TM_INVESTIGACION { get; set; }
        public virtual DbSet<TM_LABORAL> TM_LABORAL { get; set; }
        public virtual DbSet<TM_PUBLICACIONES> TM_PUBLICACIONES { get; set; }
        public virtual DbSet<TM_RECONOCIMIENTOS> TM_RECONOCIMIENTOS { get; set; }
        public virtual DbSet<TP_ACTIVIDAD> TP_ACTIVIDAD { get; set; }
        public virtual DbSet<TP_CARGO> TP_CARGO { get; set; }
        public virtual DbSet<TP_CIUDAD> TP_CIUDAD { get; set; }
        public virtual DbSet<TP_CONVOCATORIA> TP_CONVOCATORIA { get; set; }
        public virtual DbSet<TP_DEPARTAMENTO> TP_DEPARTAMENTO { get; set; }
        public virtual DbSet<TP_ENTIDADEDUCATIVA> TP_ENTIDADEDUCATIVA { get; set; }
        public virtual DbSet<TP_ETAPA> TP_ETAPA { get; set; }
        public virtual DbSet<TP_GENERO> TP_GENERO { get; set; }
        public virtual DbSet<TP_MODULO> TP_MODULO { get; set; }
        public virtual DbSet<TP_OTRASEXPERIENCIAS> TP_OTRASEXPERIENCIAS { get; set; }
        public virtual DbSet<TP_PAIS> TP_PAIS { get; set; }
        public virtual DbSet<TP_PERSONA> TP_PERSONA { get; set; }
        public virtual DbSet<TP_PROGRAMASFORMACION> TP_PROGRAMASFORMACION { get; set; }
        public virtual DbSet<TP_TIPODISCAPACIDAD> TP_TIPODISCAPACIDAD { get; set; }
        public virtual DbSet<TP_TIPODOCUMENTOANEXO> TP_TIPODOCUMENTOANEXO { get; set; }
        public virtual DbSet<TP_TIPOENTIDADEDUCATIVA> TP_TIPOENTIDADEDUCATIVA { get; set; }
        public virtual DbSet<TP_TIPOFORMACION> TP_TIPOFORMACION { get; set; }
        public virtual DbSet<TP_TIPOIDENTIFICACION> TP_TIPOIDENTIFICACION { get; set; }
        public virtual DbSet<TP_TIPONIVELEDUCATIVO> TP_TIPONIVELEDUCATIVO { get; set; }
        public virtual DbSet<TP_TIPOPUBLICACION> TP_TIPOPUBLICACION { get; set; }
        public virtual DbSet<TP_TIPORECONOCIMIENTO> TP_TIPORECONOCIMIENTO { get; set; }
        public virtual DbSet<TP_TIPOVINCULACION> TP_TIPOVINCULACION { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.ID_TI_ANEXOHOJAVIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.ID_TP_TIPODOCUMENTOANEXO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.ID_TM_HOJAVIDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.NOMBRECOMPLETO)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.EXTENSION)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.RUTACOMPLETA)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.SECCION)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.AUDIT_USUARIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TI_ANEXOHOJAVIDA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_ACADEMICA>()
                .Property(e => e.TITULOOBTENIDO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_ACADEMICA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_ACADEMICA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_ACADEMICA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_ACADEMICA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIACARGO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIACARGO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIACARGO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIACARGO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIAMODULO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIAMODULO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIAMODULO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CONVOCATORIAMODULO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMA>()
                .HasMany(e => e.TM_CRONOGRAMAACTIVIDAD)
                .WithRequired(e => e.TM_CRONOGRAMA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_CRONOGRAMAACTIVIDAD>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMAACTIVIDAD>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMAACTIVIDAD>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_CRONOGRAMAACTIVIDAD>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.TELEFONOENTIDADEDUCATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.DIRECCIONENTIDADEDUCATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_DOCENTE>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_EXPERIENCIAOTROS>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_ACADEMICA)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_DOCENTE)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_EXPERIENCIAOTROS)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_HOJAVIDAOTRASEXPERIENCIAS)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_INSCRIPCIONCONVOCATORIA)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_INVESTIGACION)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_LABORAL)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_PUBLICACIONES)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDA>()
                .HasMany(e => e.TM_RECONOCIMIENTOS)
                .WithRequired(e => e.TM_HOJAVIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.FORMATO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.EXPRESIONREGULAR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_HOJAVIDAOTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INSCRIPCIONCONVOCATORIA>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INSCRIPCIONCONVOCATORIA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INSCRIPCIONCONVOCATORIA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INSCRIPCIONCONVOCATORIA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INSCRIPCIONCONVOCATORIA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.TELEFONOENTIDADEDUCATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.DIRECCIONENTIDADEDUCATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_INVESTIGACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.TELEFONOEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.NITEMMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.DIRECCIONEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_LABORAL>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.NOMBREPUBLICACION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.DESCRIPCIONPUBLICACION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_PUBLICACIONES>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TM_RECONOCIMIENTOS>()
                .Property(e => e.DESCRIPCIONRECONOCIMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_RECONOCIMIENTOS>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TM_RECONOCIMIENTOS>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TM_RECONOCIMIENTOS>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TM_RECONOCIMIENTOS>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ACTIVIDAD>()
                .HasMany(e => e.TM_CRONOGRAMAACTIVIDAD)
                .WithRequired(e => e.TP_ACTIVIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CARGO>()
                .HasMany(e => e.TM_CONVOCATORIACARGO)
                .WithRequired(e => e.TP_CARGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TM_ACADEMICA)
                .WithRequired(e => e.TP_CIUDAD)
                .HasForeignKey(e => e.ID_TP_CIUDAD_ESTUDIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TM_CONVOCATORIACARGO)
                .WithRequired(e => e.TP_CIUDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TM_DOCENTE)
                .WithRequired(e => e.TP_CIUDAD)
                .HasForeignKey(e => e.ID_TP_CIUDAD_ENTIDADEDUCATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TM_INVESTIGACION)
                .WithRequired(e => e.TP_CIUDAD)
                .HasForeignKey(e => e.ID_TP_CIUDAD_ENTIDADEDUCATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TM_LABORAL)
                .WithRequired(e => e.TP_CIUDAD)
                .HasForeignKey(e => e.ID_TP_CIUDAD_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CIUDAD>()
                .HasMany(e => e.TP_PERSONA)
                .WithRequired(e => e.TP_CIUDAD)
                .HasForeignKey(e => e.ID_TP_CIUDAD_RESIDENCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.URL_CMS)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .HasMany(e => e.TM_CONVOCATORIACARGO)
                .WithRequired(e => e.TP_CONVOCATORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .HasMany(e => e.TM_CONVOCATORIAMODULO)
                .WithRequired(e => e.TP_CONVOCATORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .HasMany(e => e.TM_CRONOGRAMA)
                .WithRequired(e => e.TP_CONVOCATORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_CONVOCATORIA>()
                .HasMany(e => e.TM_INSCRIPCIONCONVOCATORIA)
                .WithRequired(e => e.TP_CONVOCATORIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_DEPARTAMENTO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .HasMany(e => e.TM_ACADEMICA)
                .WithRequired(e => e.TP_ENTIDADEDUCATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .HasMany(e => e.TM_DOCENTE)
                .WithRequired(e => e.TP_ENTIDADEDUCATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_ENTIDADEDUCATIVA>()
                .HasMany(e => e.TM_INVESTIGACION)
                .WithRequired(e => e.TP_ENTIDADEDUCATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_ETAPA>()
                .HasMany(e => e.TM_CRONOGRAMA)
                .WithRequired(e => e.TP_ETAPA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_GENERO>()
                .HasMany(e => e.TP_PERSONA)
                .WithRequired(e => e.TP_GENERO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_MODULO>()
                .HasMany(e => e.TM_CONVOCATORIAMODULO)
                .WithRequired(e => e.TP_MODULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_OTRASEXPERIENCIAS>()
                .HasMany(e => e.TM_HOJAVIDAOTRASEXPERIENCIAS)
                .WithRequired(e => e.TP_OTRASEXPERIENCIAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PAIS>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.IDENTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.NOMBRES)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.APELLIDOS)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.TELEFONOFIJOCONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.TELEFONOMOVILCONTACTO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.DIRECCIONRESIDENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.DISCAPACIDADCOMENTARIOS)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PERSONA>()
                .HasMany(e => e.TM_HOJAVIDA)
                .WithRequired(e => e.TP_PERSONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_PROGRAMASFORMACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODISCAPACIDAD>()
                .HasMany(e => e.TP_PERSONA)
                .WithRequired(e => e.TP_TIPODISCAPACIDAD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPODOCUMENTOANEXO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOENTIDADEDUCATIVA>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOFORMACION>()
                .HasMany(e => e.TM_ACADEMICA)
                .WithRequired(e => e.TP_TIPOFORMACION)
                .HasForeignKey(e => e.ID_TP_TIPOFORMACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOIDENTIFICACION>()
                .HasMany(e => e.TP_PERSONA)
                .WithRequired(e => e.TP_TIPOIDENTIFICACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPONIVELEDUCATIVO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOPUBLICACION>()
                .HasMany(e => e.TM_PUBLICACIONES)
                .WithRequired(e => e.TP_TIPOPUBLICACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPORECONOCIMIENTO>()
                .HasMany(e => e.TM_RECONOCIMIENTOS)
                .WithRequired(e => e.TP_TIPORECONOCIMIENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.AUDIT_IP)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.AUDIT_NAVEGADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.AUDIT_SISTEMAOPERATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .Property(e => e.AUDIT_ACCION)
                .IsUnicode(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .HasMany(e => e.TM_DOCENTE)
                .WithRequired(e => e.TP_TIPOVINCULACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TP_TIPOVINCULACION>()
                .HasMany(e => e.TM_INVESTIGACION)
                .WithRequired(e => e.TP_TIPOVINCULACION)
                .WillCascadeOnDelete(false);
        }
    }
}
