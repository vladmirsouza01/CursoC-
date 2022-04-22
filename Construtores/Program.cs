using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qtd);
            //p.Preco = preco;
            //p._nome = nome;
            //p._quantidade = qtd;

            //Console.WriteLine($"Dados do produto: {p._nome}, {p.Preco}, {p._quantidade} unidades, {p.Total()}");
            Console.WriteLine(p.ToString());

            Console.WriteLine("Informe a quantidade de produtos a ser acrescentada: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine(p.ToString());

            Console.ReadKey();
            

            Produto p = new Produto("TV", 500);
            Console.WriteLine(p.getNome());
            p.setNome("tv 4k");
            Console.WriteLine(p.ToString());
            Console.ReadKey();

            */
            Conta c;
            Console.WriteLine("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial: ");
            char resp = char.Parse(Console.ReadLine());
            double saldo;

            if(resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito: ");
                saldo = double.Parse(Console.ReadLine());
                c = new Conta(numConta, titular, saldo);
            }
            else
            {
                c = new Conta(numConta, titular);
            }

            Console.WriteLine(c.ToString());

            Console.WriteLine("-------------------------------------");

            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            c.Depositar(deposito);
            Console.WriteLine(c.ToString());

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            c.sacar(saque);
            Console.WriteLine(c.ToString());
            Console.ReadKey();

        }
    }
}
