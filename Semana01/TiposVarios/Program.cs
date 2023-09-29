using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Variáveis Inteiras.
            int numero = 23;
            uint i = 4U;
            ulong d = 7UL;
            long c = 2L;

            //Variáveis Reais.
            float n1 = 7f;
            double n2 = 22;
            decimal n3 = 44m;

            //Variáveis Char.
            char jett = '\u00DF';

            //Variáveis Bool.
            bool condition = 5 < 3;

            Console.WriteLine(numero);
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(jett);

            if(!condition) Console.WriteLine(condition);
        }
    }
}
