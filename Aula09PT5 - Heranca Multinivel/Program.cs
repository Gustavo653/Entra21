using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula09PT5___Heranca_Multinivel
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01a
            //Empresa emp = new Empresa();
            //Console.WriteLine("Preencha a Empreza");
            //emp.Nome = Console.ReadLine();
            //emp.Idade = Convert.ToInt32(Console.ReadLine());
            //emp.Saldo = Convert.ToDouble(Console.ReadLine());
            //emp.QntFunc = int.Parse(Console.ReadLine());
            //emp.Cnpj = Console.ReadLine();
            //emp.Rua = Console.ReadLine();
            //emp.Cep = Console.ReadLine();
            //emp.Cidade = Console.ReadLine();
            //emp.Estado = Console.ReadLine();
            //// formatar o CNPJ @"{0:00\.000\.000\/0000\-00}"
            //if (emp.QntFunc > 8)
            //{
            //    Console.WriteLine(@"{0}  {1}  {2:00\.000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
            //    Console.WriteLine("{0:c}  {1}", emp.Saldo, emp.QntFunc);
            //    Console.WriteLine("{0}  {1}  {2}", emp.Rua, emp.Cep, emp.Cidade);
            //    Console.WriteLine("{0}", emp.Estado);
            //}
            //else
            //{
            //    Console.WriteLine("Micro empresa");
            //}

            ////01b
            //List<Carro> carrros = new List<Carro>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Carro car = new Carro();
            //    Console.WriteLine("Preencha o carro");
            //    car.Nome = Console.ReadLine();
            //    car.Idade = Convert.ToInt32(Console.ReadLine());
            //    car.Modelo = Console.ReadLine();
            //    car.Cv = int.Parse(Console.ReadLine());
            //    carrros.Add(car);
            //}

            //List<Carro> CarroOrganizado = carrros.OrderBy(x => x.Cv).ToList();
            //foreach (var item in CarroOrganizado)
            //{
            //    if (item.Cv > 500)
            //    {
            //        Console.WriteLine("{0} {1}", item.Nome, item.Idade);
            //        Console.WriteLine("{0} {1}", item.Modelo, item.Cv);
            //    }
            //}
            //Console.ReadKey();


            //Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            ////01a
            //List<Casa> casas = new List<Casa>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Casa casa = new Casa();
            //    casa.Cidade = CR();
            //    casa.DataConstrucao = CR();
            //    casa.Estado = CR();
            //    casa.NomeDono = CR();
            //    casa.QuantQuartos = CR();
            //    casa.Rua = CR();
            //    casas.Add(casa);
            //}
            //List<Casa> casasOrganizadas = casas.OrderByDescending(x => x.QuantQuartos).ToList();
            //foreach (var item in casasOrganizadas)
            //{
            //    Console.WriteLine(item.Cidade);
            //    Console.WriteLine(item.DataConstrucao);
            //    Console.WriteLine(item.Estado);
            //    Console.WriteLine(item.NomeDono);
            //    Console.WriteLine(item.QuantQuartos);
            //    Console.WriteLine(item.Rua);
            //}

            ////01b
            //Hotel hot = new Hotel();
            //Console.WriteLine("Há quantos apartamentos?");
            //hot.QuantidadeApartamentos = Convert.ToInt32(Console.ReadLine());
            //hot.Apartamentos = new bool[hot.QuantidadeApartamentos];
            //while (true)
            //{
            //    Console.WriteLine("Apartamentos:");
            //    for (int i = 0; i < hot.Apartamentos.Length; i++)
            //    {
            //        Console.WriteLine("ID: " + (i+1) + " apartamento: " + hot.Apartamentos[i]);
            //    }
            //    Console.WriteLine("Há uma pessoa entrando ou saindo?");
            //    Console.WriteLine("1 - entrando");
            //    Console.WriteLine("2 - saindo");
            //    int escolha = int.Parse(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Qual o ID de quarto que você deseja?");
            //        escolha = int.Parse(CR());
            //        escolha--;
            //        bool achouQuarto = false;
            //        for (int i = 0; i < hot.Apartamentos.Length; i++)
            //        {
            //            if (hot.Apartamentos[escolha] == false)
            //            {
            //                hot.Apartamentos[escolha] = true;
            //                Console.WriteLine("Achamos um quarto!");
            //                Console.WriteLine("Quarto ID: " + (i+1));
            //                achouQuarto = true;
            //                break;
            //            }
            //        }
            //        if (achouQuarto == false)
            //        {
            //            Console.WriteLine("O quarto desejado não está disponível!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Qual o ID de quarto está saindo?");
            //        escolha = int.Parse(CR());
            //        escolha--;
            //        bool achouQuarto = false;
            //        for (int i = 0; i < hot.Apartamentos.Length; i++)
            //        {
            //            if (hot.Apartamentos[escolha] == true)
            //            {
            //                hot.Apartamentos[escolha] = false;
            //                Console.WriteLine("Quarto encontrado!");
            //                Console.WriteLine("Quarto ID: " + (i + 1));
            //                achouQuarto = true;
            //                break;
            //            }
            //        }
            //        if (achouQuarto == false)
            //        {
            //            Console.WriteLine("O quarto já está vazio!");
            //        }
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //DesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafio

            Ciclista cic = new Ciclista();
            Random ran = new Random();
            //a
            Console.WriteLine("Insira o nome:");
            cic.Nome = Console.ReadLine();
            Console.WriteLine("Insira a velocidade:");
            cic.Velocidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a distância:");
            cic.Distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O tempo que " + cic.Nome + " levará será de: " + (cic.Distancia / cic.Velocidade) + " segundos.");

            //b
            Console.WriteLine("Insira o nome:");
            cic.Nome = Console.ReadLine();
            cic.Velocidade = ran.Next(13, 26);
            cic.Distancia = ran.Next(500, 2001);


            Console.WriteLine("O tempo que " + cic.Nome + " levará será de: " + (cic.Distancia / cic.Velocidade) + " segundos.");

            //c
            List<Ciclista> ciclistas = new List<Ciclista>();
            Console.WriteLine("Qual será a distância?");
            double dist = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Ciclista ciclista = new Ciclista();
                Console.WriteLine("Insira o nome:");
                ciclista.Nome = Console.ReadLine();
                Console.WriteLine("Insira a velocidade:");
                ciclista.Velocidade = Convert.ToDouble(Console.ReadLine());
                ciclista.Distancia = dist;
                ciclistas.Add(ciclista);
            }
            List<Ciclista> ciclistaOrganizado = ciclistas.OrderByDescending(x => x.Velocidade).ToList();
            Console.WriteLine("--------------------------------------");
            foreach (var item in ciclistaOrganizado)
            {
                Console.Write(item.Nome + " ");
                Console.WriteLine(item.Velocidade);
                Console.WriteLine("_");
            }
        }
        public static string CR()
        {
            return Console.ReadLine();
        }
    }
}
