using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum BreadType
    {
        Beyaz = 1,
        Kepek = 2,
        Bugday = 3,
        Odun = 4,
        AltinEkmek = 5
    }
    public enum Gramaj
    {
        Yuz = 100,
        YuzYirmiBes = 125,
        IkiYuz = 200,
    }
    internal class Ekmek : Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gramaj { get; set; }
        public string Uretici { get; set; }
        public Ekmek(int productID, double Price, BreadType type)
        {
            switch(type) 
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gramaj = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = 1.5;
                    this.Gramaj = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
        public Ekmek(BreadType type)
        {
            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = 1.0;
                    this.Gramaj = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gramaj = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = 1.5;
                    this.Gramaj = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
    }
}
