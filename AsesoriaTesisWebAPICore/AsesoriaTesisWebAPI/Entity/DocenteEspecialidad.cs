using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.Entity
{
    public class DocenteEspecialidad
    {
        public int DocenteID { get; set; }
        public string DocenteNombre { get; set; }
        public string DocenteApellido { get; set; }
        public int EscuelaID { get; set; }
        public string EscuelaNombre { get; set; }
        public int EspecialidadID { get; set; }
        public string EspecialidadNombre { get; set; }
        public string EspecialidadDescripcion { get; set; }
    }
}
