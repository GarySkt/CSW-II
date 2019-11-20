using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class DocenteLineaInvestigacion
    {
        public int DocenteID { get; set; }
        public string DocenteNombre { get; set; }
        public string DocenteApellido { get; set; }
        public int EscuelaID { get; set; }
        public string EscuelaNombre { get; set; }
        public int LineaInvestigacionID { get; set; }
        public string LineaNombre { get; set; }
        public string LineaDescripcion { get; set; }
    }
}
