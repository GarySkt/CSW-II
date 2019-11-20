using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class EntidadCiclo
    {
        public int EntidadCicloId { get; set; }
        public int EntidadId { get; set; }
        public int CicloId { get; set; }

        public virtual Ciclo Ciclo { get; set; }
        public virtual Entidad Entidad { get; set; }
    }
}
