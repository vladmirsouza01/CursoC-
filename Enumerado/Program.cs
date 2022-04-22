using Enumerado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerado
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido ped = new Pedido();
            ped.Id = 1080;
            ped.Momento = DateTime.Now;
            ped.Status = EstatusPedido.PagamentoPedente;

            Console.WriteLine(ped);
            Console.ReadKey();
        }

    }
}
