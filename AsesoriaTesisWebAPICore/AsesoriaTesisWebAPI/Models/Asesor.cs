using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Asesor
    {
        public Asesor()
        {
            Actividad = new HashSet<Actividad>();
        }

        public int AsesorId { get; set; }
        public int Disponibilidad { get; set; }

        public virtual Docente AsesorNavigation { get; set; }
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
