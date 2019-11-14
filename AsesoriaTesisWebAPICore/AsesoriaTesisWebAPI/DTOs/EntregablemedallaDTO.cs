using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntregablemedallaDTO
    {
        public int EntregableMedallaId { get; set; }
        public int EntregableId { get; set; }
        public int MedallaId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual EntregableDTO EntregableRelacional { get; set; }
        public virtual MedallaDTO MedallaRelacional { get; set; }
    }
}
