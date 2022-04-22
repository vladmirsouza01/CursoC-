using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresEListas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Informe a quantidade de alturas a ser medidas: ");
            int qtd = int.Parse(Console.ReadLine());
            double[] vetAltura = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Informe a altura: ");
                vetAltura[i] = double.Parse(Console.ReadLine());
            }
            double soma = 0;
            for (int i = 0; i < vetAltura.Length; i++)
            {
                soma = soma + vetAltura[i];
            }
            Console.WriteLine($"A media das alturas é {soma/qtd}");
            Console.ReadKey();
            

            int n = int.Parse(Console.ReadLine());
            Produto[] vetorProdutos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vetorProdutos[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma = soma + vetorProdutos[i].Preco;
            }

            Console.WriteLine($"Preco medio é de {soma /n}");

            Console.ReadKey();

            
            string nome;
            string email;
            int quarto;
            int qtdQuartos = 10;
            
            Console.Write("Quantos quartos serão locados: ");
            int qtdLocacao = int.Parse(Console.ReadLine());
            Locacao[] vetLocacao = new Locacao[qtdQuartos];
            for (int i = 0; i < qtdLocacao; i++)
            {
                Console.Write("Informe o nome: ");
                nome = Console.ReadLine();
                Console.Write("Informe o email: ");
                email = Console.ReadLine();
                Console.Write("Informe o quarto: ");
                quarto = int.Parse(Console.ReadLine());
                vetLocacao[quarto] = new Locacao(nome, email, quarto);
            }

            //for (int i = 0; i < qtdQuartos; i++)
            //{
            //  if (vetLocacao[i] != null)
            //{
            //  Console.WriteLine(vetLocacao[i].Nome + " " + vetLocacao[i].Email + " " + ////vetLocacao[i].Quarto);
            //}

            //}
            foreach (var item in vetLocacao)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Nome + " " + item.Email + " " + item.Quarto);
                }
            }
            Console.ReadKey();

    */
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("jorge");
            lista.Add("paulo");
            lista.Add("marcos");

            lista.Insert(1, "Vladmir");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            string busca = lista.Find(x => x[0] == 'j');
            Console.WriteLine(busca);

            int pos1 = lista.FindIndex(x => x[0] == 'm');
            Console.WriteLine(pos1);
            Console.ReadKey();
        }
    }
}
