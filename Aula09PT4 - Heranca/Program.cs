using System;

namespace Aula09PT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();
            //01
            Console.WriteLine("Exec 1 - A");
            Console.WriteLine("Insira um nome");
            pes.Nome = Console.ReadLine();
            Console.WriteLine("Insira uma idade");
            pes.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um CPF");
            pes.Cpf = Console.ReadLine();
            Console.WriteLine("Insira um estado");
            pes.Estado = Console.ReadLine();
            Console.WriteLine("Insira uma cidade");
            pes.Cidade = Console.ReadLine();
            Console.WriteLine("Insira um número");
            pes.Numero = Console.ReadLine();
            Console.WriteLine("Insira uma rua");
            pes.Rua = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}"
                , pes.Nome
                , pes.Idade
                , pes.Cpf
                , pes.Estado
                , pes.Cidade
                , pes.Numero
                , pes.Rua
                );
        }
    }
}
