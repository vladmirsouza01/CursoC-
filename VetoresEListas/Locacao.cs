using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresEListas
{
    class Locacao
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Locacao(string nome, int quarto)
        {
            Nome = nome;
            Quarto = quarto;
        }

        public Locacao(string nome, string email, int quarto): this( nome, quarto)
        {
            Email = Email;
        }

    }
}
