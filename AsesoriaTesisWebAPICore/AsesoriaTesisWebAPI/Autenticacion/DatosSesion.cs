using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Autenticacion
{
    /// <summary>
    /// Clase que contiene los datos de la sesion
    /// </summary>
    public class DatosSesion
    {
        /// <summary>
        /// Codigo institucional del usuario logueado
        /// </summary>
        public string CodigoInstitucional { get; set; }
        /// <summary>
        /// Nombre del usuario logueado
        /// </summary>
        public string NombreUsuario { get; set; }
        /// <summary>
        /// Apellido del usuario logueado
        /// </summary>
        public string ApellidoUsuario { get; set; }
        /// <summary>
        /// Rol del usuario logueado
        /// </summary>
        public int Rol { get; set; }
    }
}
