using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorAeB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, C;
            int a, b, c, d;
            Console.WriteLine("Qual o valor de A: ");
            A = Console.ReadLine();
            Console.WriteLine("Qual o valor de B: ");
            B = Console.ReadLine();

            C = A;
            A = B;
            B = C;

            Console.WriteLine("O valor de A é: " + A);
            Console.WriteLine("O valor de B é: " + B);
            Console.ReadKey();

            Console.WriteLine("Qual o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor de B: ");
            b = int.Parse(Console.ReadLine());

            c = (a + b) - a;
            d = (b + a) - b;

            Console.WriteLine("O valor de A é: " + c);
            Console.WriteLine("O valor de B é: " + d);
            Console.ReadKey();
        }
    }
}
