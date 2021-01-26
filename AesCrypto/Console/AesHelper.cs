using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Console
{
    public static class AesHelper
    {
        private const string IV = "2wDwCbJtSVuTlXhL";
        private const string KEY = "OZMd2MfM6YuoFNLXM50FpJdjX0R926GF";

        public static string Encrypt(this string data)
        {
            byte[] buffer = null;

            Aes aes = Aes.Create();
            aes.IV = Encoding.UTF8.GetBytes(IV);
            aes.Key = Encoding.UTF8.GetBytes(KEY);

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(data);
                    }
                }
                buffer = ms.ToArray();
            }
            return Convert.ToB