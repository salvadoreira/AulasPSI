using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Variáveis String.
            string s = "\t \u2D39";
            Console.WriteLine(s);

            string b = @"C:\Users\Salvador\Documents";
            Console.WriteLine(b);
        }
    }
}
