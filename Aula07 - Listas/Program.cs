using System;
using System.Collections.Generic;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01
            //List<string> dados = new List<string>();
            //Console.WriteLine("Insira o dado 1");
            //string input = Console.ReadLine();
            //dados.Add(input);
            //Console.WriteLine();
            //Console.WriteLine("Insira o dado 2");
            //input = Console.ReadLine();
            //dados.Add(input);
            //Console.WriteLine();
            //foreach (var p in dados)
            //{
            //    Console.WriteLine(p);
            //}

            ////02
            //List<double> notas = new List<double>();
            //double media = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira a nota " + (i+1));
            //    double valor = double.Parse(Console.ReadLine());
            //    notas.Add(valor);
            //    media += valor;
            //}
            //media /= 3;
            //Console.WriteLine("A média é: " + media);

            ////03
            //List<int> valores = new List<int>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o valor " + (i + 1));
            //    int valor = int.Parse(Console.ReadLine());
            //    valores.Add(valor);
            //}

            //if (valores[0] > valores[1] && valores[0] > valores[2])
            //{
            //    Console.WriteLine("O maior é: " + valores[0]);
            //}
            //else if (valores[1] > valores[2])
            //{
            //    Console.WriteLine("O maior é: " + valores[1]);
            //}
            //else if (valores[2] > valores[1])
            //{
            //    Console.WriteLine("O maior é: " + valores[2]);
            //}
            //else
            //{
            //    Console.WriteLine("São todos iguais");
            //}

            ////04
            //List<int> valores = new List<int>();
            //int multiplicacao = 1;
            //while (true)
            //{
            //    Console.WriteLine("Insira um valor");
            //    int valor = int.Parse(Console.ReadLine());
            //    if (valor == 0)
            //    {
            //        break;
            //    }
            //    valores.Add(valor);
            //}

            //foreach (var item in valores)
            //{
            //    multiplicacao *= item;
            //}
            //Console.WriteLine(multiplicacao);

            ////05
            //List<int> valores = new List<int>();
            //int auxcomp = 0;
            //while (true)
            //{
            //    Console.WriteLine("Insira um valor");
            //    int valor = int.Parse(Console.ReadLine());
            //    if (valor < auxcomp)
            //    {
            //        Console.WriteLine("O valor é menor que o valor anterior");
            //        Console.WriteLine("Insira um valor novamente!");
            //    }
            //    else
            //    {
            //        valores.Add(valor);
            //        auxcomp = valor;
            //    }
            //}

            ////06
            //List<string> user = new List<string>();
            //List<string> password = new List<string>();
            //user.Add("admin");
            //password.Add("password");

            //while (true)
            //{
            //    Console.WriteLine("Insira seu usuário e sua senha");
            //    string usuario = Console.ReadLine();
            //    string senha = Console.ReadLine();
            //    if (usuario == "admin" && senha == "password")
            //    {
            //        while (true)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Qual opção você deseja?");
            //            Console.WriteLine("1 - Criar conta / 2 - Deletar conta / 3 - LogOut");
            //            int escolha = int.Parse(Console.ReadLine());
            //            if (escolha == 1)
            //            {
            //                if (user.Count > 5)
            //                {
            //                    Console.WriteLine("Número de usuários excedido!");
            //                    Console.ReadKey();
            //                }
            //                else
            //                {
            //                    while (true)
            //                    {
            //                        bool y = false;
            //                        Console.WriteLine("Insira o usuário e a senha");
            //                        usuario = Console.ReadLine();
            //                        senha = Console.ReadLine();
            //                        foreach (var item in user)
            //                        {
            //                            if (item == usuario)
            //                            {
            //                                y = true;
            //                                break;
            //                            }
            //                        }
            //                        if (y == false)
            //                        {
            //                            user.Add(usuario);
            //                            password.Add(senha);
            //                            break;
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Usuário já existe");
            //                            Console.ReadKey();
            //                        }
            //                    }
            //                }
            //            }

            //            else if (escolha == 2)
            //            {
            //                int indiceUser = 0;
            //                Console.WriteLine("Mostrando usuários:");
            //                foreach (var item in user)
            //                {
            //                    Console.WriteLine(item);
            //                }
            //                Console.WriteLine();
            //                Console.WriteLine("Qual usuário você deseja deletar?");
            //                string deletar = Console.ReadLine();

            //                foreach (var item in user)
            //                {
            //                    if (deletar == item)
            //                    {
            //                        indiceUser = user.IndexOf(deletar);
            //                        user.RemoveAt(indiceUser);
            //                        password.RemoveAt(indiceUser);
            //                        Console.WriteLine("Usuário deletado!");
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Fazendo LogOut");
            //                break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        foreach (var item in user)
            //        {
            //            if (usuario == item)
            //            {
            //                foreach (var p in password)
            //                {
            //                    if (senha == p)
            //                    {
            //                        Console.WriteLine("Login efetuado!");
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////////////
            ///Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            ////01
            //List<string> nomes = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Insira um nome ou N para sair");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "N")
            //    {
            //        break;
            //    }
            //    nomes.Add(escolha);
            //}
            //foreach (var item in nomes)
            //{
            //    Console.WriteLine(item);
            //}

            ////02
            //List<double> notas = new List<double>();
            //while (true)
            //{
            //    Console.WriteLine("Insira uma nota");
            //    string nota = Console.ReadLine();
            //    double notaD;
            //    if (nota == "N")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        notaD = Convert.ToDouble(nota);
            //        notas.Add(notaD);
            //    }
            //}
            //double somaNota = 0;
            //foreach (var item in notas)
            //{
            //    somaNota += item;
            //}
            //somaNota /= notas.Count;
            //Console.WriteLine(somaNota);

            ////03
            //List<int> numeros = new List<int>();
            //while (true)
            //{
            //    Console.WriteLine("Insira uma numero");
            //    string num = Console.ReadLine();
            //    if (num == "N")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        int numI = Convert.ToInt32(num);
            //        numeros.Add(numI);
            //    }
            //}
            //numeros.Sort();
            //Console.WriteLine(numeros[0]);
            //Console.WriteLine(numeros[(numeros.Count - 1)]);

            ////04
            //List<string> nomes = new List<string>();
            //List<int> anoNasc = new List<int>();
            //List<string> nomesAtualizados = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Insira o nome:");
            //    Console.WriteLine("Digite N se desejar encerrar o programa");
            //    string nome = Console.ReadLine();
            //    if (nome == "N")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Insira o ano de nascimento");
            //    int ano = int.Parse(Console.ReadLine());
            //    nomes.Add(nome);
            //    anoNasc.Add(ano);
            //}
            //for (int i = 0; i < nomes.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (anoNasc[j - 1] > anoNasc[j])
            //        {
            //            // c = a 
            //            // a = b 
            //            // b = c
            //            string tempNome = nomes[j];
            //            int tempAno = anoNasc[j]; //int
            //            nomes[j] = nomes[j - 1];
            //            anoNasc[j] = anoNasc[j - 1]; //int
            //            nomes[j - 1] = tempNome;
            //            anoNasc[j - 1] = tempAno; //int
            //        }
            //    }
            //}
            //for (int i = 0; i < nomes.Count; i++)
            //{
            //    Console.Write("Nome: " + nomes[i] + " Ano de nascimento: " + anoNasc[i]);
            //    Console.WriteLine();
            //}

            ////05
            //List<string> placas = new List<string>();
            //List<double> hEntrada = new List<double>();
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("O que você deseja fazer?");
            //    Console.WriteLine("1 - Entrar / 2 - Sair / 3 - Encerrar");
            //    int escolha = int.Parse(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        Console.Clear();
            //        if (placas.Count < 11)
            //        {
            //            Console.WriteLine("Insira a placa");
            //            string placa = Console.ReadLine();
            //            Console.WriteLine("Insira a hora de entrada");
            //            double hE = double.Parse(Console.ReadLine());
            //            placas.Add(placa);
            //            hEntrada.Add(hE);
            //            Console.WriteLine();
            //            Console.WriteLine("Usuário adicionado!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Estacionamento cheio!");
            //        }
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.Clear();
            //        for (int i = 0; i < placas.Count; i++)
            //        {
            //            Console.WriteLine("Placa: {0}, Hora de entrada: {1}", placas[i], hEntrada[i]);
            //        }
            //        int indicePlaca = 0;
            //        bool placaEncontrada = false;
            //        Console.WriteLine("Insira a placa que está saindo");
            //        string placa = Console.ReadLine();
            //        foreach (var item in placas)
            //        {
            //            if (item == placa)
            //            {
            //                indicePlaca = placas.IndexOf(item);
            //                placaEncontrada = true;
            //            }
            //        }
            //        if (placaEncontrada == true)
            //        {
            //            Console.WriteLine("Qual o horário de saída?");
            //            double hS = double.Parse(Console.ReadLine());
            //            if (hS < hEntrada[indicePlaca])
            //            {
            //                Console.WriteLine("Erro, o horário de saída é menor que o horário de entrada");
            //                Console.ReadKey();
            //            }
            //            else
            //            {
            //                double valorEstacionamento = 4 * (hS - hEntrada[indicePlaca]);
            //                Console.WriteLine("O valor do estacionamento da placa {0} ficou de: R${1}", placa, valorEstacionamento);
            //                placas.RemoveAt(indicePlaca);
            //                hEntrada.RemoveAt(indicePlaca);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Placa não encontrada!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Encerrando estacionamento!");
            //        break;
            //    }
            //}
        }
    }
}
