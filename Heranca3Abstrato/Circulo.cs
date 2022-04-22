using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca3Abstrato
{
    class Circulo : Forma
    {
        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double Raio { get; set; }

        public override double area()
        {
            return Math.Pow(Raio, 2) * 3.14;
        }
    }
}
