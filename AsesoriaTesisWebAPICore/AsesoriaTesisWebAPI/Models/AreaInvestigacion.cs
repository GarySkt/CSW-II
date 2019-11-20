using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class AreaInvestigacion
    {
        public AreaInvestigacion()
        {
            LineaInvestigacion = new HashSet<LineaInvestigacion>();
        }

        public int AreaInvestigacionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<LineaInvestigacion> LineaInvestigacion { get; set; }
    }
}
