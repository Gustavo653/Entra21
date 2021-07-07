using System;
using System.Collections.Generic;
using System.Linq;

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

            ////02c
            //Assistente ass = new Assistente("NomeAssistente", 2000);
            //Tecnico tec = new Tecnico("NomeTecnico", 3000);
            //Administrativo adm = new Administrativo("NomeAdministrativo", 3000);

            //ass.NumMatricula = 0;
            //tec.NumMatricula = 1;
            //adm.NumMatricula = 2;

            //tec.BonusSalarial = 500;
            //adm.Turno = true;
            //adm.AdicionalNoturno = 400;

            //List<Assistente> funcs = new List<Assistente>();
            //funcs.Add(adm);
            //funcs.Add(tec);
            //funcs.Add(ass);

            //while (true)
            //{
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Alterar");
            //    Console.WriteLine("2 - Excluir");
            //    Console.WriteLine("3 - Sair");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x == 1)
            //    {
            //        Console.WriteLine("Escolha o ID de um funcionário para alterar");
            //        for (int i = 0; i < funcs.Count; i++)
            //        {
            //            Console.WriteLine("Id: " + (i + 1));
            //            funcs[i].ExibeDados();
            //        }

            //        Console.WriteLine("---------------------------");

            //        x = int.Parse(Console.ReadLine());
            //        x--;

            //        if (funcs[x].NumMatricula == 1)
            //        {
            //            tec.ExibeDados();
            //            Console.WriteLine("Qual dado você deseja alterar?");
            //            Console.WriteLine("1 - Nome");
            //            Console.WriteLine("2 - Salario");
            //            Console.WriteLine("3 - NumMatricula");
            //            Console.WriteLine("4 - Bonus Salarial");
            //            x = int.Parse(Console.ReadLine());
            //            if (x == 1)
            //            {
            //                string nome = Console.ReadLine();
            //                tec.Nome = nome;
            //            }
            //            else if (x == 2)
            //            {
            //                double salario = double.Parse(Console.ReadLine());
            //                tec.Salario = salario;
            //            }
            //            else if (x == 3)
            //            {
            //                int matricula = int.Parse(Console.ReadLine());
            //                tec.NumMatricula = matricula;
            //            }
            //            else
            //            {
            //                double bonus = double.Parse(Console.ReadLine());
            //                tec.BonusSalarial = bonus;
            //            }
            //        }
            //        else if (funcs[x].NumMatricula == 2)
            //        {
            //            adm.ExibeDados();
            //            Console.WriteLine("Qual dado você deseja alterar?");
            //            Console.WriteLine("1 - Nome");
            //            Console.WriteLine("2 - Salario");
            //            Console.WriteLine("3 - NumMatricula");
            //            Console.WriteLine("4 - Adicional turno");
            //            Console.WriteLine("5 - Turno");
            //            x = int.Parse(Console.ReadLine());
            //            if (x == 1)
            //            {
            //                string nome = Console.ReadLine();
            //                adm.Nome = nome;
            //            }
            //            else if (x == 2)
            //            {
            //                double salario = double.Parse(Console.ReadLine());
            //                adm.Salario = salario;
            //            }
            //            else if (x == 3)
            //            {
            //                int matricula = int.Parse(Console.ReadLine());
            //                adm.NumMatricula = matricula;
            //            }
            //            else if (x == 4)
            //            {
            //                double adicional = double.Parse(Console.ReadLine());
            //                adm.AdicionalNoturno = adicional;
            //            }
            //            else
            //            {
            //                int turno = int.Parse(Console.ReadLine());
            //                if (turno == 1)
            //                {
            //                    adm.Turno = true;
            //                }
            //                else
            //                {
            //                    adm.Turno = false;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            ass.ExibeDados();
            //            Console.WriteLine("Qual dado você deseja alterar?");
            //            Console.WriteLine("1 - Nome");
            //            Console.WriteLine("2 - Salario");
            //            Console.WriteLine("3 - NumMatricula");
            //            x = int.Parse(Console.ReadLine());
            //            if (x == 1)
            //            {
            //                string nome = Console.ReadLine();
            //                ass.Nome = nome;
            //            }
            //            else if (x == 2)
            //            {
            //                double salario = double.Parse(Console.ReadLine());
            //                ass.Salario = salario;
            //            }
            //            else if (x == 3)
            //            {
            //                int matricula = int.Parse(Console.ReadLine());
            //                ass.NumMatricula = matricula;
            //            }
            //        }

            //    }
            //    else if (x == 2)
            //    {
            //        Console.WriteLine("Escolha o ID de um funcionário para demitir");
            //        for (int i = 0; i < funcs.Count; i++)
            //        {
            //            Console.WriteLine("Id: " + (i + 1));
            //            funcs[i].ExibeDados();
            //        }
            //        x = int.Parse(Console.ReadLine());
            //        x--;
            //        try
            //        {
            //            funcs.RemoveAt(x);
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Funcionario inválido!");
            //        }
            //        Console.WriteLine("Funcionário demitido!");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}

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

            ////Lista02
            ////1
            //List<Agenda> agenda = new List<Agenda>();
            //List<Fisica> agFis = new List<Fisica>();
            //List<Juridica> agJur = new List<Juridica>();
            //while (true)
            //{
            //    List<Fisica> a = new List<Fisica>(); //Talvez não precisa

            //    Fisica fis = new Fisica();
            //    Juridica jur = new Juridica();
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Adicionar");
            //    Console.WriteLine("2 - Pesquisar");
            //    Console.WriteLine("3 - Remover");
            //    Console.WriteLine("4 - Mostrar todos");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "1")
            //    {
            //        Console.WriteLine("Você quer adicionar uma PF ou uma PJ?");
            //        Console.WriteLine("1 - PF // 2 - PJ");
            //        escolha = Console.ReadLine();
            //        if (escolha == "1")
            //        {
            //            fis.Nome = Console.ReadLine();
            //            fis.Cpf = Console.ReadLine();
            //            fis.Endereco = Console.ReadLine();
            //            fis.Email = Console.ReadLine();
            //            agenda.Add(fis);
            //        }
            //        else if (escolha == "2")
            //        {
            //            jur.Nome = Console.ReadLine();
            //            jur.Cnpj = Console.ReadLine();
            //            jur.Endereco = Console.ReadLine();
            //            jur.Email = Console.ReadLine();
            //            agenda.Add(jur);
            //        }
            //        agJur.Add(jur);
            //        agFis.Add(fis);
            //    }
            //    else if (escolha == "2")
            //    {
            //        Console.WriteLine("Você quer pesquisar uma PF ou uma PJ?");
            //        Console.WriteLine("1 - PF // 2 - PJ");
            //        escolha = Console.ReadLine();
            //        if (escolha == "1")
            //        {
            //            Console.WriteLine("Insira o nome e / ou o CPF");
            //            fis.Nome = Console.ReadLine();
            //            fis.Cpf = Console.ReadLine();
            //            for (int i = 0; i < agenda.Count; i++)
            //            {
            //                if (fis.Cpf == agFis[i].Cpf || agenda[i].Nome == fis.Nome)
            //                {
            //                    if (fis.Cpf != null)
            //                    {
            //                        Console.WriteLine(agFis[i].Nome);
            //                        Console.WriteLine(agFis[i].Cpf);
            //                        Console.WriteLine(agFis[i].Email);
            //                    }
            //                }
            //            }
            //        }
            //        else if (escolha == "2")
            //        {
            //            Console.WriteLine("Insira o nome e / ou o CNPJ");
            //            jur.Nome = Console.ReadLine();
            //            jur.Cnpj = Console.ReadLine();
            //            for (int i = 0; i < agenda.Count; i++)
            //            {
            //                if (jur.Cnpj == agJur[i].Cnpj || agenda[i].Nome == jur.Nome)
            //                {
            //                    if (jur.Cnpj != null)
            //                    {
            //                        Console.WriteLine(agJur[i].Nome);
            //                        Console.WriteLine(agJur[i].Cnpj);
            //                        Console.WriteLine(agJur[i].Email);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    else if (escolha == "3")
            //    {
            //        Console.WriteLine("Você quer remover uma PF ou uma PJ?");
            //        Console.WriteLine("1 - PF // 2 - PJ");
            //        escolha = Console.ReadLine();
            //        if (escolha == "1")
            //        {
            //            Console.WriteLine("Insira o nome e / ou o CPF");
            //            fis.Nome = Console.ReadLine();
            //            fis.Cpf = Console.ReadLine();
            //            for (int i = 0; i < agenda.Count; i++)
            //            {
            //                if (fis.Cpf == agFis[i].Cpf || agenda[i].Nome == fis.Nome)
            //                {
            //                    for (int j = 0; j < agFis.Count; j++)
            //                    {
            //                        if (fis.Cpf == agFis[j].Cpf || agenda[i].Nome == fis.Nome)
            //                        {
            //                            agFis.RemoveAt(j);
            //                            agenda.RemoveAt(i);
            //                            Console.WriteLine("Item removido");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        else if (escolha == "2")
            //        {
            //            Console.WriteLine("Insira o nome e / ou o CNPJ");
            //            jur.Nome = Console.ReadLine();
            //            jur.Cnpj = Console.ReadLine();
            //            for (int i = 0; i < agenda.Count; i++)
            //            {
            //                if (jur.Cnpj == agJur[i].Cnpj || agenda[i].Nome == jur.Nome)
            //                {
            //                    for (int j = 0; j < agJur.Count; j++)
            //                    {
            //                        if (jur.Cnpj == agJur[j].Cnpj || agenda[i].Nome == jur.Nome)
            //                        {
            //                            agJur.RemoveAt(j);
            //                            agenda.RemoveAt(i);
            //                            Console.WriteLine("Item removido");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("CPF");
            //        List<Fisica> fisOrganizado = agFis.OrderBy(x => x.Cpf).ToList();
            //        foreach (var item in fisOrganizado)
            //        {
            //            if (item.Cpf != null)
            //            {
            //                item.MostrarAgenda();
            //            }
            //        }
            //        Console.WriteLine("CNPJ");
            //        List<Juridica> jurOrganizado = agJur.OrderBy(x => x.Cnpj).ToList();
            //        foreach (var item in jurOrganizado)
            //        {
            //            if (item.Cnpj != null)
            //            {
            //                item.MostrarAgenda();
            //            }
            //        }
            //    }
            //}

            ////02

            //while (true)
            //{
            //    List<Produto> produtos = new List<Produto>();
            //    Mouse mouse = new Mouse();
            //    Livro livro = new Livro();

            //    mouse.Dpi = 150;
            //    mouse.Modelo = "Modelo Mouse Doméstico";
            //    mouse.Nome = "Nome Mouse Doméstico";
            //    mouse.Preco = 100;
            //    mouse.Tipo = "Doméstico";
            //    produtos.Add(mouse);
            //    mouse = new Mouse();

            //    mouse.Dpi = 100;
            //    mouse.Modelo = "Modelo Mouse";
            //    mouse.Nome = "Nome Mouse";
            //    mouse.Preco = 50;
            //    mouse.Tipo = "Gamer";
            //    produtos.Add(mouse);

            //    livro.Autor = "Autor livro";
            //    livro.Estilo = "Estilo livro";
            //    livro.Nome = "Nome livro";
            //    livro.Preco = 60;
            //    livro.Tipo = "Tipo livro";
            //    produtos.Add(livro);
            //    livro = new Livro();

            //    livro.Autor = "Autor livro 2";
            //    livro.Estilo = "Estilo livro 2";
            //    livro.Nome = "Nome livro 2";
            //    livro.Preco = 600;
            //    livro.Tipo = "Tipo livro 2";
            //    produtos.Add(livro);

            //    Console.WriteLine("Itens disponíveis:");
            //    for (int i = 0; i < produtos.Count; i++)
            //    {
            //        Console.Write("Item {0} =>", i + 1);
            //        produtos[i].CalculaPreco();
            //    }
            //    List<int> carrinho = new List<int>();
            //    while (true)
            //    {
            //        Console.WriteLine("Qual item você deseja?");
            //        Console.WriteLine("Caso insira 0, será encerrada a compra");
            //        int escolha = int.Parse(Console.ReadLine());
            //        if (escolha == 0)
            //        {
            //            break;
            //        }
            //        escolha--;
            //        carrinho.Add(escolha);
            //    }
            //    double precoCompra = 0;
            //    foreach (var item in carrinho)
            //    {
            //        produtos[item].CalculaPreco();
            //        precoCompra += produtos[item].Preco;
            //    }
            //    Console.WriteLine("Preço final da compra: {0:c}", precoCompra);
            //    Console.ReadKey();
            //}

            //Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03
            //01
            List<Transacao> listaTransacoesConta = new List<Transacao>();
            for (int i = 0; i < 5; i++)
            {
                Random ran = new Random();
                Transacao transacao = new Transacao();
                transacao.DataTransacao = ""+i;
                transacao.ValorTransacao = ran.Next(1, 1501);
                listaTransacoesConta.Add(transacao);
            }
            List<Transacao> listaTransacoesPoupanca = new List<Transacao>();
            for (int i = 0; i < 5; i++)
            {
                Random ran = new Random();
                Transacao transacao = new Transacao();
                transacao.DataTransacao = "" + i;
                transacao.ValorTransacao = ran.Next(1, 1501);
                listaTransacoesConta.Add(transacao);
            }
            List<Transacao> listaTransacoesLimite = new List<Transacao>();
            for (int i = 0; i < 5; i++)
            {
                Random ran = new Random();
                Transacao transacao = new Transacao();
                transacao.DataTransacao = "" + i;
                transacao.ValorTransacao = ran.Next(1, 1501);
                listaTransacoesConta.Add(transacao);
            }

            Conta conta = new Conta();
            Poupanca poupanca = new Poupanca();
            Limite limite = new Limite();
            conta.Nome = "Conta normal";
            conta.NumeroConta = 1234;
            conta.Saldo = 2000;
            conta.Transacoes = listaTransacoesConta;
            conta.Deposito();
            Console.WriteLine();
            conta.ImpressaoExtrato();
            Console.WriteLine();
            conta.Retirada();
            Console.WriteLine();
            conta.ExibirDados();
            
            Console.ReadKey();
            Console.Clear();

            poupanca.DiaAniversario = 2;
            poupanca.Nome = "Conta poupança";
            poupanca.NumeroConta = 4312;
            poupanca.Saldo = 1000;
            poupanca.Transacoes = listaTransacoesPoupanca;
            poupanca.Retirada();
            poupanca.ImpressaoExtrato();
            poupanca.ExibirDados();
            poupanca.Deposito();
            
            Console.ReadKey();
            Console.Clear();
            limite.Nome = "Conta limite";
            limite.NumeroConta = 235432;
            limite.Saldo = 1500;
            limite.Transacoes = listaTransacoesLimite;
            limite.ValorLimite = 500;
            limite.ImpressaoExtrato();
            limite.Deposito();
            limite.Retirada();
            limite.ExibirDados();
        }
    }
}