using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAtributosMembros
{ 


    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public override string ToString()
        {
            return ($"Dados do produto: {Nome}, {Preco}, {Quantidade} unidades, {Total()}");
        }
    }
}
