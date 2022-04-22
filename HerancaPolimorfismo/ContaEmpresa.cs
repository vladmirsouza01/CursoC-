using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa(double limiteEmprestimo)
        {
            
        }

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valorEmprestimo)
        {
            if(valorEmprestimo <= LimiteEmprestimo)
            {
                Saldo = Saldo + valorEmprestimo;
            }
            else
            {
                Console.WriteLine("Valor extrapolou o limite de emprestimo");
            }
            
        }
    }
}
