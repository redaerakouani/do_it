using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


    namespace do_it
{
    class hashing
    {

        public static string hash_passeword(string pswrd)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(pswrd);
            byte[] encrepted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrepted_bytes);
        }
    }
}
