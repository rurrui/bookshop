using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace shop.Common.DEncrypt
{
    public partial class MD5Encrypt
    {
        public static string EncryptString(string str)
        {
            byte[] by = Encoding.Unicode.GetBytes(str);
            MD5 md5 = MD5.Create();
            byte[] by2 = md5.ComputeHash(by);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < by2.Length; i++)
            {
                sb.Append(by2[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
