using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Escuela
    {
        public Escuela()
        {
            Alumno = new HashSet<Alumno>();
            Docente = new HashSet<Docente>();
        }

        public int EscuelaId { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public int FacultadId { get; set; }

        public virtual Facultad Facultad { get; set; }
        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<Docente> Docente { get; set; }
    }
}
