using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Business
{
    internal class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public Shipper()
        {

        }

        public Shipper(int shipperID, string companyName, string phone)
        {
            this.ShipperID = shipperID;
            this.CompanyName = companyName;
            this.Phone = phone;
        }
    }

}
