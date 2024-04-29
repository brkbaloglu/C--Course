using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Isci : Calisan
    {
        public Isci() 
        {
            Unvan = "İşçi";
        }

        public override double MaasHesapla()
        {
            return 1.300;
        }
    }
}
