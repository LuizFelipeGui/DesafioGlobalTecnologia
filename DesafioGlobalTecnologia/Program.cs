using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGlobalTecnologia
{
    class Program
    {
        public static void Main(string[] args)
        {
            int variavel = 1;
            
            for (int i = 1; i <= 20; i++)
            {
                variavel *= i / Teste(variavel, i);
            }
            Console.WriteLine(variavel);
        }

        public static int Teste(int a, int b)
        {
            while (b > 0)
            {
                a %= b;
                if (a == 0)
                    return b;
                b %= a;
            }
            return a;
        }

    }

}
