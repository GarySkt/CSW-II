using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class ActividadtipoDTO
    {
        public ActividadtipoDTO()
        {
            ActividadRelacional = new HashSet<ActividadDTO>();
        }
        public int ActividadTipoId { get; set; }
        public string Nombre { get; set; }
        public int CreditoRequerido { get; set; }

        public ICollection<ActividadDTO> ActividadRelacional { get; set; }
    }
}
