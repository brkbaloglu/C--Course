using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Muhendis : Calisan
    {
        public Muhendis() 
        {
            Unvan = "Muhendis";
        }

        public override double MaasHesapla()
        {
            return 4400;
        }
    }
}
