using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class EntregableDetalle
    {
        public int EntregableId { get; set; }
        public int ActividadId { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public int NumeroOrden { get; set; }
        public int EntregableHistoriaId { get; set; }

        public int EntregableEstadoId { get; set; }
        public string EntregableDocumentoURL { get; set; }
        public DateTime EstadoFecha { get; set; }
        public string ComentarioAlumno { get; set; }
        public string ComentarioAsesor { get; set; }
        public int EntregableEstado { get; set; }

        public int EntregableMedallaId { get; set; }
        public int MedallaId { get; set; }
        public string MedallaNombre { get; set; }
        public string MedallaImagenURL { get; set; }

    }
}
