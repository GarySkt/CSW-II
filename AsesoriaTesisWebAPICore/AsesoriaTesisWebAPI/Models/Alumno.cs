using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Actividad = new HashSet<Actividad>();
        }

        public int AlumnoId { get; set; }
        public int EscuelaId { get; set; }
        public int CreditoAprobado { get; set; }

        public virtual Entidad AlumnoNavigation { get; set; }
        public virtual Escuela Escuela { get; set; }
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
