using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Variáveis de Apoio.
            int x = 10, y  = 5, r = x + y;

            // Strings Simples e Literais.
            string s = "\t \u2D39";
            Console.WriteLine(s);

            string b = @"C:\Users\Salvador\Documents";
            Console.WriteLine(b);

            string f = "A Guiné não tem símbolo de copyright \u00A9";
            Console.WriteLine(f);

            // Strings Concatenadas.
            string bs = "Angola" + " melhor país" + "!";
            Console.WriteLine(bs);
            string sf = s + f + 2;
            Console.WriteLine(sf);

            // Strings Interpoladas.
            string bf = $"{s} interpolado";
            Console.WriteLine(bf);
            string fb = $@"{s} + {b} + {f} verbatim {x}";
            Console.WriteLine(fb);

            
        }
    }
}
