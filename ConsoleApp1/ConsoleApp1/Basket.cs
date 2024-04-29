using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Basket
    {
        private List<Product> products = new List<Product>();   

        public void Add(Product newProduct)
        {
            if (newProduct != null)
            {
                products.Add(newProduct);
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
        public List<Product> GetProducts() 
        {
            return products;
        }
    }
}
