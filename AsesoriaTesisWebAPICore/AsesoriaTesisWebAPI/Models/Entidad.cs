using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Entidad
    {
        public Entidad()
        {
            Entidadciclo = new HashSet<Entidadciclo>();
        }

        public int EntidadId { get; set; }
        public int RolId { get; set; }
        public int EstaActivo { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Docente Docente { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Entidadciclo> Entidadciclo { get; set; }
    }
}
