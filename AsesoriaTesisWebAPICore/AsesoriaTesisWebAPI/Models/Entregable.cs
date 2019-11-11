using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Entregable
    {
        public Entregable()
        {
            Entregablehistoria = new HashSet<Entregablehistoria>();
            Entregablemedalla = new HashSet<Entregablemedalla>();
        }

        public int EntregableId { get; set; }
        public int ActividadId { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public int NumeroOrden { get; set; }
        public DateTime FechaAprobado { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual ICollection<Entregablehistoria> Entregablehistoria { get; set; }
        public virtual ICollection<Entregablemedalla> Entregablemedalla { get; set; }
    }
}
