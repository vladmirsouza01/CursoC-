using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerado.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public EstatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id + " " + Momento + " " + Status;
        }
    }
}
