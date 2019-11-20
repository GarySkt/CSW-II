using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            Entregable = new HashSet<Entregable>();
        }

        public int ActividadId { get; set; }
        public int Finalizada { get; set; }
        public int AlumnoId { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Descripcion { get; set; }
        public int AsesorId { get; set; }
        public int ActividadTipoId { get; set; }

        public virtual ActividadTipo ActividadTipo { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Asesor Asesor { get; set; }
        public virtual ICollection<Entregable> Entregable { get; set; }
    }
}
