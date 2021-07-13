using System;

namespace Aula09PT8___EnumELambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("ID: {0}, Nome: {1}",i+1,(Nomes)i);
            //}
            //Console.WriteLine("Qual ID você deseja?");
            //int escolha = int.Parse(Console.ReadLine());
            //escolha--;
            //Console.WriteLine("Nome que você escolheu: " + (Nomes)escolha);
            //Console.WriteLine(Convert.ToInt32((Nomes)escolha));

            //    //2
            //    Func<int, int> eleva = x =>
            //    {
            //        if (x <= 10)
            //        {
            //            return x * x;
            //        }
            //        else
            //        {
            //            return x;
            //        }
            //    };

            //    Console.WriteLine("Insira um numero");
            //    int numero = int.Parse(Console.ReadLine());
            //    Console.WriteLine(eleva(numero));
            //    Teste(eleva(numero));


            //}
            //public static void Teste(int j)
            //{
            //    Console.WriteLine(j * j);
            //}

            ////03
            //for (int i = 2; i < 11; i++)
            //{
            //    Console.WriteLine("Potência de: " + i);
            //    Console.WriteLine(Convert.ToInt32((Potencias)i) * Convert.ToInt32((Potencias)i));
            //}

            ////04
            //Console.WriteLine("Quais funcionários você deseja contratar?");
            //Console.WriteLine("Cargo: {0}, Salário: {1:c}", Cargos.Chapeiro, Convert.ToInt32(Cargos.Chapeiro));
            //Console.WriteLine("Cargo: {0}, Salário: {1:c}", Cargos.Caixa, Convert.ToInt32(Cargos.Caixa));
            //Console.WriteLine("Cargo: {0}, Salário: {1:c}", Cargos.Gerente, Convert.ToInt32(Cargos.Gerente));
            //Console.WriteLine("Cargo: {0}, Salário: {1:c}", Cargos.Dono, Convert.ToInt32(Cargos.Dono));

            //Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            //01 & 02
            Notas notas = new Notas();
            notas.Cem = 2;
            notas.Cinquenta = 2;
            notas.Vinte = 2;
            notas.Dez = 2;
            notas.Cinco = 2;
            notas.Dois = 2;
            Action<int> saque = x =>
            {
                int cem = 0;
                int cinquenta = 0;
                int vinte = 0;
                int dez = 0;
                int cinco = 0;
                int dois = 0;
                while (x > 0)
                {
                    if (x % 100 == 0 && notas.Cem > 0)
                    {
                        notas.Cem--;
                        cem++;
                        x -= 100;
                    }
                    else if (x % 50 == 0 && notas.Cinquenta > 0)
                    {
                        notas.Cinquenta--;
                        cinquenta++;
                        x -= 50;
                    }
                    else if (x % 20 == 0 && notas.Vinte > 0)
                    {
                        notas.Vinte--;
                        vinte++;
                        x -= 20;
                    }
                    else if (x % 10 == 0 && notas.Dez > 0)
                    {
                        notas.Dez--;
                        dez++;
                        x -= 10;
                    }
                    else if (x % 5 == 0 && notas.Cinco > 0)
                    {
                        notas.Cinco--;
                        cinco++;
                        x -= 5;
                    }
                    else if (x % 2 == 0 && notas.Dois > 0)
                    {
                        notas.Dois--;
                        dois++;
                        x -= 2;
                    }
                    else
                    {
                        int cedulas = 0;
                        cedulas += notas.Cem + notas.Cinquenta + notas.Vinte + notas.Dez + notas.Cinco + notas.Dois;
                        if (cedulas == 0)
                        {
                            Console.WriteLine("Não há cédulas suficientes!");
                            notas.Cem += cem;
                            notas.Cinquenta += cinquenta;
                            notas.Vinte += vinte;
                            notas.Dez += dez;
                            notas.Cinco += cinco;
                            notas.Dois += dois;
                            x = -2;
                        }
                        else
                        {
                            x -= 2;
                            dois++;
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("Tente outro valor!");
                    //    break;
                    //}
                }
                if (x != -2)
                {
                    Console.WriteLine("Sacando suas notas!");
                    Console.WriteLine("Quantidade de notas de 100: " + cem);
                    Console.WriteLine("Quantidade de notas de 50: " + cinquenta);
                    Console.WriteLine("Quantidade de notas de 20: " + vinte);
                    Console.WriteLine("Quantidade de notas de 10: " + dez);
                    Console.WriteLine("Quantidade de notas de 5: " + cinco);
                    Console.WriteLine("Quantidade de notas de 2: " + dois);
                    Console.WriteLine();         
                }
            };
            while (true)
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Inserir cédulas");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver cédulas");
                Console.WriteLine("4 - Sair");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    int quantidade = 0;
                    Console.WriteLine("Quantas cédulas de 100 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Cem += quantidade;
                    Console.WriteLine("Quantas cédulas de 50 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Cinquenta += quantidade;
                    Console.WriteLine("Quantas cédulas de 20 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Vinte += quantidade;
                    Console.WriteLine("Quantas cédulas de 10 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Dez += quantidade;
                    Console.WriteLine("Quantas cédulas de 5 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Cinco += quantidade;
                    Console.WriteLine("Quantas cédulas de 2 você deseja adicionar?");
                    quantidade = int.Parse(Console.ReadLine());
                    notas.Dois += quantidade;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Insira a quantidade que você deseja sacar!");
                    int valor = int.Parse(Console.ReadLine());
                    saque(valor);
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Cédulas de 100: " + notas.Cem);
                    Console.WriteLine("Cédulas de 50: " + notas.Cinquenta);
                    Console.WriteLine("Cédulas de 20: " + notas.Vinte);
                    Console.WriteLine("Cédulas de 10: " + notas.Dez);
                    Console.WriteLine("Cédulas de 5: " + notas.Cinco);
                    Console.WriteLine("Cédulas de 2: " + notas.Dois);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
