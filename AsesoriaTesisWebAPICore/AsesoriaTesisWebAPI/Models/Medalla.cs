using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Medalla
    {
        public Medalla()
        {
            EntregableMedalla = new HashSet<EntregableMedalla>();
        }

        public int MedallaId { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public int MedallaTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual MedallaTipo MedallaTipo { get; set; }
        public virtual ICollection<EntregableMedalla> EntregableMedalla { get; set; }
    }
}
