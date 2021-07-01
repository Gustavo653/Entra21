using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public Pessoa(string nome, string endereco, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }
        public virtual void MostrarAgenda()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Email: " + Email);
        }
    }
    class Fisica : Pessoa
    {
        public string Cpf { get; set; }
        public Fisica(string nome, string endereco, string email) : base(nome, endereco, email)
        {
        }
        public override void MostrarAgenda()
        {
            base.MostrarAgenda();
            Console.WriteLine("CPF: " + Cpf);
        }
    }
    class Juridica : Pessoa
    {
        public string Cnpj { get; set; }
        public Juridica(string nome, string endereco, string email) : base(nome, endereco, email)
        {
        }
        public override void MostrarAgenda()
        {
            base.MostrarAgenda();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}
