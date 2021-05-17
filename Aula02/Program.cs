using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            ////a //Lista exercicios Se 01
            //Console.WriteLine("Insira um número");
            //double na = double.Parse(Console.ReadLine());
            //if (na > 10)
            //{
            //    Console.WriteLine(na);
            //}
            //else
            //{
            //    Console.WriteLine("O valor é menor que 10");
            //}

            ////b
            //double nb1, nb2;
            //nb1 = double.Parse(Console.ReadLine());
            //nb2 = double.Parse(Console.ReadLine());

            //if (nb1 == nb2)
            //{
            //    Console.WriteLine("São iguais");
            //}
            //else
            //{
            //    Console.WriteLine("Não são iguais");
            //}

            ////c
            //double nc1, nc2;
            //nc1 = double.Parse(Console.ReadLine());
            //nc2 = double.Parse(Console.ReadLine());
            //if (nc1 > nc2)
            //{
            //    Console.WriteLine(nc1);
            //}
            //else
            //{
            //    Console.WriteLine(nc2);
            //}

            ////d
            //double nd1, nd2, nd3;
            //nd1 = double.Parse(Console.ReadLine());
            //nd2 = double.Parse(Console.ReadLine());
            //nd3 = double.Parse(Console.ReadLine());

            //if (nd1 > nd2 && nd1 > nd3)
            //{
            //    Console.WriteLine(nd1);
            //}
            //else if (nd2 > nd3)
            //{
            //    Console.WriteLine(nd2);
            //}
            //else
            //{
            //    Console.WriteLine(nd3);
            //}

            ////e
            //double ne = double.Parse(Console.ReadLine());
            //switch (ne)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    default:
            //        Console.WriteLine("Não computável");
            //        break;
            //}

            ////f
            //Random ran = new Random();
            //int valorMinimo = 1, valorMaximo = 7; //Intervalo do dado
            //int dado = ran.Next(valorMinimo, valorMaximo);

            //if (dado >= 3)
            //{
            //    Console.WriteLine("Você venceu");
            //}
            //else
            //{
            //    Console.WriteLine("Você perdeu");
            //}

            ////g
            //int ng;
            //ng = int.Parse(Console.ReadLine());

            //if (ng % 2 == 0)
            //{
            //    Console.WriteLine("Valor par");
            //}
            //else
            //{
            //    Console.WriteLine("Ímpar");
            //}

            ////h
            //double valorProd;
            //valorProd = double.Parse(Console.ReadLine());
            //if (valorProd > 254.50)
            //{
            //    Console.WriteLine("Valor original: " + valorProd);
            //    valorProd *= 0.72;
            //    Console.WriteLine("Valor com desconto: " + valorProd);
            //}
            //else
            //{
            //    Console.WriteLine("Valor original: " + valorProd);
            //    valorProd *= 0.79;
            //    Console.WriteLine("Valor com desconto: " + valorProd);
            //}

            ////i
            //double salarioFunc = double.Parse(Console.ReadLine());
            //if (salarioFunc <= 600)
            //{
            //    salarioFunc *= 1.3;
            //    Console.WriteLine(salarioFunc);
            //}
            //else if (salarioFunc <= 1100)
            //{
            //    salarioFunc *= 1.25;
            //    Console.WriteLine(salarioFunc);
            //}
            //else if ( salarioFunc <= 2400)
            //{
            //    salarioFunc *= 1.2;
            //    Console.WriteLine(salarioFunc);
            //}
            //else if (salarioFunc <= 3550)
            //{
            //    salarioFunc *= 1.15;
            //    Console.WriteLine(salarioFunc);
            //}
            //else
            //{
            //    salarioFunc *= 1.1;
            //    Console.WriteLine(salarioFunc);
            //}

            ////j
            Console.WriteLine("Insira o valor da compra: ");
            double valorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Possui cartão fidelidade? (S/N)");
            char cartFidelidade = char.Parse(Console.ReadLine());
            Console.WriteLine("É sua quinta compra? (S/N)");
            char quintaCompra = char.Parse(Console.ReadLine());

            if (valorCompra >= 200.01 && valorCompra <= 400)
            {
                valorCompra *= 0.9;
                Console.WriteLine("Valor desconto 10%: " + valorCompra);
            }
            else if (valorCompra >= 400.01)
            {
                valorCompra *= 0.8;
                Console.WriteLine("Valor desconto 20%: " + valorCompra);
            }

            if (cartFidelidade == 'S')
            {
                valorCompra *= 0.85;
                Console.WriteLine("Valor cartão fidelidade: " + valorCompra);
            }

            if (quintaCompra == 'S')
            {
                valorCompra *= 0.9;
                Console.WriteLine("Valor quinta compra: " + valorCompra);
            }

            Console.WriteLine("Valor final: " + valorCompra);

            ////Calculadora
            //Console.WriteLine("Insira o primeiro valor:");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o sinal da operação: | + | - | * | / | ^ |");
            //char operacao = char.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o segundo valor:");
            //double n2 = double.Parse(Console.ReadLine());

            //if (operacao == '+')
            //{
            //    double soma = n1 + n2;
            //    Console.WriteLine("Resultado = " + soma);
            //}
            //else if (operacao == '-')
            //{
            //    double subtracao = n1 - n2;
            //    Console.WriteLine("Resultado = " + subtracao);
            //}
            //else if (operacao == '*')
            //{
            //    double multiplicacao = n1 * n2;
            //    Console.WriteLine("Resultado = " + multiplicacao);
            //}
            //else if (operacao == '/')
            //{
            //    double divisao = n1 / n2;
            //    Console.WriteLine("Resultado = " + divisao);
            //}
            //else if (operacao == '^')
            //{
            //    double potenciacao = Math.Pow(n1, n2);
            //    Console.WriteLine("Resultado = " + potenciacao);
            //}
            //else
            //{
            //    Console.WriteLine("Sinal inválido");
            //}

            //Console.WriteLine("Oi");

            ////Lista 02 //Exercicios Se
            ////a
            //double queijo = 4.50, macarrao = 5, feijao = 4, presunto = 5.5; //Preços
            //Console.WriteLine("Insira a quantidade de unidades de queijo:");
            //int quantQueijo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de unidades de macarrão:");
            //int quantMacarrao = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de unidades de feijão:");
            //int quantFeijao = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de unidades de presunto:");
            //int quantPresunto = int.Parse(Console.ReadLine());

            //if (quantQueijo > 2) //desconto de 10% acima de 2 produtos
            //{
            //    queijo *= 0.9;
            //}
            //if (quantMacarrao > 2)
            //{
            //    macarrao *= 0.9;
            //}

            //int quantTotal = quantQueijo + quantMacarrao + quantFeijao + quantPresunto; //quantidade de itens
            //double valorQueijo = quantQueijo * queijo;
            //double valorMacarrao = quantMacarrao * macarrao;
            //double valorFeijao = quantFeijao * feijao;
            //double valorPresunto = quantPresunto * presunto;
            //double valorTotal = valorQueijo + valorFeijao + valorMacarrao + valorPresunto; //valor total da compra

            //Console.WriteLine();

            //if (quantTotal > 8)
            //{
            //    Console.WriteLine("A compra possui mais que 8 produtos");
            //    Console.WriteLine("Encerrando programa");
            //    Environment.Exit(0);
            //}
            //else if (quantTotal > 5)
            //{
            //    Console.WriteLine("O valor da compra sem o desconto foi de: " + valorTotal);
            //    valorTotal *= 0.95;
            //    Console.WriteLine("O valor da compra com o desconto foi de: " + valorTotal);
            //    Environment.Exit(0);
            //}
            //Console.WriteLine("O valor da compra sem o desconto foi de: " + valorTotal);

            //b

            //Console.WriteLine("Você acabou de abrir um baú");
            //Console.WriteLine("Neste baú tem:");
            //Console.WriteLine("1. Poção de vida"); //
            //Console.WriteLine("2. Poção de mana");
            //Console.WriteLine("3. 200 de ouro"); //
            //Console.WriteLine("4. Receita para poção");
            //Console.WriteLine("5. Pergaminho");

            //Console.WriteLine("Na sua mochila tem:");
            //Console.WriteLine("1. Poção de vida");
            //Console.WriteLine("2. Espada");
            //Console.WriteLine("3. 300 de ouro");
            //Console.WriteLine("4. Escudo");
            //Console.WriteLine("5. <vazio>");
            //Console.WriteLine("6. <vazio>");

            //Console.WriteLine("Auto coleta de itens que você já tem");
            //Console.WriteLine("Na sua mochila tem:");
            //Console.WriteLine("1. 2 Poção de vida");
            //Console.WriteLine("2. Espada");
            //Console.WriteLine("3. 500 de ouro");
            //Console.WriteLine("4. Escudo");
            //Console.WriteLine("5. <vazio>");
            //Console.WriteLine("6. <vazio>");

            //Console.WriteLine("Itens restantes no baú");
            //Console.WriteLine("2. Poção de mana");
            //Console.WriteLine("4. Receita para poção");
            //Console.WriteLine("5. Pergaminho");
            //Console.WriteLine("Há dois espaços vazios, qual dstes itens você deseja descartar?");
            //char escolha = char.Parse(Console.ReadLine());
            //if (escolha == 2)
            //{
            //    Console.WriteLine("Você descartou: 2. Poção de mana");
            //    Console.WriteLine("Na sua mochila tem:");
            //    Console.WriteLine("1. 2 Poção de vida");
            //    Console.WriteLine("2. Espada");
            //    Console.WriteLine("3. 500 de ouro");
            //    Console.WriteLine("4. Escudo");
            //    Console.WriteLine("5. Receita para poção");
            //    Console.WriteLine("6. Pergaminho");
            //}
            //else if (escolha == 4)
            //{
            //    Console.WriteLine("Você descartou: 4. Receita para poção");
            //    Console.WriteLine("Na sua mochila tem:");
            //    Console.WriteLine("1. 2 Poção de vida");
            //    Console.WriteLine("2. Espada");
            //    Console.WriteLine("3. 500 de ouro");
            //    Console.WriteLine("4. Escudo");
            //    Console.WriteLine("5. Poção de mana");
            //    Console.WriteLine("6. Pergaminho");
            //}
            //else
            //{
            //    Console.WriteLine("Você descartou: 5. Pergaminho");
            //    Console.WriteLine("Na sua mochila tem:");
            //    Console.WriteLine("1. 2 Poção de vida");
            //    Console.WriteLine("2. Espada");
            //    Console.WriteLine("3. 500 de ouro");
            //    Console.WriteLine("4. Escudo");
            //    Console.WriteLine("5. 2 Poção de mana");
            //    Console.WriteLine("6. Receita para poção");
            //}

            ////c
            //while (true)
            //{
            //    Console.WriteLine("Há gasolina para o seu Joaquin?");
            //    char gasolina = char.Parse(Console.ReadLine());
            //    if (gasolina == 'N')
            //    {
            //        Console.WriteLine("Seu joaquin não veio trabalhar");
            //        Environment.Exit(0);
            //    }
            //    Console.WriteLine("A grama está alta?");
            //    char grama = char.Parse(Console.ReadLine());
            //    if (grama == 'S')
            //    {
            //        Console.WriteLine("Seu joaquin foi embora nervoso");
            //        Environment.Exit(0);
            //    }
            //    Random ran = new Random();
            //    int pedra = ran.Next(0, 4);
            //    if (pedra == 0)
            //    {
            //        Console.WriteLine("Seu Joaquin achou uma pedra");
            //        Environment.Exit(0);
            //    }
            //}        }
        }
    }
}
