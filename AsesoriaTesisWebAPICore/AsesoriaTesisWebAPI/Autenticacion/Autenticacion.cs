using AsesoriaTesisWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.Autenticacion
{
    /// <summary>
    /// Clase que contiene la logica de autenticacion del usuario y creacion del token de acceso
    /// </summary>
    public class Autenticacion
    {
        /// <summary>
        /// Variable IConfiguration de solo lectura
        /// </summary>
        private readonly IConfiguration configuration;
        private PostDbContext contextoBaseDatos;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="configurationParameter">Configuration que contiene los datos
        /// de appsettings.json</param>
        public Autenticacion(IConfiguration configurationParameter)
        {
            configuration = configurationParameter;
            contextoBaseDatos = new PostDbContext();
        }
        /// <summary>
        /// Metodo que autentica el usuario con la base de datos
        /// </summary>
        /// <param name="usuario">Usuario</param>
        /// <param name="contrasena">Contraseña del usuario</param>
        /// <returns>Datos de inicio de sesion del usuario</returns>
        public async Task<DatosSesion> autenticarUsuarioAsync(string usuario, string contrasena)
        {
            //var sd = HelperMD5.darFormatoMD5AContrasenaUsuario(contrasena);
            var accesoUsuario = contextoBaseDatos.Acceso
                .Include(g => g.Entidad.Entidad.Rol)
                .Where(g => g.CodigoInstitucional.Equals(usuario) && 
                    g.Pass.Equals(HelperMD5.darFormatoMD5AContrasenaUsuario(contrasena)))
                .FirstOrDefault();
            return new DatosSesion()
            {
                CodigoInstitucional = accesoUsuario?.CodigoInstitucional ?? "",
                NombreUsuario = accesoUsuario?.Entidad?.Nombre ?? "",
                ApellidoUsuario = accesoUsuario?.Entidad?.Apellido ?? "",
                Rol = accesoUsuario?.Entidad?.Entidad?.Rol?.RolId ?? 0
            };
        }
        /// <summary>
        /// Metodo que genera el token de acceso para el usuario logueado
        /// </summary>
        /// <param name="usuarioInfo">Datos del usuario logueado</param>
        /// <returns>Token de acceso</returns>
        public string generarTokenJWT(DatosSesion usuarioInfo)
        {
            var jwtHeader = obtenerJWTHeader();
            var claimsSesion = obtenerClaimsSesion(usuarioInfo);
            var jwtPayload = obtnerJWTPayload(claimsSesion);

            var jwtSecurityToken = new JwtSecurityToken(jwtHeader,jwtPayload);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
            return token;
        }
        #region Metodos privados
        /// <summary>
        /// Metodo que obtiene el encabezado JWT para el token de acceso
        /// </summary>
        /// <returns>Encabezado JWT para el token de acceso</returns>
        private JwtHeader obtenerJWTHeader()
        {
            var llaveSeguridad = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:ClaveSecreta"])
                );
            var credencialFirmada = new SigningCredentials(
                    llaveSeguridad, SecurityAlgorithms.HmacSha256
                );
            var jwtHeader = new JwtHeader(credencialFirmada);
            return jwtHeader;
        }
        /// <summary>
        /// Metodo que obtiene los claims para el token de acceso
        /// </summary>
        /// <param name="datosSesionUsuario">Datos de sesion del usuario</param>
        /// <returns>Claims para el token de acceso</returns>
        private List<Claim> obtenerClaimsSesion(DatosSesion datosSesionUsuario)
        {
            var claimsSession = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("CodigoInstitucional", datosSesionUsuario.CodigoInstitucional),
                new Claim("NombreUsuario", datosSesionUsuario.NombreUsuario),
                new Claim("ApellidoUsuario", datosSesionUsuario.ApellidoUsuario),
                //new Claim(ClaimTypes.Role, datosSesionUsuario.Rol)
            };
            return claimsSession;
        }
        /// <summary>
        /// Metodo que obtiene el JWT Payload para el token de acceso
        /// </summary>
        /// <param name="claimsSesion">Claims del token de acceso</param>
        /// <returns>JWT Payload para el token de acceso</returns>
        private JwtPayload obtnerJWTPayload(List<Claim> claimsSesion)
        {
            return new JwtPayload(
                issuer: configuration["JWT:Issuer"],
                audience: configuration["JWT:Audiencia"],
                claims: claimsSesion,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(24)
            );
        }
        #endregion
    }
}
