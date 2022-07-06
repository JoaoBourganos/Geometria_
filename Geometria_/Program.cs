using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area2, base2, altura2, area3, base3maior, base3menor, altura3, pi, raio, area1;
            int forma;
            Console.WriteLine("FORMAS GEOMÉTRICAS");
            Console.WriteLine("1-Círculo \n2-Triângulo \n3-Trapézio");
            Console.WriteLine();
            Console.WriteLine("Digite o código da figura geométrica:");
            forma = Convert.ToInt32(Console.ReadLine());
            pi = 3.14159265359;
            switch (forma)
            {
                case 1:
                    Console.WriteLine("Digite o raio em cm: ");
                    raio = Convert.ToInt32(Console.ReadLine());
                    area1 = pi * (raio * raio);
                    Console.WriteLine("Área do círculo: " + area1 + "cm");
                    break;
                case 2:
                    Console.WriteLine("Digite a base em cm: ");
                    base2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a altura em cm: ");
                    altura2 = Convert.ToInt32(Console.ReadLine());
                    area2 = (base2 * altura2) / 2;
                    Console.WriteLine("Área do Triângulo: " + area2 + "cm");
                    break;
                case 3:
                    Console.WriteLine("Digite a base menor em cm: ");
                    base3menor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a base maior em cm: ");
                    base3maior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a altura em cm: ");
                    altura3 = Convert.ToInt32(Console.ReadLine());
                    area3 = ((base3maior + base3menor) * altura3) / 2;
                    Console.WriteLine("Área do Trapézio: " + area3 + "cm");
                    break;
            }
            Console.ReadKey();
        }
    }
}
