using System;
using System.Collections.Generic;

namespace Aula09PT7___Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //01
            //List<Pessoa> pessoas = new List<Pessoa>();
            //while (true)
            //{
            //    Pessoa pessoa = new Pessoa();
            //    Console.WriteLine("Insira uma pessoa");
            //    pessoa.Nome = Console.ReadLine();
            //    if (pessoa.Nome == null)
            //    {
            //        break;
            //    }
            //    pessoa.Idade = int.Parse(Console.ReadLine());
            //    pessoa.Cpf = Console.ReadLine();
            //    bool cpfRepetido = false;
            //    foreach (var item in pessoas)
            //    {
            //        if (pessoa.Cpf == item.Cpf)
            //        {
            //            Console.WriteLine("Cpf repetido!");
            //            cpfRepetido = true;
            //            break;
            //        }
            //    }
            //    if (!cpfRepetido)
            //    {
            //        pessoas.Add(pessoa);
            //    }
            //}

            ////02
            //List<Hotel> hoteis = new List<Hotel>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Hotel hotel = new Hotel();
            //    hotel.Nome = Console.ReadLine();
            //    hotel.QtdQuartos = 50;
            //    hotel.QtdQuartosOcupados = 0;
            //    hoteis.Add(hotel);
            //}
            //while (true)
            //{
            //    Console.WriteLine("Escolha um hotel: 1 a 5");
            //    int escolha = int.Parse(Console.ReadLine());
            //    escolha--;
            //    if (hoteis[escolha].QtdQuartosOcupados > 50)
            //    {
            //        Console.WriteLine("Hotel ocupado!");
            //        Console.WriteLine("Mostrando hoteis vagos");
            //        for (int i = 0; i < hoteis.Count; i++)
            //        {
            //            if (hoteis[i].QtdQuartosOcupados <= 50)
            //            {
            //                Console.WriteLine("ID " + (i + 1));
            //                Console.WriteLine(hoteis[i].Nome);
            //                Console.WriteLine(hoteis[i].QtdQuartos);
            //                Console.WriteLine(hoteis[i].QtdQuartosOcupados);
            //                Console.WriteLine("-------------------------");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Quantas pessoas devem ser adicionadas neste hotel?");
            //        int escolhaQuartos = int.Parse(Console.ReadLine());
            //        if (escolhaQuartos > hoteis[escolha].QtdQuartos && escolhaQuartos > hoteis[escolha].QtdQuartosOcupados)
            //        {
            //            Console.WriteLine("Vagas insuficientes!");
            //        }
            //        else if (escolhaQuartos <= (hoteis[escolha].QtdQuartosOcupados + escolhaQuartos))
            //        {
            //            hoteis[escolha].QtdQuartosOcupados += escolhaQuartos;
            //        }
            //    }
            //}

            Pessoa2 pessoa = new Pessoa2();
            pessoa.QtdAnosPreso = 0;
            List<string> lista = new List<string>();
            lista.Add("Assalto");
            lista.Add("Furto");
            lista.Add("Furto");
            pessoa.Nome = Console.ReadLine();
            pessoa.Cpf = Console.ReadLine();
            pessoa.DataDeEntradaNaPrisao = Console.ReadLine();
            pessoa.Idade = int.Parse(Console.ReadLine());
            pessoa.ListaDeCrimes = lista;

            foreach (var item in lista)
            {
                if (item == "Assalto")
                {
                    pessoa.QtdAnosPreso += 3;
                }
                else if (item == "Furto")
                {
                    pessoa.QtdAnosPreso += 2;
                }
                else if (item == "Assassinato")
                {
                    pessoa.QtdAnosPreso += 5.5;
                }
                else if (item == "AssassinatoSeguidoDeRoubo")
                {
                    pessoa.QtdAnosPreso += 7;
                }
            }

            Console.WriteLine(pessoa.Cpf);
            Console.WriteLine(pessoa.DataDeEntradaNaPrisao);
            Console.WriteLine(pessoa.Idade);
            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.QtdAnosPreso);
            foreach (var item in pessoa.ListaDeCrimes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
