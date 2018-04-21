using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCancerCSharp
{
    class StringToCancerFunc
    {
        public static string Create(string notCancerYet)
        {
            int i = 0;
            string cancerString = null;
            foreach (char c in notCancerYet)
            {
                if (char.IsWhiteSpace(c)) i++;
                if (i % 2 == 0) cancerString += c.ToString().ToUpper();
                else cancerString += c.ToString().ToLower();
                i++;
            }
            return cancerString;
        }
    }
}
