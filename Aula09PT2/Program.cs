using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01
            //Exec01 pessoa = new Exec01("Juliana", "001", "Rua das missões", 34);

            //Console.WriteLine(pessoa.nome);
            //Console.WriteLine(pessoa.cpf);
            //Console.WriteLine(pessoa.endereco);
            //Console.WriteLine(pessoa.idade);

            //Console.WriteLine("Insira o nome:");
            //pessoa.nome = Console.ReadLine();
            //Console.WriteLine("Insira o endereço:");
            //pessoa.endereco = Console.ReadLine();
            //Console.WriteLine("Insira o cpf:");
            //pessoa.cpf = Console.ReadLine();
            //Console.WriteLine("Insira o idade:");
            //pessoa.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine(pessoa.nome);
            //Console.WriteLine(pessoa.cpf);
            //Console.WriteLine(pessoa.endereco);
            //Console.WriteLine(pessoa.idade);

            //02
            List<Exec02> pessoas = new List<Exec02>();

            for (int i = 0; i < 4; i++)
            {
                Exec02 pessoaInicial = new Exec02();
                Console.WriteLine("Insira nome");
                pessoaInicial.nome = Console.ReadLine();
                Console.WriteLine("Insira gênero");
                pessoaInicial.genero = Console.ReadLine();
                Console.WriteLine("Insira idade");
                pessoaInicial.idade = int.Parse(Console.ReadLine());

                Exec02 pessoa = new Exec02(pessoaInicial.nome, pessoaInicial.genero, pessoaInicial.idade);
                pessoas.Add(pessoa);
            }

            //03
            List<Exec03> cachorros = new List<Exec03>();
            for (int i = 0; i < 4; i++)
            {
                Exec03 cachorro = new Exec03();
                Console.WriteLine("Insira nome");
                cachorro.nome = Console.ReadLine();
                Console.WriteLine("Insira nome dono");
                cachorro.nomeDono = Console.ReadLine();
                Console.WriteLine("Insira idade");
                cachorro.idade = int.Parse(Console.ReadLine());

                cachorros.Add(cachorro);
            }

            foreach (var item in cachorros)
            {
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
