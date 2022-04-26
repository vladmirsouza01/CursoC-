using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entidade
{
    class AluguelCarro
    {
        public DateTime Comeco { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; set; }
        public NotaPagamento NotaPagamento { get; set; }

        public AluguelCarro(DateTime comeco, DateTime final, Veiculo veiculo)
        {
            Comeco = comeco;
            Final = final;
            Veiculo = veiculo;
        }
    }
}
