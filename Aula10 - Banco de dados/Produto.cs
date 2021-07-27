using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPT10___Banco_de_dados
{
    class Produto
    {
        public string Nome { get; set; }
        public int Preco { get; set; }

        public Produto(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
