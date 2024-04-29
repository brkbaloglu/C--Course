using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Database
{
    internal class Database
    {
        public static string getConnectionString
        {
            get { return "Data Source=.;Initial Catalog=NORTHWND;Uid=sa;Pwd=1234567"; }
        }
    }
}
