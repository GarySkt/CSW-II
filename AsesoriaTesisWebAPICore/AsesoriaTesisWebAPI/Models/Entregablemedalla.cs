using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class EntregableMedalla
    {
        public int EntregableMedallaId { get; set; }
        public int EntregableId { get; set; }
        public int MedallaId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Entregable Entregable { get; set; }
        public virtual Medalla Medalla { get; set; }
    }
}
