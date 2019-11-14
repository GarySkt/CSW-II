using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntregableDTO
    {
        /*public EntregableDTO()
        {
            EntregablehistoriaRelacional = new HashSet<EntregablehistoriaDTO>();
            EntregablemedallaRelacional = new HashSet<EntregablemedallaDTO>();
        }*/
        public int EntregableId { get; set; }
        public int ActividadId { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public int NumeroOrden { get; set; }
        public DateTime FechaAprobado { get; set; }

        public ActividadDTO ActividadRelacional { get; set; }
        public EntregablehistoriaDTO EntregablehistoriaRelacional { get; set; }
        public EntregablemedallaDTO EntregablemedallaRelacional { get; set; }
    }

}
