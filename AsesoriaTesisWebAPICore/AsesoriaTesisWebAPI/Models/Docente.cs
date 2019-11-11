using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Docente
    {
        public Docente()
        {
            Especialidaddocente = new HashSet<Especialidaddocente>();
        }

        public int DocenteId { get; set; }
        public int EscuelaId { get; set; }
        public string Titulo { get; set; }

        public virtual Entidad DocenteNavigation { get; set; }
        public virtual Escuela Escuela { get; set; }
        public virtual Asesor Asesor { get; set; }
        public virtual ICollection<Especialidaddocente> Especialidaddocente { get; set; }
    }
}
