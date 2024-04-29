using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kullanici2
    {
        public static int ID { get; set; }
        public string Ad { get; set; }
        public int PrivateID{ get; set; }

        public Kullanici2()
        {
            ID += 1;
            PrivateID = ID;
        }

        public int getID()
        {
            return Kullanici2.ID;
        }

    }
}
