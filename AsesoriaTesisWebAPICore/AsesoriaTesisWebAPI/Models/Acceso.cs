using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Acceso
    {
        public int EntidadId { get; set; }
        public string CodigoInstitucional { get; set; }
        public string Pass { get; set; }

        public virtual Persona Entidad { get; set; }
    }
}
