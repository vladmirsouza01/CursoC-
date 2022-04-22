using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> emp = new List<Empregado>();

            Console.Write("Entre com o numero de empregados: ");
            int numEmpregados = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numEmpregados; i++)
            {
                int inc = i + 1;
                Console.WriteLine("Empregado numero " + inc);
                Console.Write("Terceirizado (s/n): ");
                char terc = char.Parse(Console.ReadLine());
                if (terc == 's')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Valor por horas: ");
                    double valorPorHoras = double.Parse(Console.ReadLine());

                    Console.Write("Adicional: ");
                    double adicional = double.Parse(Console.ReadLine());

                    emp.Add(new Terceirizado(nome, horas, valorPorHoras, adicional));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Valor por horas: ");
                    double valorPorHoras = double.Parse(Console.ReadLine());

                    emp.Add(new Empregado(nome, horas, valorPorHoras));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos:");

            foreach (var listaEmp in emp)
            {
                Console.WriteLine(listaEmp.Nome + " " + listaEmp.Pagamento());
            }

            Console.ReadKey();
        }
    }
}
