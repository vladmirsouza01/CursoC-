using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new Excecoes("Data do checkIn não pode ser maior que a do checkOut");
            }
            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public TimeSpan Duracao()
        {
            TimeSpan calculaTempo = CheckOut - CheckIn;
            int dias = (int)calculaTempo.TotalDays;
            return calculaTempo;
        }

        public void AlteraDatas(DateTime checkIn, DateTime checkOut)
        {
            DateTime agora = DateTime.Now;
            if (checkIn < agora || checkOut < agora)
            {
                throw new Excecoes ("A reserva deve ter data futura");
            }
            if (checkIn > checkOut)
            {
                throw new Excecoes("A data do check tem que ser menor que a do checkOut");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Quarto {NumeroQuarto} data da entrada {CheckIn} data da saida {CheckOut} e tempo {Duracao()}";
        }
    }
}
