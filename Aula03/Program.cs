using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////exemplo do...while
            //int a = 0;
            //do
            //{
            //    a++;
            //    Console.WriteLine("Valor de a ->" + a);
            //}
            //while (a < 5);

            ////exemplo while
            //int b = 0;
            //while (b < 5)
            //{
            //    Console.WriteLine("Valor de b ->" + b);
            //    b++;
            //}

            ////exemplo for
            //int c = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    c = i;
            //    if (c > 4 && c < 8)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            ////exemplo for
            //int d = 0;
            //for (int i = 0; i < 1000000; i++)
            //{
            //    d = i * 2;
            //    if (d == 3 | d > 20)
            //    {
            //        Console.WriteLine(d);
            //        //break;
            //    }
            //}

            ////01
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////02
            //for (int i = 0; i < 24; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////03
            //Console.WriteLine("Insira um valor");
            //int valor = int.Parse(Console.ReadLine());
            //for (int i = 0; valor >= i; valor--)
            //{
            //    Console.WriteLine(valor);
            //}

            ////04
            //Console.WriteLine("Insira um valor");
            //int valor = int.Parse(Console.ReadLine());
            //if (valor > 0)
            //{
            //    for (int i = 0; valor >= i; valor--)
            //    {
            //        Console.WriteLine(valor);
            //    }
            //}
            //else
            //{ 
            //    for (int i = 0; valor <= i ; valor++)
            //    {
            //        Console.WriteLine(valor);
            //    }
            //}

            ////05
            //bool x = true;
            //while (x)
            //{
            //    Console.Write("Insira um valor:");
            //    int valor = int.Parse(Console.ReadLine());
            //    Console.Write("Se deseja encerrar o programa, digite exit agora, caso contrário aperte enter");
            //    string encerrar = Console.ReadLine();
            //    if (encerrar == "exit")
            //    {
            //        x = false;
            //    }

            //    if (valor > 24)
            //    {
            //        valor *= 2;
            //        Console.WriteLine(valor);
            //    }
            //    else if (valor > 0)
            //    {
            //        Console.WriteLine(valor);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Insira um valor novamente");
            //    }
            //}

            //06
            while (true)
            {
                Console.WriteLine("Insira o nome do aluno:");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira o CPF do aluno:");
                int cpf = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o endereço do aluno:");
                string endereco = Console.ReadLine();

                Console.WriteLine("O nome do aluno é: " + nome);
                Console.WriteLine("O CPF do aluno é: " + cpf);
                Console.WriteLine("O endereço do aluno é: " + endereco);

                Console.WriteLine("Você deseja adicionar mais um aluno?");
                nome = Console.ReadLine();

                if (nome == "n" || nome == "N")
                {
                    break;
                }
            }

            ////07
            //int total = 0;
            //for (int i = 0; i < 30; i++)
            //{
            //    Random ran = new Random();
            //    int dado = ran.Next(1, 7);
            //    Console.WriteLine("Face do dado: " + dado);
            //    Console.WriteLine();
            //    if (dado >= 3)
            //    {
            //        total += 10;
            //        Console.WriteLine("Parcial: " + total + ", " + i);
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        total -= 15;
            //        Console.WriteLine("Parcial: " + total + ", " + i);
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("O total foi de: " + total);

            //08
            bool x = true;
            while (x)
            {
                Console.WriteLine("Quantidade de queijo:");
                int quantQueijo = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de macarrão:");
                int quantMacarrao = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de feijão:");
                int quantFeijao = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de presunto:");
                int quantPresunto = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de pão:");
                int quantPao = int.Parse(Console.ReadLine());

                int quantTotal = quantQueijo + quantMacarrao + quantFeijao + quantPresunto + quantPao;
                double valorQueijo = quantQueijo * 4.5;
                double valorMacarrao = quantMacarrao * 5;
                double valorFeijao = quantFeijao * 4;
                double valorPresunto = quantPresunto * 5.5;
                double valorPao = quantPao * 3.75;
                if (quantQueijo > 3)
                {
                    valorQueijo *= 0.9;
                }
                if (quantMacarrao > 3)
                {
                    valorMacarrao *= 0.9;
                }

                double valorTotal = valorQueijo + valorMacarrao + valorFeijao + valorPresunto + valorPao;
                if (quantTotal > 7)
                {
                    valorTotal *= 0.9;
                }

                Console.WriteLine(valorTotal);
                string encerrar = Console.ReadLine();
                Console.WriteLine("Se deseja encerrar o programa, digite fim ou acabou");
                if (encerrar == "fim" || encerrar == "acabou")
                {
                    x = false;
                }
            }

            ////09
            //double resultado = 1;
            //Console.WriteLine("Insira o valor para fazer um fatorial: ");
            //int fatorial = int.Parse(Console.ReadLine());
            //while (fatorial != 1)
            //{
            //    resultado = resultado * fatorial;
            //    fatorial = fatorial - 1;
            //    Console.WriteLine(resultado);
            //}

            ////10
            //Console.WriteLine("Insira um valor");
            //int valor = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira quantas vezes este valor deve ser somado por ele mesmo");
            //int soma = int.Parse(Console.ReadLine());

            //while (soma > 0)
            //{
            //    valor = valor + valor;
            //    soma--;
            //}
            //Console.WriteLine(valor);

            ////11
            //Console.WriteLine("Insira o primeiro valor:");
            //int v1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o segundo valor:");
            //int v2 = int.Parse(Console.ReadLine());

            //double divisao = v1 / v2;
            //int resto = v1 % v2;
            //Console.WriteLine(v1 + " mod " + v2 + " = " + v2 + " x " + divisao + " + " + resto);

            ////Calculadora
            //while (true)
            //{
            //    string sair, c;

            //    Console.WriteLine("Insira o primeiro valor:");
            //    double n1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Se desejar encerrar o programa agora, digite exit ou close");
            //    sair = Console.ReadLine();
            //    if (sair == "exit" || sair == "close")
            //    {
            //        Environment.Exit(0);
            //    }
            //    Console.WriteLine("Se desejar apagar todas as operações e valores inseridos digite c");
            //    c = Console.ReadLine();
            //    if (c == "c")
            //    {
            //        n1 = 0;
            //        Console.Clear();
            //        Main(args);
            //    }

            //    Console.WriteLine("Insira o sinal da operação: | + | - | * | / | ^ |");
            //    char operacao = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Se desejar encerrar o programa agora, digite exit ou close");
            //    sair = Console.ReadLine();
            //    if (sair == "exit" || sair == "close")
            //    {
            //        Environment.Exit(0);
            //    }
            //    Console.WriteLine("Se desejar apagar todas as operações e valores inseridos digite c");
            //    c = Console.ReadLine();
            //    if (c == "c")
            //    {
            //        n1 = 0;
            //        Console.Clear();
            //        Main(args);
            //    }

            //    Console.WriteLine("Insira o segundo valor:");
            //    double n2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Se desejar encerrar o programa agora, digite exit ou close");
            //    sair = Console.ReadLine();
            //    if (sair == "exit" || sair == "close")
            //    {
            //        Environment.Exit(0);
            //    }
            //    Console.WriteLine("Se desejar apagar todas as operações e valores inseridos digite c");
            //    c = Console.ReadLine();
            //    if (c == "c")
            //    {
            //        n1 = 0; 
            //        n2 = 0;
            //        Console.Clear();
            //        Main(args);
            //    }

            //    if (operacao == '+')
            //    {
            //        double soma = n1 + n2;
            //        Console.WriteLine("Resultado = " + soma);
            //    }
            //    else if (operacao == '-')
            //    {
            //        double subtracao = n1 - n2;
            //        Console.WriteLine("Resultado = " + subtracao);
            //    }
            //    else if (operacao == '*')
            //    {
            //        double multiplicacao = n1 * n2;
            //        Console.WriteLine("Resultado = " + multiplicacao);
            //    }
            //    else if (operacao == '/')
            //    {
            //        double divisao = n1 / n2;
            //        Console.WriteLine("Resultado = " + divisao);
            //    }
            //    else if (operacao == '^')
            //    {
            //        double potenciacao = Math.Pow(n1, n2);
            //        Console.WriteLine("Resultado = " + potenciacao);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sinal inválido");
            //    }
            //}        }
        }
    }
}
