using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class People
    {
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }


        public string getEmail(int peopleId)
        {
            string result = string.Empty;

            if (peopleId > 0)
            {
                result = this.email;
            }
            else
            {
                result = "E-mail is not found";
            }
            return result;
        }
    }
}
