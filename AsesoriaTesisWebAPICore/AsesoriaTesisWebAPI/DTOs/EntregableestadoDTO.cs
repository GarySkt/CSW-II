using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntregableestadoDTO
    {
        public EntregableestadoDTO()
        {
            EntregablehistoriaRelacional = new HashSet<EntregablehistoriaDTO>();
        }

        public int EntregableEstadoId { get; set; }
        public string DocumentoUrl { get; set; }
        public DateTime Fecha { get; set; }
        public string ComentarioAlumno { get; set; }
        public string ComentarioDocente { get; set; }
        public int Estado { get; set; }

        public ICollection<EntregablehistoriaDTO> EntregablehistoriaRelacional { get; set; }
    }
}
