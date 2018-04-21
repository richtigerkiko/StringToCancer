using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCancerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insert uncancerous string:");
                Console.WriteLine(StringToCancerFunc.Create(Console.ReadLine()));
            }
        }
    }
}
