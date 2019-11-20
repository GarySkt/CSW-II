using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Configuracion
    {
        public int ConfiguracionId { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
    }
}
