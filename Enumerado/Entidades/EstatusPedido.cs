using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerado.Entidades
{
    enum EstatusPedido : int
    {
        PagamentoPedente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
