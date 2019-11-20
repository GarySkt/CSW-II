using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Entregable
    {
        public Entregable()
        {
            EntregableHistoria = new HashSet<EntregableHistoria>();
            EntregableMedalla = new HashSet<EntregableMedalla>();
        }

        public int EntregableId { get; set; }
        public int ActividadId { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public int NumeroOrden { get; set; }
        public DateTime FechaAprobado { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual ICollection<EntregableHistoria> EntregableHistoria { get; set; }
        public virtual ICollection<EntregableMedalla> EntregableMedalla { get; set; }
    }
}
