using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //private double _preco;
        //private int _quantidade;

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        /*
        public double Preco
        {
            get
            {
                return Preco;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }
        */

        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }

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
            return ($"Dados do produto: {_nome}, {Preco}, {Quantidade} unidades, {Total()}");
        }
    }
}
