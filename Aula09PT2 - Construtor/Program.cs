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

            ////02
            //List<Exec02> pessoas = new List<Exec02>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o nome");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o gênero");
            //    string genero = Console.ReadLine();
            //    Console.WriteLine("Insira a idade");
            //    int idade = int.Parse(Console.ReadLine());

            //    Exec02 pessoa = new Exec02(nome, genero, idade);
            //    pessoas.Add(pessoa);
            //}

            //int indiceHomem = 0, indiceMulher = 0;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    int hVelho = 0, mVelha = 0;
            //    if (pessoas[i].genero == "m")
            //    {
            //        if (hVelho < pessoas[i].idade)
            //        {
            //            indiceHomem = i;
            //        }
            //    }
            //    else
            //    {
            //        if (mVelha < pessoas[i].idade)
            //        {
            //            indiceMulher = i;
            //        }
            //    }
            //}

            //Console.WriteLine(pessoas[indiceHomem].nome);
            //Console.WriteLine(pessoas[indiceHomem].idade);
            //Console.WriteLine(pessoas[indiceHomem].genero);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine(pessoas[indiceMulher].nome);
            //Console.WriteLine(pessoas[indiceMulher].idade);
            //Console.WriteLine(pessoas[indiceMulher].genero);

            ////03
            //List<Exec03> cachorros = new List<Exec03>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira nome");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira nome dono");
            //    string nomeDono = Console.ReadLine();
            //    Console.WriteLine("Insira idade");
            //    int idade = int.Parse(Console.ReadLine());
            //    Exec03 cachorro = new Exec03(nome, nomeDono, idade);
            //    cachorros.Add(cachorro);
            //}

            //Console.Clear();

            //foreach (var item in cachorros)
            //{
            //    if (item.idade > 4)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDono);
            //        Console.WriteLine(item.idade);
            //    }
            //}

            ////04
            //List<Exec04> produtos = new List<Exec04>();

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Insira o nome do produto");
            //    string nome = Console.ReadLine(); 
            //    Console.WriteLine("Insira o nome do produto");
            //    int quantidade = int.Parse(Console.ReadLine()); 
            //    Console.WriteLine("Insira o nome do produto");
            //    double preco = double.Parse(Console.ReadLine());

            //    Exec04 produto = new Exec04(nome, quantidade, preco);
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

            ////05
            //List<Exec05> animais = new List<Exec05>();

            //for (int h = 0; h < 3; h++)
            //{
            //    Console.WriteLine("Animal " + (h + 1));
            //    string nome = Console.ReadLine();
            //    string especie = Console.ReadLine();
            //    int tempoZoo = int.Parse(Console.ReadLine());
            //    Exec05 animal = new Exec05(nome, especie,tempoZoo);
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

            ////06
            //List<Exec06> empregados = new List<Exec06>();
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o nome do empregado");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o salário do empregado");
            //    double salario = double.Parse(Console.ReadLine());

            //    //if (empregado.salario < 1500)
            //    //{
            //    //    empregado.salario *= 1.2;
            //    //    Console.WriteLine("Este funcionário ganhou um aumento!");
            //    //}

            //    Console.WriteLine("Insira o CPF do empregado");
            //    string cpf = Console.ReadLine();
            //    Exec06 empregado = new Exec06(nome, cpf, salario);
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

            //07
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira o nome do aluno");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira a nota 1");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a nota 2");
                double n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a nota 3");
                double n3 = double.Parse(Console.ReadLine());

                Exec07 aluno = new Exec07(nome, n1, n2, n3);
                Exec07.MediaAprovacao(n1, n2, n3);
            }

            Console.ReadKey();
        }
    }
}
