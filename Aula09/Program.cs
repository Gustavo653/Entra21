using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01
            //Console.WriteLine(Exec01(0));
            //Console.WriteLine(Exec01(1));

            ////02
            //Exec02();

            //03
            //Console.WriteLine(Exec03();

            ////04
            //Exec04(0, 1);
            //Exec04(1, 0);

            ////05
            //List<double> lista = new List<double>();
            //lista.Add(1);
            //lista.Add(3);
            //lista.Add(23532);
            //lista.Add(7);
            //Console.WriteLine(Exec05(lista));

            ////06
            //Console.WriteLine(Exec06(100));
            //Console.WriteLine(Exec06(5));

            Console.ReadKey();
        }
        public static int Exec01(int numero)
        {
            //if (numero >= 0)
            //{
            //    return 1;
            //}
            if (numero > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static void Exec02()
        {
            while (true)
            {
                Console.WriteLine("Insira um numero ou sair");
                string entrada = Console.ReadLine();
                //if (entrada == "sai")
                //{
                //    break;
                //}
                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(entrada);
                }
            }
        }
        public static bool Exec03(int numero1, int numero2)
        {
            //if (numero1 > numero2 || numero2 >= numero1)
            //{
            //    return true;
            //}
            if (numero1 > numero2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Exec04(int numero1, int numero2)
        {
            //if (numero2 > numero1)
            //{
            //    Console.WriteLine(numero1 + numero2);
            //}
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + numero2);
            }
            else
            {
                Console.WriteLine("Não computável");
            }
        }
        public static double Exec05(List<double> lista)
        {
            double maior = 0;
            foreach (var item in lista)
            {
                if (item > maior)
                {
                    maior = item;
                }
            }
            return maior;
        }
        public static int Exec06(int numero)
        {
            //if (numero > 0 || numero < 10)
            //{
            //    return 1;
            //}
            if (numero > 0 && numero < 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
