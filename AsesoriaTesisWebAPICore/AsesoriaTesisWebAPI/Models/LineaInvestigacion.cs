using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class LineaInvestigacion
    {
        public LineaInvestigacion()
        {
            LineaInvestigacionDocente = new HashSet<LineaInvestigacionDocente>();
        }

        public int LineaInvestigacionId { get; set; }
        public string Nombre { get; set; }
        public int AreaInvestigacionId { get; set; }
        public string Descripcion { get; set; }

        public virtual AreaInvestigacion AreaInvestigacion { get; set; }
        public virtual ICollection<LineaInvestigacionDocente> LineaInvestigacionDocente { get; set; }
    }
}
