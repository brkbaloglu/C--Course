using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kullanici : IKullanici, IYetki
    {
        public int YetkiID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int KullaniciID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Aktiflestir(int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public void Ata(int kullaniciID, int yetkiID)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAdi, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo GetKullaniciInfo(int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciID, string kullaniciAdi, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciID, int yetkiID)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> kullanicilariGetir()
        {
            throw new NotImplementedException();
        }

        public void Pasiflestir(int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciID)
        {
            throw new NotImplementedException();
        }
    }
}
