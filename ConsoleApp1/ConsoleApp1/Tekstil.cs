using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum TekstilMarka
    {
        Kigili = 1,
        Beymen = 2,
        PierreCarden = 3,
        AltinYildiz = 4,
        Polo = 5
    }
    internal class Tekstil:Product
    {
        public string Tur { get; set; }
        public int Beden { get; set; }
        public string Uretici{ get; set; }
        public TekstilMarka Marka{ get; set; }

        public static List<Tekstil> SearchByBrand(TekstilMarka marka)
        {
             
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil() 
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen,
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TekstilMarka.AltinYildiz,
            });

            List<Tekstil> returnProducts = new List<Tekstil>();
            foreach (var tekstil in textileProducts)
            {
                if (tekstil.Marka == marka)
                {
                    returnProducts.Add(tekstil);
                }
            }
            return returnProducts;
        }

        public static List<Tekstil> SearchByName(string marka) 
        {
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen,
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TekstilMarka.AltinYildiz,
            });

            List<Tekstil> returnProducts = new List<Tekstil>();

            foreach (var tekstil in textileProducts)
            {
                if (tekstil.ProductName.Contains(marka))
                {
                    returnProducts.Add(tekstil);
                }
            }

            return returnProducts;
        }

    }
}
