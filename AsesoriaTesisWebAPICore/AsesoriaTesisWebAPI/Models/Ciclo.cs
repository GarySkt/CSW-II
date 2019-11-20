using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Ciclo
    {
        public Ciclo()
        {
            EntidadCiclo = new HashSet<EntidadCiclo>();
        }

        public int CicloId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        public virtual ICollection<EntidadCiclo> EntidadCiclo { get; set; }
    }
}
