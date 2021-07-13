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

            //2
            Func<int, int> eleva = x =>
            {
                if (x <= 10)
                {
                    return x * x;
                }
                else
                {
                    return x;
                }
            };

            Console.WriteLine("Insira um numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(eleva(numero));
            Teste(eleva(numero));


        }
        public static void Teste(int j)
        {
            Console.WriteLine(j * j);
        }
    }
    }
}
