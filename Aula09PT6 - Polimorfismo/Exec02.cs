using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    //2
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public virtual void ExibeDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salario: " + Salario);
        }
    }
    //a
    class Assistente : Funcionario
    {
        public int NumMatricula { get; set; }
        public Assistente(string nome, double salario) : base(nome, salario)
        {
        }
        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine("Matricula: " + NumMatricula);
        }
    }
    //b
    class Tecnico : Assistente
    {
        public double BonusSalarial { get; set; }
        public Tecnico(string nome, double salario) : base(nome, salario)
        {
        }
        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine("Adicional de salário: " + BonusSalarial);
            Console.WriteLine("Salário total: " + (Salario + BonusSalarial));
        }
    }
    class Administrativo : Assistente
    {
        public double AdicionalNoturno { get; set; }
        public bool Turno { get; set; }
        public Administrativo(string nome, double salario) : base(nome, salario)
        {
        }
        public override void ExibeDados()
        {
            base.ExibeDados();
            if (Turno)
            {
                Console.WriteLine("Adicional de salário: " + AdicionalNoturno);
                Console.WriteLine("Salário total: " + (Salario + AdicionalNoturno));
            }
            else
            {
                Console.WriteLine("Salário total: " + Salario);
            }
        }
    }
}
