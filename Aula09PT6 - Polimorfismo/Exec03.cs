using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    //03
    class Cliente
    {
        public string Nome { get; set; }
        public double Dinheiro { get; set; }
        public Cliente(string nome, double dinheiro)
        {
            Nome = nome;
            Dinheiro = dinheiro;
        }
    }
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }

        public Imovel(string endereco, double preco)
        {
            Endereco = endereco;
            Preco = preco;
        }
        public virtual void CalculaValor()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Preço: " + Preco);
        }
    }
    class Novo : Imovel
    {
        public double PrecoAdicional { get; set; }
        public Novo(string endereco, double preco) : base(endereco, preco)
        {
        }
        public override void CalculaValor()
        {
            base.CalculaValor();
            Preco += PrecoAdicional;
            Console.WriteLine("Imóvel novo");
            Console.WriteLine("Preço adicional: " + PrecoAdicional);
            Console.WriteLine("Preço total: " + Preco);
        }
    }
    class Velho : Imovel
    {
        public double Desconto { get; set; }
        public Velho(string endereco, double preco) : base(endereco, preco)
        {
        }
        public override void CalculaValor()
        {
            base.CalculaValor();
            Preco -= Desconto;
            Console.WriteLine("Imóvel velho");
            Console.WriteLine("Desconto: " + Desconto);
            Console.WriteLine("Preço total: " + Preco);
        }
    }
}
