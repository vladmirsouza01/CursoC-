using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro! " + e.Message);
            }
            Console.ReadKey();
            */
            try
            {
                Console.Write("Entre com o quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Entre com a data do chekin: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Entre com a data do chekout: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reserva reser = new Reserva(quarto, checkin, checkout);

                Console.WriteLine(reser.ToString());


                Console.Write("Entre com a nova data do chekin: ");
                DateTime novoCheckin = DateTime.Parse(Console.ReadLine());
                Console.Write("Entre com a nova data do chekout: ");
                DateTime novoCheckout = DateTime.Parse(Console.ReadLine());
                reser.AlteraDatas(novoCheckin, novoCheckout);

                Console.WriteLine(reser.ToString());
                
            }
            catch (Excecoes e)
            {

                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
