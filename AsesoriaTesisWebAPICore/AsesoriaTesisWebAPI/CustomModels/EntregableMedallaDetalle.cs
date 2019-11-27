using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class EntregableMedallaDetalle
    {
        public int EntregableMedallaID { get; set; }
        public int EntregableID { get; set; }
        public DateTime EntregableMedallaFecha { get; set; }
        public int MedallaId { get; set; }
        public string MedallaNombre { get; set; }
        public string MedallaImagenUrl { get; set; }
        public string MedallaDescripcion { get; set; }
        public int MedallaTipoId { get; set; }
        public string MedallaTipoNombre { get; set; }
        public string MedallaTipoDescripcion { get; set; }


    }
}
