using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Facultad
    {
        public Facultad()
        {
            Escuela = new HashSet<Escuela>();
        }

        public int FacultadId { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }

        public virtual ICollection<Escuela> Escuela { get; set; }
    }
}
