
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Digite um número inteiro:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro:");
            e = int.Parse(Console.ReadLine());

            int maior = a;
            int menor = a;

            if (b > maior)
                maior = b;
            else if (b < menor)
                menor = b;

            if (c > maior)
                maior = c;
            else if (c < menor)
                menor = c;

            if (d > maior)
                maior = d;
            else if (d < menor)
                menor = d;

            if (e > maior)
                maior = e;
            else if (e < menor)
                menor = e;

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();
        }
    }
}
