using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca3Abstrato
{
    abstract class Forma
    {
        public int Cor { get; set; }
        public abstract double area();
    }
}
