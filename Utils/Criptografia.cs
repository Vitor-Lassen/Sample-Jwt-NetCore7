using System.Security.Cryptography;

namespace api_auth.Utils
{
    public static class Criptografia
    {
        static HashAlgorithm _algoritmo = SHA256.Create();

        public static string CriptografarSenha(string senha)
        {
            var encodedValue = System.Text.Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);
            return Convert.ToBase64String(encryptedPassword);

        }
    }
}