using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.Autenticacion
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Variable Autenticacion
        /// </summary>
        private Autenticacion autenticacion;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="configuration">Configuration que contiene los datos
        /// de appsettings.json</param>
        public LoginController(IConfiguration configuration)
        {
            autenticacion = new Autenticacion(configuration);
        }
        /// <summary>
        /// Metodo que autentica al usuario para generar el token de acceso
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="contrasena">Contraseña del usaurio</param>
        /// <returns>Datos del usuario (incluido el token)</returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(
            string usuario,
            string contrasena
            )
        {
            var usuarioEncontrado = await autenticacion.autenticarUsuarioAsync(
                usuario, contrasena);
            if (!string.IsNullOrEmpty(usuarioEncontrado.CodigoInstitucional))
            {
                return Ok(new { token = autenticacion.generarTokenJWT(
                    usuarioEncontrado) });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}