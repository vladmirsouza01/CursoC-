using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes 
{
    class Excecoes : ApplicationException
    {
        public Excecoes(string mensagem) : base(mensagem)
        {

        }
    }
}
