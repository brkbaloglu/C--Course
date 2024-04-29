using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad{ get; set; }
        public string Unvan{ get; set; }

        public abstract double MaasHesapla();


        public override string ToString()
        {
            //return base.ToString();
            return this.Ad + " " + this.Soyad;
        }
    }
}
