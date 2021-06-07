using System;
using System.Collections.Generic;

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

            //04
            List<Exec04> animais = new List<Exec04>();
            Exec04 animal = new Exec04();

            for (int h = 0; h < 3; h++)
            {
                Console.WriteLine("Animal " + (h + 1));
                animal.nome = Console.ReadLine();
                animal.especie = Console.ReadLine();
                animal.tempoZoo = int.Parse(Console.ReadLine());
                animais.Add(animal);
            }

            for (int i = 0; i < animais.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (animais[j - 1].tempoZoo > animais[j].tempoZoo)
                    {
                        // c = a 
                        // a = b 
                        // b = c
                        int tempTempo = animais[j].tempoZoo; //int
                        animais[j].tempoZoo = animais[j - 1].tempoZoo; //int
                        animais[j - 1].tempoZoo = tempTempo; //int

                        string tempNome = animais[j].nome; //int
                        animais[j].nome = animais[j - 1].nome; //int
                        animais[j - 1].nome = tempNome; //int

                        string tempEspecie = animais[j].especie; //int
                        animais[j].especie = animais[j - 1].especie; //int
                        animais[j - 1].especie = tempEspecie; //int
   
                    }
                }
            }

            for (int i = 0; i < animais.Count; i++)
            {
                Console.WriteLine(animais[i].nome + " " + animais[i].especie + " " + animais[i].tempoZoo);
            }
        }
    }
}
