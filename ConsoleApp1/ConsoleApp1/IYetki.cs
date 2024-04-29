using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IYetki
    {
        int YetkiID { get; set; }
        int KullaniciID { get; set; }
        void Ata(int kullaniciID, int yetkiID);
        void Kaldir(int kullaniciID, int yetkiID);
    }
}
