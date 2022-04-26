using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entidade
{
    class NotaPagamento
    {
        public double PagamentoBasico { get; set; }
        public double  Taxa { get; set; }

        public NotaPagamento(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get
            {
                return PagamentoBasico + Taxa;
            }
        }

        public override string ToString()
        {
            return "Pagamento Basico "
                + PagamentoBasico.ToString()
                + "\n Taxas "
                + Taxa.ToString()
                + "\n Total pagamento "
                + PagamentoTotal.ToString();

                
        }
    }
}
