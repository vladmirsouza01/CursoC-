using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta co = new Conta(1001, "Alex", 0.0);
            ContaEmpresa ce = new ContaEmpresa(8010, "Vladmir", 2000, 10000);
            //upcasting pode, mas não funcionará propriedades da conta empresa ou conta poupanca a não ser que seja feito um downcasting
            Conta cont1 = new ContaEmpresa(1003, "Bob", 1000, 5000);
            Conta cont2 = new ContaPoupanca(520, "Jose", 0, 00.4);

            //cont1.emprestimo(1000);ele não aceita o emprestimo da conta empresa, pois está considerando uma conta comum
            ContaEmpresa cont5 = (ContaEmpresa)cont1;//downcasting para poder usar a funcao emprestimo
            cont5.Emprestimo(200);


            //nao pode downcasting
            //ContaEmpresa ce2 = new Conta();

            if(cont1 is ContaEmpresa)
            {
                ContaEmpresa cont3 = (ContaEmpresa)cont1; // contaEmpresa cont3 = cont1 as contaEmpresa
                Console.WriteLine($"{cont3.NumeroConta}  {cont3.Titular} {cont3.Saldo}  {cont3.LimiteEmprestimo}");
            }

            Conta co1 = new Conta(10, "Andre", 500);
            ContaPoupanca cp = new ContaPoupanca(20, "Jose", 1000, 0.02);
            co1.Saque(100);
            cp.Saque(100);
            Console.WriteLine(co1.Titular + " " + co1.Saldo);
            Console.WriteLine(cp.Titular + " " + cp.Saldo);

            Console.ReadKey();
        }
    }
}
