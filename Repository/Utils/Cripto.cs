using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Utils
{
    public static class Cripto
    {
        public static string Criptografar(string Message)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes("LbrtsCgj"));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider
            {
                Key = TDESKey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            return Convert.ToBase64String(Results);
        }
    }
}
