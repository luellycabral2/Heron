using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double perimetro, área;

            Console.Write("Digite o valor de A :");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C : ");
            c = double.Parse(Console.ReadLine());

            perimetro = (a + b + c)/2;
            área = Math.Sqrt(perimetro * (perimetro - a ) * (perimetro - b) * (perimetro - c));
            Console.WriteLine("Semiperimetro é igual {0}" , perimetro);
            Console.WriteLine("área é igual {0}" , área);

            Console.WriteLine(" click a tecla ENTER para sair");
            Console.ReadKey();
            

        }
    }
}
