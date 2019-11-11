using System.Security.Cryptography;
using System.Text;

namespace AsesoriaTesisWebAPI.Autenticacion
{
    /// <summary>
    /// Clase para el encriptado y desencriptado de la contraseña del usuario
    /// </summary>
    public class HelperMD5
    {
        /// <summary>
        /// Metodo que realiza el formateo a MD5 de la contraseña del usuario
        /// </summary>
        /// <param name="contrasenaUsuario">Contraseña del usuario</param>
        /// <returns>Contraseña en formato MD5</returns>
        public static string darFormatoMD5AContrasenaUsuario(string contrasenaUsuario)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(contrasenaUsuario));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
