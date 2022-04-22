using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca3Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> listForma = new List<Forma>();

            Console.Write("Entre com a quantidade de formas: ");
            int qtdFormas = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdFormas; i++)
            {
                int qtd = i + 1;
                Console.WriteLine($"Informação forma {qtd}");

                Console.Write("Retangulo ou Circulo (r/c): ");
                char forma = char.Parse(Console.ReadLine());

                if ('c' == forma)
                {
                    Console.Write("Informe o Raio: ");
                    double raio = double.Parse(Console.ReadLine());

                    listForma.Add(new Circulo(raio));
                }
                else
                {
                    Console.Write("Informe a altura: ");
                    double alt = double.Parse(Console.ReadLine());

                    Console.Write("Informe a Largura: ");
                    double larg = double.Parse(Console.ReadLine());

                    listForma.Add(new Retangulo(larg, alt));
                }
            }
            foreach (var item in listForma)
            {
                if (item is Circulo)
                {
                    Console.WriteLine($"Circulo: {item.area()}");
                }
                else
                {
                    Console.WriteLine($"Retangulo: {item.area()}");
                }

                
            }
            Console.ReadKey();
        }
    }
}
