using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    class Agenda
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public virtual void MostrarAgenda()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Email: " + Email);
        }
    }
    class Fisica : Agenda
    {
        public string Cpf { get; set; }
        public override void MostrarAgenda()
        {
            base.MostrarAgenda();
            Console.WriteLine("CPF: " + Cpf);
        }
    }
    class Juridica : Agenda
    {
        public string Cnpj { get; set; }
        public override void MostrarAgenda()
        {
            base.MostrarAgenda();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}
