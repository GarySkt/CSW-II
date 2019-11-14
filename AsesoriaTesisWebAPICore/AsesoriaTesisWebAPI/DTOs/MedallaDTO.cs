using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class MedallaDTO
    {
        /*public MedallaDTO()
        {
            EntregablemedallaRelacional = new HashSet<EntregablemedallaDTO>();
        }*/
        public int MedallaId { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public int MedallaTipoId { get; set; }
        public string Descripcion { get; set; }

        public MedallaTipoDTO MedallaTipoRelacional { get; set; }
        //public ICollection<EntregablemedallaDTO> EntregablemedallaRelacional { get; set; }
    }
}
