using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Entidad = new HashSet<Entidad>();
        }

        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
