using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public virtual void CalculaPreco()
        {
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Tipo: {0}", Tipo);            
        }
    }
    class Mouse : Produto
    {
        public int Dpi { get; set; }
        public string Modelo { get; set; }
        public override void CalculaPreco()
        {
            Preco = (Preco * 2.3) + Dpi;
            base.CalculaPreco();
            Console.WriteLine("Dpi: " + Dpi);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Preço do mouse: {0:c}", Preco);
        }
    }
    class Livro : Produto
    {
        public string Autor { get; set; }
        public string Estilo { get; set; }
        public override void CalculaPreco()
        {
            Preco *= 1.55;
            base.CalculaPreco();
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Estilo: " + Estilo);
            Console.WriteLine("Preço do livro: {0:c}", Preco);
        }
    }
}
