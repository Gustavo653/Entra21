﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula09PT4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pes = new Pessoa();
            ////01
            //a

            //Console.WriteLine("Insira um nome");
            //pes.Nome = Console.ReadLine();
            //Console.WriteLine("Insira uma idade");
            //pes.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira um CPF");
            //pes.Cpf = Console.ReadLine();
            //Console.WriteLine("Insira um estado");
            //pes.Estado = Console.ReadLine();
            //Console.WriteLine("Insira uma cidade");
            //pes.Cidade = Console.ReadLine();
            //Console.WriteLine("Insira um número");
            //pes.Numero = Console.ReadLine();
            //Console.WriteLine("Insira uma rua");
            //pes.Rua = Console.ReadLine();
            //Console.WriteLine("\n");
            //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}"
            //    , pes.Nome
            //    , pes.Idade
            //    , pes.Cpf
            //    , pes.Estado
            //    , pes.Cidade
            //    , pes.Numero
            //    , pes.Rua
            //    );

            //Empresa emp = new Empresa();
            ////b

            //Console.WriteLine("Insira o nome da empresa");
            //emp.Nome = Console.ReadLine();
            //Console.WriteLine("Insira a quantidade de funcionários");
            //emp.QuantFunc = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira um estado");
            //emp.Estado = Console.ReadLine();
            //Console.WriteLine("Insira uma cidade");
            //emp.Cidade = Console.ReadLine();
            //Console.WriteLine("Insira um número");
            //emp.Numero = Console.ReadLine();
            //Console.WriteLine("Insira uma rua");
            //emp.Rua = Console.ReadLine();
            //Console.WriteLine("\n");
            //Console.WriteLine("{0} {1} {2} {3} {4} {5}"
            //    , emp.Nome
            //    , emp.QuantFunc
            //    , emp.Estado
            //    , emp.Cidade
            //    , emp.Numero
            //    , emp.Rua
            //    );

            //List<Habitacao> habitacoes = new List<Habitacao>();
            //c
            //for (int i = 0; i < 4; i++)
            //{
            //    Habitacao hab = new Habitacao();
            //    Console.WriteLine("Insira o nome do dono");
            //    hab.NomeDono = Console.ReadLine();
            //    Console.WriteLine("Insira o tipo de habitação");
            //    hab.TipoHab = Console.ReadLine();
            //    Console.WriteLine("Insira um estado");
            //    hab.Estado = Console.ReadLine();
            //    Console.WriteLine("Insira uma cidade");
            //    hab.Cidade = Console.ReadLine();
            //    Console.WriteLine("Insira um número");
            //    hab.Numero = Console.ReadLine();
            //    Console.WriteLine("Insira uma rua");
            //    hab.Rua = Console.ReadLine();
            //    habitacoes.Add(hab);
            //}

            //foreach (var item in habitacoes)
            //{
            //    Console.WriteLine(item.NomeDono);
            //    Console.WriteLine(item.TipoHab);
            //    Console.WriteLine(item.Estado);
            //    Console.WriteLine(item.Cidade);
            //    Console.WriteLine(item.Numero);
            //    Console.WriteLine(item.Rua);
            //}



            ////02
            //a
            //Pessoa2 pes = new Pessoa2();
            //pes.Nome = Console.ReadLine();
            //pes.Idade = int.Parse(Console.ReadLine());
            //pes.Dinheiro = double.Parse(Console.ReadLine());
            //pes.Dopamina = double.Parse(Console.ReadLine());

            //while (true)
            //{
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Comer");
            //    Console.WriteLine("2 - Trabalhar");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "1")
            //    {
            //        Console.WriteLine("Quantos KG você vai comer?");
            //        double kilos = double.Parse(Console.ReadLine());
            //        pes.Dopamina += pes.Comer(kilos);
            //        Console.WriteLine("Sua dopamina atual é de: " + pes.Dopamina);
            //    }
            //    else if (escolha == "2")
            //    {
            //        Console.WriteLine("Quantas horas você vai trabalhar?");
            //        int horas = int.Parse(Console.ReadLine());
            //        pes.Dinheiro += pes.Trabalhar(horas);
            //        Console.WriteLine("Seu dinheiro atual é de: " + pes.Dinheiro);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            ////b
            //List<Cachorro> cachorros = new List<Cachorro>();
            //Console.WriteLine("Preencha os cachorros");
            //for (int i = 0; i < 2; i++)
            //{
            //    Cachorro cao = new Cachorro();
            //    cao.Nome = Console.ReadLine();
            //    cao.Dopamina = double.Parse(Console.ReadLine());
            //    cao.Conforto = int.Parse(Console.ReadLine());
            //    cachorros.Add(cao);
            //}

            //while (true)
            //{
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Comer");
            //    Console.WriteLine("2 - Descansar");
            //    string opcao = Console.ReadLine();
            //    if (opcao == "1")
            //    {
            //        Console.WriteLine("Qual cachorro você deseja?");
            //        for (int i = 0; i < cachorros.Count; i++)
            //        {
            //            Console.WriteLine("ID do cachorro: " + (i+1) + " " + cachorros[i].Nome);
            //        }
            //        Console.WriteLine("Insira o ID que você deseja");
            //        int id = int.Parse(Console.ReadLine());
            //        id--;
            //        Console.WriteLine("Quantos KG de comida?");
            //        double kg = double.Parse(Console.ReadLine());
            //        cachorros[id].Dopamina += cachorros[id].Comer(kg);
            //    }
            //    else if (opcao == "2")
            //    {
            //        Console.WriteLine("Qual cachorro você deseja?");
            //        for (int i = 0; i < cachorros.Count; i++)
            //        {
            //            Console.WriteLine("ID do cachorro: " + (i + 1) + " " + cachorros[i].Nome);
            //        }
            //        Console.WriteLine("Insira o ID que você deseja");
            //        int id = int.Parse(Console.ReadLine());
            //        id--;
            //        Console.WriteLine("Quantas horas de descanso?");
            //        int horas = int.Parse(Console.ReadLine());
            //        cachorros[id].Conforto += cachorros[id].Descansar(horas);
            //    }
            //    else
            //    {
            //        foreach (var item in cachorros)
            //        {
            //            Console.WriteLine(item.Nome);
            //            Console.WriteLine(item.Dopamina);
            //            Console.WriteLine(item.Conforto);
            //        }
            //        break;
            //    }
            //}

            ////c
            //Funcionario func = new Funcionario();
            //func.Nome = Console.ReadLine();
            //func.Dinheiro = double.Parse(Console.ReadLine());

            //while (func.Dinheiro < 1520)
            //{
            //    func.Dinheiro += func.Trabalhar(1);
            //}

            //Console.WriteLine(func.Nome);
            //Console.WriteLine(func.Dinheiro);

            ////Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            ////1
            //Calculadora calc = new Calculadora();
            //CalculadoraCientifica calcCientifica = new CalculadoraCientifica();
            //CalculadoraPersistente calcPersistente = new CalculadoraPersistente();
            ////a
            //calc.Soma(1, 2);
            //calc.Subtrair(1, 2);
            //calc.Multiplicar(1, 2);
            //calc.Divisao(1, 2);
            ////b
            //calcCientifica.Potenciacao(5);
            //calcCientifica.Radiciacao(5);
            ////c
            //while (true)
            //{
            //    Console.WriteLine("Qual operação você deseja fazer?");
            //    double soma = calc.Soma(1, 3);
            //    Console.WriteLine(soma);
            //    calcPersistente.GuardarValor(soma);
            //    Console.WriteLine("Deseja reutilizar o valor?");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "Sim")
            //    {
            //        double a = calcPersistente.Soma(soma, 3);
            //        Console.WriteLine(a);
            //    }
            //}

            ////2            
            //while (true)
            //{
            //    Console.WriteLine("Insira o valor do pagamento");
            //    double vp = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Insira a data de pagamento");
            //    string dp = Console.ReadLine();
            //    Console.WriteLine("Qual será a forma de pagamento?");
            //    string opcao = Console.ReadLine();
            //    opcao.ToLower();
            //    if (opcao == "credito")
            //    {
            //        CCredito credito = new CCredito();
            //        credito.ValorPagamento = vp;
            //        credito.DataPagamento = dp;
            //        credito.Calcular(credito.ValorPagamento);
            //    }
            //    else if (opcao == "debito")
            //    {
            //        CDebito debito = new CDebito();
            //        debito.ValorPagamento = vp;
            //        debito.DataPagamento = dp;
            //        debito.Calcular(debito.ValorPagamento);
            //    }
            //    else
            //    {
            //        Boleto bol = new Boleto();
            //        bol.CodBarra = Console.ReadLine();
            //        bol.Banco = Console.ReadLine();
            //        bol.Agencia = Console.ReadLine();
            //        bol.ValorPagamento = vp;
            //        bol.DataPagamento = dp;
            //        Console.WriteLine("{0} {1} {2} {3} {4}"
            //            , bol.CodBarra
            //            , bol.Banco
            //            , bol.Agencia
            //            , bol.DataPagamento
            //            , bol.ValorPagamento
            //            );
            //    }
            //}

            //CaixaEletronico cx = new CaixaEletronico();
            //cx.NumConta = 1234;
            //cx.SenhaConta = 123;
            //cx.ValorConta = 2000;
            //cx.Cpf = "123.456.789-00";
            //cx.Id = 3;
            //cx.Nome = "Gustavo";
            //cx.ValorInterno = 1000;

            //while (true)
            //{
            //    Console.WriteLine("Insira o número da sua conta e sua senha");
            //    string login = Console.ReadLine();
            //    double pswd = double.Parse(Console.ReadLine());
            //    if (login == "1234" && pswd == 123)
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("MENU");
            //            Console.WriteLine("1 - Extrato");
            //            Console.WriteLine("2 - Saque");
            //            Console.WriteLine("3 - Sair");
            //            login = Console.ReadLine();
            //            if (login == "1")
            //            {
            //                Console.WriteLine(cx.Nome);
            //                Console.WriteLine(cx.Cpf);
            //                Console.WriteLine("Valor restante possível de sacar em Caixa Eletrônico: " + cx.ValorInterno);
            //                Console.WriteLine("Saldo: " + cx.ValorConta);
            //            }
            //            else if (login == "2")
            //            {
            //                Console.WriteLine("Quanto você deseja sacar?");
            //                pswd = double.Parse(Console.ReadLine());
            //                if (pswd < cx.ValorConta && pswd < cx.ValorInterno)
            //                {
            //                    Console.WriteLine("Saque efetuado!");
            //                    Console.WriteLine("Valor: " + pswd);
            //                    cx.ValorInterno -= pswd;
            //                    cx.ValorConta -= pswd;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Você excedeu seu limite diário!");
            //                }
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Credenciais erradas, tente novamente");
            //    }
            //}
            //
            //List<Funcionario1> funcs = new List<Funcionario1>();
            //int escolha;
            //for (int i = 0; i < 6; i++)
            //{
            //    Funcionario1 func = new Funcionario1();

            //    if (i == 5)
            //    {
            //        Console.WriteLine("Gerando gerente!");
            //        func.Cargo = "Gerente";
            //        func.Salario = 2485.64 * (funcs.Count-1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("O funcionário é peão ou entregador?");
            //        Console.WriteLine("1 - peão / 2 - entregador");
            //        escolha = int.Parse(Console.ReadLine());
            //        if (escolha == 1)
            //        {
            //            func.Cargo = "Peão";
            //            Console.WriteLine("Insira o salário");
            //            double salario = double.Parse(Console.ReadLine());
            //            func.Salario = salario;
            //        }
            //        else
            //        {
            //            func.Cargo = "Entregador";
            //            Console.WriteLine("Insira o salário");
            //            double salario = double.Parse(Console.ReadLine());
            //            func.Salario = salario;
            //        }
            //    }
            //    funcs.Add(func);
            //}
            //while (true)
            //{
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Aumento");
            //    Console.WriteLine("2 - Demitir");
            //    Console.WriteLine("3 - Fechamento");
            //    escolha = int.Parse(Console.ReadLine());

            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Mostrando todos os funcionários e seus respectivos ID's");
            //        for (int i = 0; i < funcs.Count; i++)
            //        {
            //            if (i != (funcs.Count - 1))
            //            {
            //                Console.WriteLine("ID: " + (i+1));
            //                Console.WriteLine(funcs[i].Cargo);
            //                Console.WriteLine(funcs[i].Salario);
            //            }
            //        }
            //        Console.WriteLine("Qual ID você deseja?");
            //        escolha = int.Parse(Console.ReadLine());
            //        escolha--;
            //        if (escolha == (funcs.Count - 1))
            //        {
            //            Console.WriteLine("Funcionário inválido!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Você quer aumentar quanto?");
            //            Console.WriteLine("Dica: 1,20 = 20%");
            //            double aumento = double.Parse(Console.ReadLine());
            //            funcs[escolha].Salario *= aumento;
            //        }
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Mostrando todos os funcionários e seus respectivos ID's");
            //        for (int i = 0; i < funcs.Count; i++)
            //        {
            //            if (i != (funcs.Count - 1))
            //            {
            //                Console.WriteLine("ID: " + (i + 1));
            //                Console.WriteLine(funcs[i].Cargo);
            //                Console.WriteLine(funcs[i].Salario);
            //            }
            //        }
            //        Console.WriteLine("Qual ID você deseja?");
            //        escolha = int.Parse(Console.ReadLine());
            //        escolha--;
            //        if (escolha == (funcs.Count - 1))
            //        {
            //            Console.WriteLine("Funcionário inválido!");
            //        }
            //        else
            //        {
            //            funcs.RemoveAt(escolha);
            //            funcs[funcs.Count-1].Salario = 2485.64 * (funcs.Count - 1);
            //            Console.WriteLine("Funcionário demitido!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Realizando fechamento!");

            //        Console.WriteLine("Total de custos:");
            //        double totalCustos = 0;
            //        int contP = 0, contE = 0;
            //        foreach (var item in funcs)
            //        {
            //            totalCustos += item.Salario;
            //            if (item.Cargo == "Entregador")
            //            {
            //                contE++;
            //            }
            //            else
            //            {
            //                contP++;
            //            }
            //        }
            //        Console.WriteLine(totalCustos);

            //        double totalGanhos = 0;
            //        Console.WriteLine("Total de ganhos: ");
            //        totalGanhos += contP * 4785.26;
            //        totalGanhos += contE * 5324.82;
            //        totalGanhos += (contE+contP) * 2485.64;
            //        Console.WriteLine(totalGanhos);

            //        double total = 0;
            //        total += totalGanhos;
            //        total -= totalCustos;
            //        if (total > 0)
            //        {
            //            Console.WriteLine("Houve lucro!");
            //            Console.WriteLine(total);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Houve prejuízo!");
            //            Console.WriteLine(total);
            //        }
            //    }
            //}


            //Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03
            ////01a
            //List<Carro> carros = new List<Carro>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Carro car = new Carro();
            //    car.Proprietario = Console.ReadLine();
            //    car.KMRodados = int.Parse(Console.ReadLine());
            //    car.Combustivel = Console.ReadLine();
            //    car.CV = int.Parse(Console.ReadLine());
            //    car.Modelo = Console.ReadLine();
            //    car.Nome = Console.ReadLine();
            //    carros.Add(car);
            //}

            //List<Carro> carrosOrganizados = carros.OrderBy(x => x.CV).ToList();
            //foreach (var item in carrosOrganizados)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4} {5}"
            //        , item.Proprietario
            //        , item.KMRodados
            //        , item.Combustivel
            //        , item.CV
            //        , item.Modelo
            //        , item.Nome);
            //}

            ////01b
            //List<Aviao> aviaoes = new List<Aviao>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Aviao aviao = new Aviao();
            //    aviao.Combustivel = Console.ReadLine();
            //    aviao.CV = int.Parse(Console.ReadLine());
            //    aviao.Modelo = Console.ReadLine();
            //    aviao.Nome = Console.ReadLine();
            //    aviao.Empresa = Console.ReadLine();
            //    aviao.Linha = Console.ReadLine();
            //    aviaoes.Add(aviao);
            //}
            //Console.WriteLine("Insira a empresa que você deseja:");
            //string emp = Console.ReadLine();

            //foreach (var item in aviaoes)
            //{
            //    if (item.Empresa == emp)
            //    {
            //        Console.WriteLine("{0} {1} {2} {3} {4} {5}"
            //        , item.Empresa
            //        , item.Linha
            //        , item.Combustivel
            //        , item.CV
            //        , item.Modelo
            //        , item.Nome);
            //    }
            //}

            //01c
            List<Navio> navios = new List<Navio>();
            for (int i = 0; i < 3; i++)
            {
                Navio navio = new Navio();
                navio.Combustivel = Console.ReadLine();
                navio.CV = int.Parse(Console.ReadLine());
                navio.Modelo = Console.ReadLine();
                navio.Nome = Console.ReadLine();
                navio.Tamanho = int.Parse(Console.ReadLine());
                int qnt;
                while (true)
                {
                    qnt = int.Parse(Console.ReadLine());
                    if (qnt > 20 || qnt > 0)
                    {
                        Console.WriteLine("Insira um valor menor que 20 e maior que 0");
                    }
                    else
                    {
                        break;
                    }
                }
                navio.Cargo = new int[qnt];
                for (int j = 0; j < navio.Cargo.Length; j++)
                {
                    navio.Cargo[j] = 1;
                }

                navios.Add(navio);
            }

            List<Navio> naviosOrganizados = navios.OrderBy(x => x.Cargo.Length).ToList();

            Console.WriteLine("{0} {1} {2} {3} {4}"
                    , naviosOrganizados[naviosOrganizados.Count - 1].Tamanho
                    , naviosOrganizados[naviosOrganizados.Count - 1].Combustivel
                    , naviosOrganizados[naviosOrganizados.Count - 1].CV
                    , naviosOrganizados[naviosOrganizados.Count - 1].Modelo
                    , naviosOrganizados[naviosOrganizados.Count - 1].Nome);
            for (int i = 0; i < naviosOrganizados[naviosOrganizados.Count - 1].Cargo.Length; i++)
            {
                Console.WriteLine(naviosOrganizados[naviosOrganizados.Count - 1].Cargo[i]);
            }
        }
    }
}
