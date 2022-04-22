using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2 
{
    class Terceirizado : Empregado
    {
        public double DespesaAdicional { get; set; }

        public Terceirizado(string nome, int horas, double valorPorHoras, double despesaAdicional) : base(nome, horas, valorPorHoras)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return (ValorPorHoras * Horas) + (DespesaAdicional * 110) / 100;
        }
    }
}
