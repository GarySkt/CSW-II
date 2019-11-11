using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Especialidaddocente = new HashSet<Especialidaddocente>();
        }

        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Especialidaddocente> Especialidaddocente { get; set; }
    }
}
