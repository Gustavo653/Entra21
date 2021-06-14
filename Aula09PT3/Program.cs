using System;

namespace Aula09PT3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01
            //Console.WriteLine("Preencha um cachorro");
            //string nome, raca;
            //int idade;
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());
            //Exec01 cachorro = new Exec01(nome, raca, idade);
            //Console.WriteLine(cachorro.GetNome() + cachorro.GetRaca() + cachorro.GetIdade());

            ////EXTRA
            //Console.WriteLine("Insira outro cachorro");
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());
            //cachorro.SetNome(nome);
            //cachorro.SetRaca(raca);
            //cachorro.SetIdade(idade);
            //Console.WriteLine(cachorro.GetNome() + cachorro.GetRaca() + cachorro.GetIdade());

            //04
            Exec04 pessoa = new Exec04("", "", new string[1]);
            string nome, cpf;
            string[] consultas = new string[10];
            Console.WriteLine("Insira um cliente");
            nome = Console.ReadLine();
            cpf = Console.ReadLine();
            Console.WriteLine("Insira as consultas");
            Console.WriteLine("Para encerrar pressione f");
            int indice = 0;
            while (true)
            {

                Console.WriteLine("Insira a consulta " + (indice + 1));
                string tempConsulta = Console.ReadLine();
                if (tempConsulta == "f")
                {
                    break;
                }
                try
                {
                    consultas[indice] = tempConsulta;
                    indice++;

                }
                catch (Exception)
                {
                    Console.WriteLine("Chegamos ao limite de 10 consultas");
                    break;
                }
            }
            pessoa.SetNome(nome);
            pessoa.SetCpf(cpf);
            pessoa.SetConsulta(consultas);
            Console.Clear();
            Console.WriteLine(pessoa.GetNome());
            Console.WriteLine(pessoa.GetCpf());
            for (int i = 0; i < pessoa.GetConsultas().Length; i++)
            {
                if(pessoa.GetConsultas()[i] == null || pessoa.GetConsultas()[i] == "")
                {
                    break;
                }
                Console.WriteLine(pessoa.GetConsultas()[i]);
            }
        }
    }
}
