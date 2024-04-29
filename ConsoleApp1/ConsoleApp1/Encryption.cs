using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Encryption
    {
        private static int _id;
        public static string Encrypt(string data)
        {
            return data + _id;
        }

        public static string Decrypt(string data) 
        {
            return data + _id;
        }

        static Encryption()
        {
            _id = new Random().Next(100,1000);
        }
    }
}
