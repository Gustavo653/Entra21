using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Lista01
            /////01
            //Exec exec01 = new Exec();
            //Console.WriteLine("Insira um nome");
            //exec01.nome = Console.ReadLine();
            //Console.WriteLine("Insira uma idade");
            //exec01.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira um endereço");
            //exec01.endereco = Console.ReadLine();

            //Console.WriteLine(exec01.nome + " " + exec01.idade + " " + exec01.endereco + " ");

            ////02
            //List<Exec02> doginhos = new List<Exec02>();

            ////preenche a lista
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o doginho");
            //    Exec02 cao = new Exec02();
            //    cao.nomeCachorro = Console.ReadLine();
            //    cao.nomeDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    doginhos.Add(cao);
            //}

            ////mostrar a lista, apenas cachorros velhos
            //foreach (var item in doginhos)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nomeCachorro);
            //        Console.WriteLine(item.nomeDono);
            //        Console.WriteLine(item.idade);
            //    }
            //}

            ////03
            //List<Exec03> Pessoas = new List<Exec03>();
            //int auxGenM = 0;
            //int auxGenF = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Pessoa " + (i + 1));
            //    Exec03 pessoa = new Exec03();
            //    pessoa.nome = Console.ReadLine();
            //    pessoa.idade = int.Parse(Console.ReadLine());
            //    pessoa.genero = char.Parse(Console.ReadLine());
            //    Pessoas.Add(pessoa);
            //}

            //int cont = 0;
            //foreach (var item in Pessoas)
            //{
            //    if (item.genero == 'M')
            //    {
            //        if (item.idade > auxGenM)
            //        {
            //            auxGenM = cont;
            //        }
            //    }
            //    else
            //    {
            //        if (item.idade > auxGenF)
            //        {
            //            auxGenF = cont;
            //        }
            //    }
            //    cont++;
            //}
            //Console.WriteLine("Homem: ");
            //Console.WriteLine(Pessoas[auxGenM].nome + " " + Pessoas[auxGenM].idade + " " + Pessoas[auxGenM].genero + " ");
            //Console.WriteLine("Mulher: ");
            //Console.WriteLine(Pessoas[auxGenF].nome + " " + Pessoas[auxGenF].idade + " " + Pessoas[auxGenF].genero + " ");

            ////04
            //List<Exec04> animais = new List<Exec04>();

            //for (int h = 0; h < 3; h++)
            //{
            //    Exec04 animal = new Exec04();
            //    Console.WriteLine("Animal " + (h + 1));
            //    animal.nome = Console.ReadLine();
            //    animal.especie = Console.ReadLine();
            //    animal.tempoZoo = int.Parse(Console.ReadLine());
            //    animais.Add(animal);
            //}

            //for (int i = 0; i < animais.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (animais[j - 1].tempoZoo > animais[j].tempoZoo)
            //        {
            //            // c = a 
            //            // a = b 
            //            // b = c
            //            string tempNome = animais[j].nome; //int
            //            animais[j].nome = animais[j - 1].nome; //int
            //            animais[j - 1].nome = tempNome; //int

            //            string tempEspecie = animais[j].especie; //int
            //            animais[j].especie = animais[j - 1].especie; //int
            //            animais[j - 1].especie = tempEspecie; //int

            //            int tempTempo = animais[j].tempoZoo; //int
            //            animais[j].tempoZoo = animais[j - 1].tempoZoo; //int
            //            animais[j - 1].tempoZoo = tempTempo; //int
            //        }
            //    }
            //}
            //foreach (var item in animais)
            //{
            //    Console.WriteLine(item.nome + " " + item.especie + " " + item.tempoZoo);
            //}

            ////05
            //List<Exec05> produtos = new List<Exec05>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Exec05 produto = new Exec05();
            //    Console.WriteLine("Insira o nome do produto");
            //    produto.nome = Console.ReadLine();
            //    Console.WriteLine("Insira o preço do produto");
            //    produto.preco = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insira a quantidade do produto");
            //    produto.quantidade = int.Parse(Console.ReadLine());
            //    produtos.Add(produto);
            //}
            //for (int i = 0; i < produtos.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (produtos[j - 1].quantidade < produtos[j].quantidade)
            //        {
            //            // c = a 
            //            // a = b 
            //            // b = c
            //            string tempNome = produtos[j].nome; //int
            //            produtos[j].nome = produtos[j - 1].nome; //int
            //            produtos[j - 1].nome = tempNome; //int

            //            int tempQuantidade = produtos[j].quantidade; //int
            //            produtos[j].quantidade = produtos[j - 1].quantidade; //int
            //            produtos[j - 1].quantidade = tempQuantidade; //int

            //            double tempPreco = produtos[j].preco; //int
            //            produtos[j].preco = produtos[j - 1].preco; //int
            //            produtos[j - 1].preco = tempPreco; //int
            //        }
            //    }
            //}
            //foreach (var item in produtos)
            //{
            //    Console.WriteLine(item.nome + " " + item.quantidade + " " + item.preco);
            //}

            ////06
            //List<Exec06> empregados = new List<Exec06>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Exec06 empregado = new Exec06();
            //    Console.WriteLine("Insira o nome do empregado");
            //    empregado.nome = Console.ReadLine();
            //    Console.WriteLine("Insira o salário do empregado");
            //    empregado.salario = double.Parse(Console.ReadLine());

            //    if (empregado.salario < 1500)
            //    {
            //        empregado.salario *= 1.2;
            //        Console.WriteLine("Este funcionário ganhou um aumento!");
            //    }

            //    Console.WriteLine("Insira o CPF do empregado");
            //    empregado.cpf = Console.ReadLine();
            //    empregados.Add(empregado);
            //}

            //for (int i = 0; i < empregados.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (empregados[j - 1].salario > empregados[j].salario)
            //        {
            //            // c = a 
            //            // a = b 
            //            // b = c
            //            string tempNome = empregados[j].nome; //int
            //            empregados[j].nome = empregados[j - 1].nome; //int
            //            empregados[j - 1].nome = tempNome; //int

            //            string tempCPF = empregados[j].cpf; //int
            //            empregados[j].cpf = empregados[j - 1].cpf; //int
            //            empregados[j - 1].cpf = tempCPF; //int

            //            double tempSalario = empregados[j].salario; //int
            //            empregados[j].salario = empregados[j - 1].salario; //int
            //            empregados[j - 1].salario = tempSalario; //int
            //        }
            //    }
            //}
            //foreach (var item in empregados)
            //{
            //    Console.WriteLine(item.nome + " " + item.cpf + " " + item.salario);
            //}

            ////07
            //for (int i = 0; i < 3; i++)
            //{
            //    Exec07 aluno = new Exec07();
            //    Console.WriteLine("Insira o nome do aluno");
            //    aluno.nome = Console.ReadLine();
            //    Console.WriteLine("Insira a nota 1");
            //    aluno.n1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insira a nota 2");
            //    aluno.n2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insira a nota 3");
            //    aluno.n3 = double.Parse(Console.ReadLine());

            //    Exec07.MediaAprovacao(aluno.n1, aluno.n2, aluno.n3);
            //}

            //Lista 02
            //01
            List<Exec01> clientes = new List<Exec01>();
            for (int i = 0; i < 4; i++)
            {
                Exec01 cliente = new Exec01();
                Console.WriteLine("Insira o nome: ");
                cliente.nome = Console.ReadLine();
                Console.WriteLine("Insira o CPF");
                cliente.cpf = Console.ReadLine();
                Console.WriteLine("O cliente é vip? S/N");
                char auxVip = char.Parse(Console.ReadLine());
                if (auxVip == 'S')
                {
                    cliente.vip = true;
                }
                else
                {
                    cliente.vip = false;
                }
                clientes.Add(cliente);
            }

            Console.Clear();

            foreach (var item in clientes)
            {
                if(item.vip == true)
                {
                    Console.WriteLine(item.nome);
                    Console.WriteLine(item.cpf);
                    Console.WriteLine("Cliente VIP");
                }
            }

            Console.WriteLine("-------------");

            foreach (var item in clientes)
            {
                if(item.vip == false)
                {
                    Console.WriteLine(item.nome);
                    Console.WriteLine(item.cpf);
                    Console.WriteLine("Cliente comum");
                }
            }
            Console.ReadKey();
        }
    }
}
