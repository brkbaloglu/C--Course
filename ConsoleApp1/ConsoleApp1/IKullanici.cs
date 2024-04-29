using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IKullanici
    {
        void Ekle(string kullaniciAdi, string email, string sifre);
        void Guncelle(int kullaniciID, string kullaniciAdi, string email, string sifre);
        void Sil(int kullaniciID);

        KullaniciInfo GetKullaniciInfo(int kullaniciID);

        List<KullaniciInfo> kullanicilariGetir();

        void Aktiflestir(int kullaniciID);
        void Pasiflestir(int kullaniciID);
        bool Giris(string email, string sifre);
    }
}
