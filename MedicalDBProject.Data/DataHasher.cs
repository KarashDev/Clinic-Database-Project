using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace MedicalDBProject.Data
{
    public static class DataHasher
    {
        //Метод хэширования алгоритмом MD5 (Message Digest 5)
        public static string GetHashMd5(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
