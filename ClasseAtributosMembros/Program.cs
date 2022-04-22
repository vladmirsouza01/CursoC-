using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAtributosMembros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo");
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do segundo triangulo");

            y.a = double.Parse(Console.ReadLine());
            y.b = double.Parse(Console.ReadLine());
            y.c = double.Parse(Console.ReadLine());

            double trianguloX = x.CalculaArea();
            double trianguloY = y.CalculaArea();

            if(trianguloX > trianguloY)
            {
                Console.WriteLine($"o maior triangulo é o primeiro com valor de {trianguloX} e o outro é {trianguloY}");
            }
            else
            {
                Console.WriteLine($"o maior triangulo é o segundo com valor de {trianguloY} e o outro é {trianguloX}");
            }

            Console.ReadKey();
            
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto();
            p.Preco = preco;
            p.Nome = nome;
            p.Quantidade = qtd;

            //Console.WriteLine($"Dados do produto: {p.Nome}, {p.Preco}, {p.Quantidade} unidades, {p.Total()}");
            Console.WriteLine(p.ToString());

            Console.WriteLine("Informe a quantidade de produtos a ser acrescentada: ");
            p.AdicionarProduto(int.Parse(Console.ReadLine()));

            Console.WriteLine(p.ToString());
            Console.ReadKey();
            */

            Console.Write("Qual a cotação do dolar: ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar: ");
            double qtd = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais é {ValorPagoReais(dolar, qtd)}");
            Console.ReadKey();
        }


        public double CalculaArea(double x1, double x2, double x3)
        {
            double p = (x1 + x2 + x3) / 2;
            double area = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
            return area;
        }

        static double ValorPagoReais(double dolar, double qtdDolar)
        {
            return dolar * qtdDolar;
        }
    }

}
