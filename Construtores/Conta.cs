using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numConta, string nome)
        {
            NumConta = numConta;
            Titular = nome;
        }

        public Conta(int numConta, string nome, double saldo): this(numConta, nome)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void sacar(double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public override string ToString()
        {
            return $"Nome {Titular} numero conta {NumConta} e saldo {Saldo}";
        }
    }
}
