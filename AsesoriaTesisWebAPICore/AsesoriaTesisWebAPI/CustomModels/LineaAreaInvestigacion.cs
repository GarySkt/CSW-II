using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class LineaAreaInvestigacion
    {
        public int LineaInvestigacionId { get; set; }
        public string LineaInvestigacionNombre { get; set; } 
        public string LineaInvestigacionDescripcion { get; set; }
        public int AreaInvestigacionId { get; set; }
        public string AreaInvestigacionNombre { get; set; }
        public string AreaInvestigacionDescripcion { get; set; }
    }
}
