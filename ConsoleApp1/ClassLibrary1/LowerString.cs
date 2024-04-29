using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class LowerString : IPlugin
    {
        public string action(string text)
        {
            return text.ToLower();
        }

        public string name()
        {
            return "Küçük Harf";

        }
    }
}
