using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Persona
    {
        public int PersonaID { get; set; }
        public int EntidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }

        public virtual Entidad Entidad { get; set; }
        public virtual Acceso Acceso { get; set; }
        public virtual Contacto Contacto { get; set; }
    }
}
