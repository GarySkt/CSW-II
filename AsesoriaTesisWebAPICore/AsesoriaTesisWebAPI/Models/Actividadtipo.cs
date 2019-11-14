using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Actividadtipo
    {
        public Actividadtipo()
        {
            Actividad = new HashSet<Actividad>();
        }

        public int ActividadTipoId { get; set; }
        public string Nombre { get; set; }
        public int CreditoRequerido { get; set; }

        public ICollection<Actividad> Actividad { get; set; }
    }
}
