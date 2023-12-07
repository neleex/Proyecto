using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Seguridad.Hash
{
    public static class Hash
    {
        public static byte[] Genera(string CadenaTexto)
        {
            byte[] hashValue = null;
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(CadenaTexto));
                }
                catch (Exception ex)
                {
                    hashValue = null;
                }
                return hashValue;
            }
        }
    }

}
