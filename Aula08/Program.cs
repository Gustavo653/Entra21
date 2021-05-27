using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            ////02
            //Console.WriteLine("Insira um número");
            //int n;
            //while (true)
            //{
            //    try
            //    {
            //        n = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Verifique se você digitou apenas números!");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("O número inserido é muito grande!");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Ocorreu um erro!");
            //    }
            //}
            //Console.WriteLine("Encerrando programa!");

            ////03
            //double[] media = new double[3];
            //double mediaCalculada = 0;
            //while (true)
            //{
            //    try
            //    {
            //        for (int i = 0; i < media.Length; i++)
            //        {
            //            Console.WriteLine("Insira o valor " + (i + 1));
            //            media[i] = double.Parse(Console.ReadLine());
            //            mediaCalculada += media[i];
            //        }
            //        mediaCalculada /= 3;
            //        Console.WriteLine(mediaCalculada);
            //        break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("O número é muito grande");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Insira apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Erro desconhecido");
            //    }
            //}

            //04
            int[] vet = new int[5];
            while (true)
            {
                try
                {
                    for (int i = 0; i < vet.Length; i++)
                    {
                        Console.WriteLine("Insira o valor " + (i + 1));
                        vet[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(vet);
                    Console.WriteLine("Menor: " + vet[0]);
                    Console.WriteLine("Maior: " + vet[4]);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Insira apenas números");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("O número inserido é muito grande");
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro");
                }
            }
        }
    }
}
