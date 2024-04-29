using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductCode{ get; set; }
        public string ProductName{ get; set; }
        public double Price{ get; set; }

        public Product()
        {

        }
        public Product(int productID, string productCode, string productName, double price)
        {
            this.ProductID = productID;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }


        
    }
}
