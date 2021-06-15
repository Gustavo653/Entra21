using System;
using System.Collections.Generic;

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

            ////04
            //Exec04 pessoa = new Exec04("", "", new string[1]);
            //string nome, cpf;
            //string[] consultas = new string[10];
            //Console.WriteLine("Insira um cliente");
            //nome = Console.ReadLine();
            //cpf = Console.ReadLine();
            //Console.WriteLine("Insira as consultas");
            //Console.WriteLine("Para encerrar pressione f");
            //int indice = 0;
            //while (true)
            //{

            //    Console.WriteLine("Insira a consulta " + (indice + 1));
            //    string tempConsulta = Console.ReadLine();
            //    if (tempConsulta == "f")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        consultas[indice] = tempConsulta;
            //        indice++;

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Chegamos ao limite de 10 consultas");
            //        break;
            //    }
            //}
            //pessoa.SetNome(nome);
            //pessoa.SetCpf(cpf);
            //pessoa.SetConsulta(consultas);
            //Console.Clear();
            //Console.WriteLine(pessoa.GetNome());
            //Console.WriteLine(pessoa.GetCpf());
            //for (int i = 0; i < pessoa.GetConsultas().Length; i++)
            //{
            //    if(pessoa.GetConsultas()[i] == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(pessoa.GetConsultas()[i]);
            //}

            ////05
            //Exec05 cliente1 = new Exec05("", "", new string[1]);
            //Exec05 cliente2 = new Exec05("", "", new string[1]);
            //Exec05 cliente3 = new Exec05("", "", new string[1]);
            //Exec05 cliente4 = new Exec05("", "", new string[1]);
            //Exec05 cliente5 = new Exec05("", "", new string[1]);
            //cliente3.SetNome("Carla");

            //cliente5 = cliente1;

            //if (cliente4.GetConsultas().Length > 4)
            //{
            //    Console.WriteLine("Não pode-se fazer mais consulta alguma!");
            //}

            //cliente2.SetNome("Jonas");
            //cliente2.SetCpf("842.512.552-96");
            //string[] consulta = new string[2];
            //consulta[0] = "Limpeza";
            //consulta[1] = "Manutenção do aparelho";
            //cliente2.SetConsulta(consulta);

            ////06
            //double media = 0;
            //Exec06 aluno = new Exec06("", new double[1]);

            //Console.WriteLine("Qual o nome do aluno?");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantas notas você deseja adicionar?");
            //int quantNotas = int.Parse(Console.ReadLine());
            //double[] notas = new double[quantNotas];
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Insira a nota {0}", (i + 1));
            //        try
            //        {
            //            double auxNota = double.Parse(Console.ReadLine());
            //            notas[i] = auxNota;
            //            media += auxNota;
            //            break;
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Verifique sua entrada!");
            //        }
            //    }
            //}
            //aluno.SetNome(nome);
            //aluno.SetNota(notas);
            //Console.WriteLine(aluno.GetNome());
            //for (int i = 0; i < aluno.GetNotas().Length; i++)
            //{
            //    Console.WriteLine("Nota " + (i + 1) + ": " + aluno.GetNotas()[i]);
            //}
            //media /= aluno.GetNotas().Length;
            //Console.WriteLine("A média foi:" + media);

            ////07
            //Exec07 caixa = new Exec07(0, 1000, 0, 0);
            //int guiche;
            //double entrada = 0, saida = 0, operacao = 0;

            //Console.WriteLine("Insira o número do guichê");
            //while (true)
            //{
            //    try
            //    {
            //        guiche = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Verifique sua entrada!");
            //    }
            //}

            //caixa.SetGuiche(guiche);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Insira o valor da operação!");
            //    Console.WriteLine("Para representar saída do caixa, digite o valor negativo. Ex: R$-500");
            //    while (true)
            //    {
            //        try
            //        {
            //            operacao = double.Parse(Console.ReadLine());
            //            break;
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Verifique sua entrada!");
            //        }
            //    }
            //    if (operacao < 0)
            //    {
            //        saida -= operacao;
            //        Console.WriteLine("Saiu R${0}", operacao);
            //    }
            //    else
            //    {
            //        entrada += operacao;
            //        Console.WriteLine("Entrou R${0}", operacao);
            //    }
            //}

            //caixa.SetEntrada(entrada);
            //caixa.SetSaida(saida);
            //caixa.SetSaldo((caixa.GetSaldo() + caixa.GetEntrada()) - caixa.GetSaida());
            //Console.Clear();
            //Console.WriteLine("Número do guichê: {0}", caixa.GetGuiche());
            //Console.WriteLine("Quantia total que entrou no caixa: {0}", caixa.GetEntrada());
            //Console.WriteLine("Quantia total que saiu no caixa: {0}", caixa.GetSaida());
            //Console.WriteLine("Saldo ao final do dia: {0}", caixa.GetSaldo());
            //if (caixa.GetSaldo() < 1000)
            //{
            //    Console.WriteLine("O dia terminou com prejuízo!");
            //}
            //else
            //{
            //    Console.WriteLine("O dia terminou com lucro!");
            //}

            //LISTA02LISTA02LISTA02LISTA02LISTA02LISTA02LISTA02LISTA02LISTA02
            //01
            List<Exec11> clientes = new List<Exec11>();
            Exec11 cliente = new Exec11(0, 0, "");
            string nome;
            int conta;
            double saldo;

            Console.WriteLine("Adicione as contas");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o nome");
                nome = Console.ReadLine();
                Console.WriteLine("Insira a conta");
                conta = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o saldo inicial");
                saldo = double.Parse(Console.ReadLine());

                cliente.SetNome(nome);
                cliente.SetConta(conta);
                cliente.SetSaldo(saldo);

                clientes.Add(cliente);
            }
            while (true)
            {
                Console.WriteLine("Insira a conta a ser pesquisada");
                conta = int.Parse(Console.ReadLine());
                foreach (var item in clientes)
                {
                    if (conta == item.GetConta())
                    {

                    }
                }
            }
        }
    }
}
