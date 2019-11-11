using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Ciclo
    {
        public Ciclo()
        {
            Entidadciclo = new HashSet<Entidadciclo>();
        }

        public int CicloId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        public virtual ICollection<Entidadciclo> Entidadciclo { get; set; }
    }
}
