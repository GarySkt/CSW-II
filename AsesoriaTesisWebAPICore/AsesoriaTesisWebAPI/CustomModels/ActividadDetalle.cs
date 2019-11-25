using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class ActividadDetalle
    {
        public int ActividadId { get; set; }        
        public int Finalizada { get; set; }
        public int AlumnoId { get; set; }
        public int CreditoAprobado { get; set; }
        public int AlumnoEntidadID { get; set; }        
        public int AlumnoEntidadActivo { get; set; }
        public string AlumnoNombre { get; set; }
        public string AlumnoApellido { get; set; }
        public string ActividadTitulo { get; set; }
        public string ActividadResumen { get; set; }
        public string ActividadDescripcion { get; set; }
        public int AsesorId { get; set; }
        public int DocenteID { get; set; }
        public string DocenteTitulo { get; set; }
        public int DocenteEntidadID { get; set; }        
        public int DocenteEntidadActivo { get; set; }
        public string DocenteNombre { get; set; }
        public string DocenteApellido { get; set; }
        public int ActividadTipoId { get; set; }
        public string ActividadNombreTipo { get; set; }
    }
}
