using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            int c = a++ + b--;

            ++a;
            --b;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
