using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Escuela
    {
        public Escuela()
        {
            Entidad = new HashSet<Entidad>();
        }

        public int EscuelaId { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public int FacultadId { get; set; }

        public virtual Facultad Facultad { get; set; }
        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
