using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class BiggerString : IPlugin
    {
        public string action(string text)
        {
            return text.ToUpper();
        }

        public string name()
        {
            return "Büyük Harf";
        }
    }
}
