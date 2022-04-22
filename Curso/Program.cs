using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite o numero para verificar se é par ou impar: ");
            double teste = int.Parse(Console.ReadLine());

            double verifica = teste % 2;
            if(verifica == 0)
            {
                Console.WriteLine($"o numero {teste} e um par");
            }
            else
            {
                Console.WriteLine($"o numero {teste} e um impar");
            }

            Console.ReadKey();
            
            Console.WriteLine("Digite a hora: ");
            double teste = int.Parse(Console.ReadLine());

            if (teste < 12)
            {
                Console.WriteLine($"Bom dia");
            }
            else if (teste > 12 && teste < 18)
            {
                Console.WriteLine($"Bom tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.ReadKey();
            

            Console.WriteLine("Digite 3 numeros : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Maior(num1, num2, num3));

            Console.ReadKey();

            */


        }

        static int Maior(int numero1, int numero2, int numero3)
        {
            if (numero1 > numero2 && numero1 > numero3)
            {
                return numero1;
            }else if(numero2 > numero3)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }
    }
}
