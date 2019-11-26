using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class TutoriaContext : DbContext
    {
        public TutoriaContext()
        {
        }

        public TutoriaContext(DbContextOptions<TutoriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acceso> Acceso { get; set; }
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<ActividadTipo> ActividadTipo { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AreaInvestigacion> AreaInvestigacion { get; set; }
        public virtual DbSet<Asesor> Asesor { get; set; }
        public virtual DbSet<Ciclo> Ciclo { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Entidad> Entidad { get; set; }
        public virtual DbSet<EntidadCiclo> EntidadCiclo { get; set; }
        public virtual DbSet<Entregable> Entregable { get; set; }
        public virtual DbSet<EntregableEstado> EntregableEstado { get; set; }
        public virtual DbSet<EntregableHistoria> EntregableHistoria { get; set; }
        public virtual DbSet<EntregableMedalla> EntregableMedalla { get; set; }
        public virtual DbSet<Escuela> Escuela { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<LineaInvestigacion> LineaInvestigacion { get; set; }
        public virtual DbSet<LineaInvestigacionDocente> LineaInvestigacionDocente { get; set; }
        public virtual DbSet<Medalla> Medalla { get; set; }
        public virtual DbSet<MedallaTipo> MedallaTipo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:miservidorlocal.database.windows.net,1433;Initial Catalog=Tutoria;Persist Security Info=False;User ID=developer;Password=FB&@aRxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasKey(e => e.EntidadId)
                    .HasName("PK__Acceso__92A286E12483B64A");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoInstitucional)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Acceso)
                    .HasForeignKey<Acceso>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Acceso__EntidadI__5AEE82B9");
            });

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.Property(e => e.ActividadId).HasColumnName("ActividadID");

                entity.Property(e => e.ActividadTipoId).HasColumnName("ActividadTipoID");

                entity.Property(e => e.AlumnoId).HasColumnName("AlumnoID");

                entity.Property(e => e.AsesorId).HasColumnName("AsesorID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Resumen)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ActividadTipo)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.ActividadTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Actividad__Activ__7C4F7684");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Actividad__Alumn__7A672E12");

                entity.HasOne(d => d.Asesor)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.AsesorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Actividad__Aseso__7B5B524B");
            });

            modelBuilder.Entity<ActividadTipo>(entity =>
            {
                entity.Property(e => e.ActividadTipoId).HasColumnName("ActividadTipoID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.Property(e => e.AlumnoId)
                    .HasColumnName("AlumnoID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AlumnoNavigation)
                    .WithOne(p => p.Alumno)
                    .HasForeignKey<Alumno>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Alumno__AlumnoID__66603565");
            });

            modelBuilder.Entity<AreaInvestigacion>(entity =>
            {
                entity.Property(e => e.AreaInvestigacionId).HasColumnName("AreaInvestigacionID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Asesor>(entity =>
            {
                entity.Property(e => e.AsesorId)
                    .HasColumnName("AsesorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disponibilidad).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AsesorNavigation)
                    .WithOne(p => p.Asesor)
                    .HasForeignKey<Asesor>(d => d.AsesorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Asesor__AsesorID__75A278F5");
            });

            modelBuilder.Entity<Ciclo>(entity =>
            {
                entity.Property(e => e.CicloId).HasColumnName("CicloID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.Property(e => e.ConfiguracionId).HasColumnName("ConfiguracionID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.EntidadId)
                    .HasName("PK__Contacto__92A286E1BB4C7835");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorreoInstitucional)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoPersonal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Contacto)
                    .HasForeignKey<Contacto>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contacto__Entida__5DCAEF64");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.Property(e => e.DocenteId)
                    .HasColumnName("DocenteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocenteNavigation)
                    .WithOne(p => p.Docente)
                    .HasForeignKey<Docente>(d => d.DocenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Docente__Docente__693CA210");
            });

            modelBuilder.Entity<Entidad>(entity =>
            {
                entity.Property(e => e.EntidadId).HasColumnName("EntidadID");

                entity.Property(e => e.EscuelaId).HasColumnName("EscuelaID");

                entity.Property(e => e.EstaActivo)
                    .HasColumnName("estaActivo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.HasOne(d => d.Escuela)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.EscuelaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entidad__Escuela__5441852A");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Entidad)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entidad__RolID__534D60F1");
            });

            modelBuilder.Entity<EntidadCiclo>(entity =>
            {
                entity.Property(e => e.EntidadCicloId).HasColumnName("EntidadCicloID");

                entity.Property(e => e.CicloId).HasColumnName("CicloID");

                entity.Property(e => e.EntidadId).HasColumnName("EntidadID");

                entity.HasOne(d => d.Ciclo)
                    .WithMany(p => p.EntidadCiclo)
                    .HasForeignKey(d => d.CicloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EntidadCi__Ciclo__6383C8BA");

                entity.HasOne(d => d.Entidad)
                    .WithMany(p => p.EntidadCiclo)
                    .HasForeignKey(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EntidadCi__Entid__628FA481");
            });

            modelBuilder.Entity<Entregable>(entity =>
            {
                entity.Property(e => e.EntregableId).HasColumnName("EntregableID");

                entity.Property(e => e.ActividadId).HasColumnName("ActividadID");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Actividad)
                    .WithMany(p => p.Entregable)
                    .HasForeignKey(d => d.ActividadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entregabl__Activ__04E4BC85");
            });

            modelBuilder.Entity<EntregableEstado>(entity =>
            {
                entity.Property(e => e.EntregableEstadoId).HasColumnName("EntregableEstadoID");

                entity.Property(e => e.ComentarioAlumno)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAsesor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoUrl)
                    .IsRequired()
                    .HasColumnName("DocumentoURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('1500-05-05')");
            });

            modelBuilder.Entity<EntregableHistoria>(entity =>
            {
                entity.Property(e => e.EntregableHistoriaId).HasColumnName("EntregableHistoriaID");

                entity.Property(e => e.EntregableEstadoId).HasColumnName("EntregableEstadoID");

                entity.Property(e => e.EntregableId).HasColumnName("EntregableID");

                entity.HasOne(d => d.EntregableEstado)
                    .WithMany(p => p.EntregableHistoria)
                    .HasForeignKey(d => d.EntregableEstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entregabl__Entre__0A9D95DB");

                entity.HasOne(d => d.Entregable)
                    .WithMany(p => p.EntregableHistoria)
                    .HasForeignKey(d => d.EntregableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entregabl__Entre__0B91BA14");
            });

            modelBuilder.Entity<EntregableMedalla>(entity =>
            {
                entity.Property(e => e.EntregableMedallaId).HasColumnName("EntregableMedallaID");

                entity.Property(e => e.EntregableId).HasColumnName("EntregableID");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('1500-05-05')");

                entity.Property(e => e.MedallaId).HasColumnName("MedallaID");

                entity.HasOne(d => d.Entregable)
                    .WithMany(p => p.EntregableMedalla)
                    .HasForeignKey(d => d.EntregableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entregabl__Entre__0F624AF8");

                entity.HasOne(d => d.Medalla)
                    .WithMany(p => p.EntregableMedalla)
                    .HasForeignKey(d => d.MedallaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entregabl__Medal__10566F31");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.Property(e => e.EscuelaId).HasColumnName("EscuelaID");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacultadId).HasColumnName("FacultadID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facultad)
                    .WithMany(p => p.Escuela)
                    .HasForeignKey(d => d.FacultadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Escuela__Faculta__4F7CD00D");
            });

            modelBuilder.Entity<Facultad>(entity =>
            {
                entity.Property(e => e.FacultadId).HasColumnName("FacultadID");

                entity.Property(e => e.Acronimo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineaInvestigacion>(entity =>
            {
                entity.Property(e => e.LineaInvestigacionId).HasColumnName("LineaInvestigacionID");

                entity.Property(e => e.AreaInvestigacionId).HasColumnName("AreaInvestigacionID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaInvestigacion)
                    .WithMany(p => p.LineaInvestigacion)
                    .HasForeignKey(d => d.AreaInvestigacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaInve__AreaI__6E01572D");
            });

            modelBuilder.Entity<LineaInvestigacionDocente>(entity =>
            {
                entity.Property(e => e.LineaInvestigacionDocenteId).HasColumnName("LineaInvestigacionDocenteID");

                entity.Property(e => e.DocenteId).HasColumnName("DocenteID");

                entity.Property(e => e.LineaInvestigacionId).HasColumnName("LineaInvestigacionID");

                entity.HasOne(d => d.Docente)
                    .WithMany(p => p.LineaInvestigacionDocente)
                    .HasForeignKey(d => d.DocenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaInve__Docen__71D1E811");

                entity.HasOne(d => d.LineaInvestigacion)
                    .WithMany(p => p.LineaInvestigacionDocente)
                    .HasForeignKey(d => d.LineaInvestigacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaInve__Linea__70DDC3D8");
            });

            modelBuilder.Entity<Medalla>(entity =>
            {
                entity.Property(e => e.MedallaId).HasColumnName("MedallaID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImagenUrl)
                    .IsRequired()
                    .HasColumnName("ImagenURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MedallaTipoId).HasColumnName("MedallaTipoID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.MedallaTipo)
                    .WithMany(p => p.Medalla)
                    .HasForeignKey(d => d.MedallaTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medalla__Medalla__01142BA1");
            });

            modelBuilder.Entity<MedallaTipo>(entity =>
            {
                entity.Property(e => e.MedallaTipoId).HasColumnName("MedallaTipoID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.EntidadId)
                    .HasName("PK__Persona__92A286E1A8BF88E3");

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("DNI")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('1500-05-05')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entidad)
                    .WithOne(p => p.Persona)
                    .HasForeignKey<Persona>(d => d.EntidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Entidad__5812160E");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
