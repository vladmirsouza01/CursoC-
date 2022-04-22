using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }
        public Conta(int numero, string titular, double saldo)
        {
            NumeroConta = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque (double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public void Deposito (double valor)
        {
            Saldo = Saldo + valor;
        }
    }
}
