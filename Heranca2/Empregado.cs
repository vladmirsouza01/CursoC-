using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    class Empregado
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        public Empregado()
        {

        }

        public Empregado(string nome, int horas, double valorPorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHoras;
        }


    }
}
