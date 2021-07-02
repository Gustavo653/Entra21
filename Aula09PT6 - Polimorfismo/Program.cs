using System;
using System.Collections.Generic;

namespace Aula09PT6___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exemplo - Documentação MS
            //List<Shape> shapes = new List<Shape>
            //{
            //   new Rectangle(),
            //   new Triangle(),
            //   new Circle()
            //};

            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}

            ////1a
            //Console.WriteLine("Qual o valor do ingresso comum?");
            //double x = double.Parse(Console.ReadLine());
            //Vip vip = new Vip(x);
            //Console.WriteLine("Qual o valor adicional do ingresso vip?");
            //x = double.Parse(Console.ReadLine());
            //vip.ValorAdicional = x;
            //vip.ImprimeValor();

            ////1b
            //Console.WriteLine("Qual o valor do ingresso comum?");
            //double x = double.Parse(Console.ReadLine());
            //Normal norm = new Normal(x);
            //norm.ImprimeValor();

            ////1c
            //Console.WriteLine("Insira 1 para camarote superior e 2 para camarote inferior");
            //double x = double.Parse(Console.ReadLine());
            //if (x == 1)
            //{
            //    Console.WriteLine("Insira o valor normal");
            //    x = double.Parse(Console.ReadLine());
            //    CamaroteSuperior camSup = new CamaroteSuperior(x);
            //    camSup.Valor = x;
            //    Console.WriteLine("Insira o valor adicional");
            //    x = double.Parse(Console.ReadLine());
            //    camSup.ValorAdicional = x;
            //    camSup.Localizacao = "2A";
            //    camSup.ImprimeValor();
            //}
            //else
            //{
            //    Console.WriteLine("Insira o valor normal");
            //    x = double.Parse(Console.ReadLine());
            //    CamaroteInferior camInf = new CamaroteInferior(x);
            //    camInf.Valor = x;
            //    Console.WriteLine("Insira o valor adicional");
            //    x = double.Parse(Console.ReadLine());
            //    camInf.ValorAdicional = x;
            //    camInf.Localizacao = "1A";
            //    camInf.ImprimeValor();
            //}

            ////1d
            //Console.WriteLine("Bem vindo a Ticket Master 2000");
            //Console.WriteLine("Temos as seguintes opções de ingressos:");
            //Console.WriteLine("1 - Normal");
            //Console.WriteLine("2 - Vip");
            //Console.WriteLine("3 - Camarote Inferior");
            //Console.WriteLine("4 - Camarote Superior");
            //Console.WriteLine("Qual você deseja?");
            //while (true)
            //{
            //    double x = double.Parse(Console.ReadLine());
            //    if (x == 1)
            //    {
            //        Console.WriteLine("1 - Normal");
            //        Console.WriteLine("Insira o valor do ingresso");
            //        x = double.Parse(Console.ReadLine());
            //        Normal norm = new Normal(x);
            //        norm.ImprimeValor();
            //    }
            //    else if (x == 2)
            //    {
            //        Console.WriteLine("2 - Vip");
            //        Console.WriteLine("Insira o valor do ingresso");
            //        x = double.Parse(Console.ReadLine());
            //        Vip vip = new Vip(x);
            //        Console.WriteLine("Insira o valor adicional");
            //        x = double.Parse(Console.ReadLine());
            //        vip.ValorAdicional = x;
            //        vip.ImprimeValor();
            //    }
            //    else if (x == 3)
            //    {
            //        Console.WriteLine("3 - Camarote Inferior");
            //        Console.WriteLine("Insira o valor normal");
            //        x = double.Parse(Console.ReadLine());
            //        CamaroteInferior camInf = new CamaroteInferior(x);
            //        camInf.Valor = x;
            //        Console.WriteLine("Insira o valor adicional");
            //        x = double.Parse(Console.ReadLine());
            //        camInf.ValorAdicional = x;
            //        camInf.Localizacao = "1A";
            //        camInf.ImprimeValor();
            //    }
            //    else
            //    {
            //        Console.WriteLine("4 - Camarote Superior");
            //        Console.WriteLine("Insira o valor normal");
            //        x = double.Parse(Console.ReadLine());
            //        CamaroteSuperior camSup = new CamaroteSuperior(x);
            //        camSup.Valor = x;
            //        Console.WriteLine("Insira o valor adicional");
            //        x = double.Parse(Console.ReadLine());
            //        camSup.ValorAdicional = x;
            //        camSup.Localizacao = "2A";
            //        camSup.ImprimeValor();
            //    }
            //}

            //02c
            Assistente ass = new Assistente("NomeAssistente", 2000);
            Tecnico tec = new Tecnico("NomeTecnico", 3000);
            Administrativo adm = new Administrativo("NomeAdministrativo", 3000);

            ass.NumMatricula = 0;
            tec.NumMatricula = 1;
            adm.NumMatricula = 2;

            tec.BonusSalarial = 500;
            adm.Turno = true;
            adm.AdicionalNoturno = 400;

            List<Assistente> funcs = new List<Assistente>();
            funcs.Add(adm);
            funcs.Add(tec);
            funcs.Add(ass);

            while (true)
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Alterar");
                Console.WriteLine("2 - Excluir");
                Console.WriteLine("3 - Sair");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("Escolha o ID de um funcionário para alterar");
                    for (int i = 0; i < funcs.Count; i++)
                    {
                        Console.WriteLine("Id: " + (i + 1));
                        funcs[i].ExibeDados();
                    }

                    Console.WriteLine("---------------------------");

                    x = int.Parse(Console.ReadLine());
                    x--;

                    if (funcs[x].NumMatricula == 1)
                    {
                        tec.ExibeDados();
                        Console.WriteLine("Qual dado você deseja alterar?");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - Salario");
                        Console.WriteLine("3 - NumMatricula");
                        Console.WriteLine("4 - Bonus Salarial");
                        x = int.Parse(Console.ReadLine());
                        if (x == 1)
                        {
                            string nome = Console.ReadLine();
                            tec.Nome = nome;
                        }
                        else if (x == 2)
                        {
                            double salario = double.Parse(Console.ReadLine());
                            tec.Salario = salario;
                        }
                        else if (x == 3)
                        {
                            int matricula = int.Parse(Console.ReadLine());
                            tec.NumMatricula = matricula;
                        }
                        else
                        {
                            double bonus = double.Parse(Console.ReadLine());
                            tec.BonusSalarial = bonus;
                        }
                    }
                    else if (funcs[x].NumMatricula == 2)
                    {
                        adm.ExibeDados();
                        Console.WriteLine("Qual dado você deseja alterar?");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - Salario");
                        Console.WriteLine("3 - NumMatricula");
                        Console.WriteLine("4 - Adicional turno");
                        Console.WriteLine("5 - Turno");
                        x = int.Parse(Console.ReadLine());
                        if (x == 1)
                        {
                            string nome = Console.ReadLine();
                            adm.Nome = nome;
                        }
                        else if (x == 2)
                        {
                            double salario = double.Parse(Console.ReadLine());
                            adm.Salario = salario;
                        }
                        else if (x == 3)
                        {
                            int matricula = int.Parse(Console.ReadLine());
                            adm.NumMatricula = matricula;
                        }
                        else if (x == 4)
                        {
                            double adicional = double.Parse(Console.ReadLine());
                            adm.AdicionalNoturno = adicional;
                        }
                        else
                        {
                            int turno = int.Parse(Console.ReadLine());
                            if (turno == 1)
                            {
                                adm.Turno = true;
                            }
                            else
                            {
                                adm.Turno = false;
                            }
                        }
                    }
                    else
                    {
                        ass.ExibeDados();
                        Console.WriteLine("Qual dado você deseja alterar?");
                        Console.WriteLine("1 - Nome");
                        Console.WriteLine("2 - Salario");
                        Console.WriteLine("3 - NumMatricula");
                        x = int.Parse(Console.ReadLine());
                        if (x == 1)
                        {
                            string nome = Console.ReadLine();
                            ass.Nome = nome;
                        }
                        else if (x == 2)
                        {
                            double salario = double.Parse(Console.ReadLine());
                            ass.Salario = salario;
                        }
                        else if (x == 3)
                        {
                            int matricula = int.Parse(Console.ReadLine());
                            ass.NumMatricula = matricula;
                        }
                    }

                }
                else if (x == 2)
                {
                    Console.WriteLine("Escolha o ID de um funcionário para demitir");
                    for (int i = 0; i < funcs.Count; i++)
                    {
                        Console.WriteLine("Id: " + (i + 1));
                        funcs[i].ExibeDados();
                    }
                    x = int.Parse(Console.ReadLine());
                    x--;
                    try
                    {
                        funcs.RemoveAt(x);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Funcionario inválido!");
                    }
                    Console.WriteLine("Funcionário demitido!");
                }
                else
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            ////03
            //Cliente cli = new Cliente("Nome", 2500);

            //Novo imNovo = new Novo("Rua Novo", 1000);
            //Novo imNovo2 = new Novo("Rua Novo", 2000);
            //Velho imVelho = new Velho("Rua Velho", 2000);
            //Velho imVelho2 = new Velho("Rua Velho", 4000);

            //imNovo.PrecoAdicional = 1000;
            //imNovo2.PrecoAdicional = 1000;
            //imVelho.Desconto = 1000;
            //imVelho2.Desconto = 1000;

            //List<Imovel> imoveis = new List<Imovel>();
            //imoveis.Add(imNovo);
            //imoveis.Add(imNovo2);
            //imoveis.Add(imVelho);
            //imoveis.Add(imVelho2);
            //while (true)
            //{
            //    Console.WriteLine("Nome do cliente: " + cli.Nome);
            //    Console.WriteLine("Dinheiro do cliente: " + cli.Dinheiro);
            //    Console.WriteLine();
            //    for (int i = 0; i < imoveis.Count; i++)
            //    {
            //        Console.WriteLine("ID: " + (i + 1));
            //        imoveis[i].CalculaValor();
            //    }

            //    Console.WriteLine("Insira o ID desejado");
            //    int escolha = int.Parse(Console.ReadLine());
            //    escolha--;
            //    try
            //    {
            //        if (imoveis[escolha].Preco > cli.Dinheiro)
            //        {
            //            Console.WriteLine("Você vai precisar parcelar este imóvel.");
            //            double parcelamento = imoveis[escolha].Preco;
            //            parcelamento /= 12;
            //            parcelamento *= 1.1674;
            //            Console.WriteLine("Cada parcela será de: " + parcelamento);
            //            parcelamento *= 12;
            //            Console.WriteLine("O valor que você precisa parcelar será de: " + imoveis[escolha].Preco);
            //            Console.WriteLine("O valor total com acréscimo " + parcelamento);
            //        }
            //        else
            //        {
            //            cli.Dinheiro -= imoveis[escolha].Preco;
            //            Console.WriteLine("Agradecemos pela compra!");
            //            Console.WriteLine("Seu saldo restante é de: " + cli.Dinheiro);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Imóvel inválido!");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //Lista02
            ////1
            //List<Pessoa> agenda = new List<Pessoa>();
            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para PF ou 2 para PJ");
            //    int escolha = int.Parse(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Insira um nome");
            //        string nome = Console.ReadLine();
            //        Console.WriteLine("Insira um endereco");
            //        string endereco = Console.ReadLine();
            //        Console.WriteLine("Insira um email");
            //        string email = Console.ReadLine();
            //        Console.WriteLine("Insira um CPF");
            //        string Cpf = Console.ReadLine();
            //        Fisica fis = new Fisica(nome, endereco, email);
            //        fis.Cpf = Cpf;
            //        agenda.Add(fis);
            //    }
            //    else
            //    {

            //    }
            //}
        }
    }
}