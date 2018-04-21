using System;

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
