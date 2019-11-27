namespace AsesoriaTesisWebAPI.Autenticacion
{
    public class LoginRespuesta
    {
        public string token { get; set; }
        public int rolId { get; set; }
        public int entidadId { get; set; }
        
        public string nombreEntidad { get; set; }
        public string apellidoEntidad { get; set; }
    }
}