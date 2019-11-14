using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class PostDbContext : DbContext
    {
        public PostDbContext()
        {
        }

        public PostDbContext(DbContextOptions<PostDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acceso> Acceso { get; set; }
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Actividadtipo> Actividadtipo { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Asesor> Asesor { get; set; }
        public virtual DbSet<Ciclo> Ciclo { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<Entidadciclo> Entidadciclo { get; set; }
        public virtual DbSet<Entregable> Entregable { get; set; }
        public virtual DbSet<Entregableestado> Entregableestado { get; set; }
        public virtual DbSet<Entregablehistoria> Entregablehistoria { get; set; }
        public virtual DbSet<Entregablemedalla> Entregablemedalla { get; set; }
        public virtual DbSet<Escuela> Escuela { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Especialidaddocente> Especialidaddocente { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Medalla> Medalla { get; set; }
        public virtual DbSet<Medallatipo> Medallatipo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=Tutoria;Uid=root;Pwd=''");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasKey(e => e.EntidadId)
                    .HasName("PRIMARY");

                entity.ToTable("Acceso");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoInstitucional)
                    .IsRequired()
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Acceso)
                    .HasForeignKey<Acceso>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acceso_ibfk_1");
            });

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.ToTable("Actividad");

                entity.HasIndex(e => e.ActividadTipoId)
                    .HasName("ActividadTipoID");

                entity.HasIndex(e => e.AlumnoId)
                    .HasName("AlumnoID");

                entity.HasIndex(e => e.AsesorId)
                    .HasName("AsesorID");

                entity.Property(e => e.ActividadId)
                    .HasColumnName("ActividadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActividadTipoId)
                    .HasColumnName("ActividadTipoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlumnoId)
                    .HasColumnName("AlumnoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AsesorId)
                    .HasColumnName("AsesorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Finalizada).HasColumnType("int(11)");

                entity.Property(e => e.Resumen)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.ActividadTipo)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.ActividadTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actividad_ibfk_3");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actividad_ibfk_1");

                entity.HasOne(d => d.Asesor)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.AsesorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actividad_ibfk_2");
            });

            modelBuilder.Entity<Actividadtipo>(entity =>
            {
                entity.ToTable("Actividadtipo");

                entity.Property(e => e.ActividadTipoId)
                    .HasColumnName("ActividadTipoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreditoRequerido).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.ToTable("Alumno");

                entity.HasIndex(e => e.EscuelaId)
                    .HasName("EscuelaID");

                entity.Property(e => e.AlumnoId)
                    .HasColumnName("AlumnoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreditoAprobado).HasColumnType("int(11)");

                entity.Property(e => e.EscuelaId)
                    .HasColumnName("EscuelaID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.AlumnoNavigation)
                    .WithOne(p => p.Alumno)
                    .HasForeignKey<Alumno>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_ibfk_1");

                entity.HasOne(d => d.Escuela)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.EscuelaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_ibfk_2");
            });

            modelBuilder.Entity<Asesor>(entity =>
            {
                entity.ToTable("Asesor");

                entity.Property(e => e.AsesorId)
                    .HasColumnName("AsesorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Disponibilidad)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.AsesorNavigation)
                    .WithOne(p => p.Asesor)
                    .HasForeignKey<Asesor>(d => d.AsesorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("asesor_ibfk_1");
            });

            modelBuilder.Entity<Ciclo>(entity =>
            {
                entity.ToTable("Ciclo");

                entity.Property(e => e.CicloId)
                    .HasColumnName("CicloID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Anio).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.EntidadId)
                    .HasName("PRIMARY");

                entity.ToTable("Contacto");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorreoInstitucional)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CorreoPersonal)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Contacto)
                    .HasForeignKey<Contacto>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacto_ibfk_1");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.ToTable("Docente");

                entity.HasIndex(e => e.EscuelaId)
                    .HasName("EscuelaID");

                entity.Property(e => e.DocenteId)
                    .HasColumnName("DocenteID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscuelaId)
                    .HasColumnName("EscuelaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.DocenteNavigation)
                    .WithOne(p => p.Docente)
                    .HasForeignKey<Docente>(d => d.DocenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("docente_ibfk_1");

                entity.HasOne(d => d.Escuela)
                    .WithMany(p => p.Docente)
                    .HasForeignKey(d => d.EscuelaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("docente_ibfk_2");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.ToTable("Entidad");

                entity.HasIndex(e => e.RolId)
                    .HasName("RolID");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RolId)
                    .HasColumnName("RolID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entidad_ibfk_1");
            });

            modelBuilder.Entity<Entidadciclo>(entity =>
            {
                entity.ToTable("Entidadciclo");

                entity.HasIndex(e => e.CicloId)
                    .HasName("CicloID");

                entity.HasIndex(e => e.EntidadId)
                    .HasName("EntidadID");

                entity.Property(e => e.EntidadCicloId)
                    .HasColumnName("EntidadCicloID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CicloId)
                    .HasColumnName("CicloID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Ciclo)
                    .WithMany(p => p.Entidadciclo)
                    .HasForeignKey(d => d.CicloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entidadciclo_ibfk_2");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.Entidadciclo)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entidadciclo_ibfk_1");
            });

            modelBuilder.Entity<Entregable>(entity =>
            {
                entity.ToTable("Entregable");

                entity.HasIndex(e => e.ActividadId)
                    .HasName("ActividadID");

                entity.Property(e => e.EntregableId)
                    .HasColumnName("EntregableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActividadId)
                    .HasColumnName("ActividadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.FechaAprobado)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1500-05-05'");

                entity.Property(e => e.NumeroOrden).HasColumnType("int(11)");

                entity.HasOne(d => d.Actividad)
                    .WithMany(p => p.Entregable)
                    .HasForeignKey(d => d.ActividadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entregable_ibfk_1");
            });

            modelBuilder.Entity<Entregableestado>(entity =>
            {
                entity.ToTable("Entregableestado");

                entity.Property(e => e.EntregableEstadoId)
                    .HasColumnName("EntregableEstadoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComentarioAlumno)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.ComentarioDocente)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.DocumentoUrl)
                    .IsRequired()
                    .HasColumnName("DocumentoURL")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1500-05-05'");
            });

            modelBuilder.Entity<Entregablehistoria>(entity =>
            {
                entity.ToTable("Entregablehistoria");

                entity.HasIndex(e => e.EntregableEstadoId)
                    .HasName("EntregableEstadoID");

                entity.HasIndex(e => e.EntregableId)
                    .HasName("EntregableID");

                entity.Property(e => e.EntregableHistoriaId)
                    .HasColumnName("EntregableHistoriaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntregableEstadoId)
                    .HasColumnName("EntregableEstadoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntregableId)
                    .HasColumnName("EntregableID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.EntregableEstado)
                    .WithMany(p => p.Entregablehistoria)
                    .HasForeignKey(d => d.EntregableEstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entregablehistoria_ibfk_1");

                entity.HasOne(d => d.Entregable)
                    .WithMany(p => p.Entregablehistoria)
                    .HasForeignKey(d => d.EntregableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entregablehistoria_ibfk_2");
            });

            modelBuilder.Entity<Entregablemedalla>(entity =>
            {
                entity.ToTable("Entregablemedalla");

                entity.HasIndex(e => e.EntregableId)
                    .HasName("EntregableID");

                entity.HasIndex(e => e.MedallaId)
                    .HasName("MedallaID");

                entity.Property(e => e.EntregableMedallaId)
                    .HasColumnName("EntregableMedallaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntregableId)
                    .HasColumnName("EntregableID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1500-05-05'");

                entity.Property(e => e.MedallaId)
                    .HasColumnName("MedallaID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Entregable)
                    .WithMany(p => p.Entregablemedalla)
                    .HasForeignKey(d => d.EntregableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entregablemedalla_ibfk_1");

                entity.HasOne(d => d.Medalla)
                    .WithMany(p => p.Entregablemedalla)
                    .HasForeignKey(d => d.MedallaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("entregablemedalla_ibfk_2");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.ToTable("Escuela");

                entity.HasIndex(e => e.FacultadId)
                    .HasName("FacultadID");

                entity.Property(e => e.EscuelaId)
                    .HasColumnName("EscuelaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.FacultadId)
                    .HasColumnName("FacultadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Facultad)
                    .WithMany(p => p.Escuela)
                    .HasForeignKey(d => d.FacultadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("escuela_ibfk_1");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.ToTable("Especialidad");

                entity.Property(e => e.EspecialidadId)
                    .HasColumnName("EspecialidadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Especialidaddocente>(entity =>
            {
                entity.ToTable("Especialidaddocente");

                entity.HasIndex(e => e.DocenteId)
                    .HasName("DocenteID");

                entity.HasIndex(e => e.EspecialidadId)
                    .HasName("EspecialidadID");

                entity.Property(e => e.EspecialidadDocenteId)
                    .HasColumnName("EspecialidadDocenteID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocenteId)
                    .HasColumnName("DocenteID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EspecialidadId)
                    .HasColumnName("EspecialidadID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Docente)
                    .WithMany(p => p.Especialidaddocente)
                    .HasForeignKey(d => d.DocenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("especialidaddocente_ibfk_2");

                entity.HasOne(d => d.Especialidad)
                    .WithMany(p => p.Especialidaddocente)
                    .HasForeignKey(d => d.EspecialidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("especialidaddocente_ibfk_1");
            });

            modelBuilder.Entity<Facultad>(entity =>
            {
                entity.ToTable("Facultad");

                entity.Property(e => e.FacultadId)
                    .HasColumnName("FacultadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Medalla>(entity =>
            {
                entity.ToTable("Medalla");

                entity.HasIndex(e => e.MedallaTipoId)
                    .HasName("MedallaTipoID");

                entity.Property(e => e.MedallaId)
                    .HasColumnName("MedallaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.ImagenUrl)
                    .IsRequired()
                    .HasColumnName("ImagenURL")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.MedallaTipoId)
                    .HasColumnName("MedallaTipoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.MedallaTipo)
                    .WithMany(p => p.Medalla)
                    .HasForeignKey(d => d.MedallaTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("medalla_ibfk_1");
            });

            modelBuilder.Entity<Medallatipo>(entity =>
            {
                entity.ToTable("MedallaTipo");

                entity.Property(e => e.MedallaTipoId)
                    .HasColumnName("MedallaTipoID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.PersonaID)
                    .HasColumnName("PersonaID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("DNI")
                    .HasColumnType("char(8)");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'1500-05-05'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Persona)
                    .HasForeignKey<Persona>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("persona_ibfk_1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolId)
                    .HasColumnName("RolID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });
        }
    }
}
