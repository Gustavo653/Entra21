using System;
using System.Collections.Generic;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            ////01
            //Program prog = new Program();
            //Console.WriteLine("Insira dois números");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //string a = prog.Compara01(x, y);
            //Console.WriteLine(a);

            ////02
            //Program prog = new Program();
            //Console.WriteLine("Insira um número");
            //int x = int.Parse(Console.ReadLine());
            //int a = prog.ParImpar02(x);
            //Console.WriteLine(a);

            ////03
            //Program prog = new Program();
            //Console.WriteLine("Insira um número");
            //int x = int.Parse(Console.ReadLine());
            //int a = prog.SinalNumero03(x);
            //Console.WriteLine(a);

            ////04
            //Program prog = new Program();
            //Console.WriteLine("Insira a temperatura");
            //int x = int.Parse(Console.ReadLine());
            //double a = prog.ConversaoTemp04(x);
            //Console.WriteLine(a);

            ////05
            //Program prog = new Program();
            //int[] notas = new int[3];
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("Insira a nota " + (i + 1));
            //    notas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Para média aritmética: A, média ponderada: P, mediana: M");
            //string escolha = Console.ReadLine();
            //double a = prog.Medias05(notas, escolha);
            //Console.WriteLine();
            //Console.WriteLine("Resultado: " + a);

            ////06
            //Program prog = new Program();
            //int[] valores = new int[5];
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + (i + 1));
            //    valores[i] = int.Parse(Console.ReadLine());
            //}
            //double a = prog.Formula06(valores);
            //Console.WriteLine(a);

            ////07
            //Program prog = new Program();
            //int[] catetos = new int[2];
            //for (int i = 0; i < catetos.Length; i++)
            //{
            //    Console.WriteLine("Insira o cateto " + (i + 1));
            //    catetos[i] = int.Parse(Console.ReadLine());
            //}
            //double a = prog.Hipotenusa07(catetos);
            //Console.WriteLine(a);

            ////08 // USANDO SORT
            //Program prog = new Program();
            //Console.WriteLine("Insira o número final");
            //int num = int.Parse(Console.ReadLine());
            //int a = prog.Ordenar08(num);
            //Console.WriteLine(a); // USANDO SORT


            //////////////////////////////////////////////////////////////////////////////////////////////
            ///Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02
            ///01
            //Program prog = new Program();
            //int[] valores = new int[4];
            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + (i+1));
            //    valores[i] = int.Parse(Console.ReadLine());
            //}
            //int a, b, c;
            //a = prog.CompararMaior01(valores[0], valores[1]);
            //b = prog.CompararMaior01(valores[2], valores[3]);
            //c = prog.CompararMaior01(a, b);
            //Console.WriteLine("O maior valor entre {0} e {1} é: {2}", valores[0], valores[1], a);
            //Console.WriteLine("O maior valor entre {0} e {1} é: {2}", valores[2], valores[3], b);
            //Console.WriteLine("O maior valor entre {0} e {1} é: {2}", a, b, c);

            ////02
            //Program prog = new Program();
            //Console.WriteLine("Insira o índice a ser procurado");
            //int indice = int.Parse(Console.ReadLine());
            //int a = prog.ProcurarVetor02(indice);
            //Console.WriteLine(a);

            ////03
            //Program prog = new Program();
            //Console.WriteLine("Você deseja inserir manualmente ou preencher automaticamente o vetor?");
            //string escolha = Console.ReadLine();
            //prog.OrganizaVetor03(escolha);

            ////04
            //Program prog = new Program();
            //Console.WriteLine("Insira o valor 1");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o valor 2");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o sinal");
            //string x3 = Console.ReadLine();
            //int a = prog.Calculadora04(x1, x2, x3);
            //Console.WriteLine(a);

            ////05
            //Program prog = new Program();
            //Console.WriteLine("Insira seu usuário");
            //string user = Console.ReadLine();
            //Console.WriteLine("Insira sua senha");
            //string password = Console.ReadLine();
            //string a = prog.Login05(user, password);
            //Console.WriteLine(a);

            //////////////////////////////////////////////////////////////////////////////////////////////
            ///Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03
            ///01
            //Program prog = new Program();
            //prog.Joeslei01();

            //02
            Program prog = new Program();
            prog.CxEletronico02();

            ////03
            //Program prog = new Program();
            //int[] vetor = new int[9];
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Insira o número " + (i+1));
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //prog.ConverteVetMat03(vetor);

            //////////////////////////////////////////////////////////////////////////////////////////////
            ///Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04
            ////01
            //Program prog = new Program();
            //Console.WriteLine("Insira o nome");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Insira o CPF");
            //string cpf = Console.ReadLine();
            //Console.WriteLine("Insira a Idade");
            //int idade = int.Parse(Console.ReadLine());
            //prog.ApresentarPessoa01(nome, cpf, idade);

            ////02
            //Program prog = new Program();
            //Console.WriteLine("Qual o tamanho do vetor?");
            //int tamanho = int.Parse(Console.ReadLine());
            //prog.CriaOrganizaVetor02(tamanho);

            //////////////////////////////////////////////////////////////////////////////////////////////
            ///Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05
            ////01
            //Program prog = new Program();
            //Console.WriteLine("Qual valor você deseja procurar?");
            //int valor = int.Parse(Console.ReadLine());
            //int a = prog.PesquisaMatriz01(valor);
            //Console.WriteLine(a);

            ////02
            //Program prog = new Program();
            //Random ran = new Random();
            //int[] vet = new int[10];
            //int[] vet1 = new int[10];
            //int[] vet2 = new int[10];

            //for (int i = 0; i < vet.Length; i++)
            //{
            //    vet[i] = ran.Next(0, 30);
            //    vet1[i] = ran.Next(0, 30);
            //    vet2[i] = ran.Next(0, 30);
            //}
            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.Write(vet[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < vet1.Length; i++)
            //{
            //    Console.Write(vet1[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < vet2.Length; i++)
            //{
            //    Console.Write(vet2[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Maiores valores");
            //int[] vetRetorno = prog.MaiorVetor02(vet, vet1, vet2);
            //for (int i = 0; i < vetRetorno.Length; i++)
            //{
            //    Console.Write(vetRetorno[i] + " ");
            //}

            ////03
            //Program prog = new Program();
            //double imprimir, AVista, DuasVezes, TresADez;
            //Console.WriteLine("Insira o valor da compra");
            //double valorCompra = double.Parse(Console.ReadLine());
            //imprimir = prog.ImprimirOpcoes03();
            //if (imprimir == 1)
            //{
            //    AVista = prog.AVista03(imprimir, valorCompra);
            //    Console.WriteLine("R$ " + AVista);
            //}
            //else if (imprimir == 2)
            //{
            //    DuasVezes = prog.DuasVezes03(imprimir, valorCompra);
            //    Console.WriteLine("R$ " + DuasVezes);
            //}
            //else
            //{
            //    TresADez = prog.TresADez03(imprimir, valorCompra);
            //    Console.WriteLine("R$ " + TresADez);
            //}
        }

        public string Compara01(int x, int y)
        {
            if (x > y)
            {
                return "O valor " + y + " é menor.";
            }
            else
            {
                return "O valor " + x + " é menor.";
            }
        }
        public int ParImpar02(int x)
        {
            if (x % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int SinalNumero03(int x)
        {
            if (x > 0)
            {
                return 1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public double ConversaoTemp04(int x)
        {
            double y = (x * 9 / 5) + 32;
            return y;
        }
        public double Medias05(int[] x, string escolha)
        {
            if (escolha == "A")
            {
                int media = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    media += x[i];
                }
                media /= 3;
                return media;
            }
            else if (escolha == "P")
            {
                int peso1 = 5, peso2 = 3, peso3 = 2;
                int media = 0;
                media = (peso1 * x[0]) + (peso2 * x[1]) + (peso3 * x[2]);
                media = media / (peso1 + peso2 + peso3);
                return media;
            }
            else
            {
                return x[1];
            }
        }
        public double Formula06(int[] x)
        {
            int formula = 0;
            formula = x[1] * x[2] * x[0];
            formula /= x[3] * x[4];
            return formula;
        }
        public double Hipotenusa07(int[] x)
        {
            double hip = 0;
            hip += Math.Pow(x[0], 2);
            hip += Math.Pow(x[1], 2);
            hip = Math.Sqrt(hip);
            return hip;
        }
        public int[] SortManual08(int[] vetor)
        {
            //Laço que percorre o vetor do início ao fim
            for (int i = 0; i < vetor.Length; i++)
            {
                //Laço que volta organizando
                for (int j = i; j > 0; j--)
                {
                    if (vetor[j - 1] > vetor[j])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }
            return vetor;
        }
        public int Ordenar08(int num) // Usando sort
        {
            Console.Clear();
            int[] valores = new int[num];
            List<int> lista = new List<int>();
            int cont = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = cont;
                lista.Add(cont);
                cont++;
            }

            lista.Sort();

            foreach (var p in lista)
            {
                Console.WriteLine(p);
            }
            return num;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02Lista02

        public int CompararMaior01(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public int ProcurarVetor02(int x)
        {
            Random ran = new Random();
            int[] aleatorios = new int[10];
            for (int i = 0; i < aleatorios.Length; i++)
            {
                aleatorios[i] = ran.Next(0, 10);
            }
            return aleatorios[x];
        }
        public void OrganizaVetor03(string escolha)
        {
            int[] vetor = new int[10];
            Random ran = new Random();
            if (escolha == "manual")
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Insira o valor " + (i + 1));
                    vetor[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = ran.Next(0, 10);
                }
            }
            Array.Sort(vetor);
            Array.Reverse(vetor);

            foreach (var p in vetor)
            {
                Console.WriteLine(p);
            }
        }
        public int Calculadora04(int x, int y, string op)
        {
            if (op == "+")
            {
                int b = x + y;
                return b;
            }
            else
            {
                int b = x - y;
                return b;
            }
        }
        public string Login05(string user, string password)
        {
            bool login = false;
            string[] VetUser = new string[3];
            VetUser[0] = "admin";
            string[] VetPswd = new string[3];
            VetPswd[0] = "password";

            for (int i = 0; i < VetUser.Length; i++)
            {
                if (VetUser[i] == user && VetPswd[i] == password)
                {
                    login = true;
                    break;
                }
            }
            if (login == false)
            {
                return "Login negado!";
            }
            else
            {
                return "Login efetuado com sucesso!";
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03Lista03

        public void Joeslei01()
        {
            int HpJoeslei = 25, HpGoblin = 15, HpLobo = 10;
            int DefesaJoeslei = 2, DefesaLobo = 2;
            Random ran = new Random();
            Console.WriteLine("Você encontrou um goblin!");
            while (HpJoeslei > 0 || HpGoblin > 0)
            {
                Console.WriteLine("Você deseja fugir ou atacar?");
                Console.WriteLine("A vida do goblin é de: " + HpGoblin);
                Console.WriteLine("A vida do Joeslei é de: " + HpJoeslei);
                string escolha = Console.ReadLine();
                if (escolha == "fugir")
                {
                    Console.WriteLine("Você fugiu!");
                    break;
                }
                int AtJoeslei = ran.Next(8, 11);
                int AtGoblin = ran.Next(5, 8);
                HpJoeslei = HpJoeslei - (AtGoblin - DefesaJoeslei);
                if (HpJoeslei <= 0)
                {
                    Console.WriteLine("Você morreu!");
                    break;
                }
                HpGoblin = HpGoblin - AtJoeslei;
                if (HpGoblin <= 0)
                {
                    Console.WriteLine("Você venceu!");
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine();
            Console.WriteLine("Após usar uma de suas poções, sua vida foi restaurada para 25 pontos");
            HpJoeslei = 25;
            Console.WriteLine();
            Console.WriteLine("Você encontrou um lobo!");
            while (HpJoeslei > 0 || HpLobo > 0)
            {
                Console.WriteLine("Você deseja fugir ou atacar?");
                Console.WriteLine("A vida do Lobo é de: " + HpLobo);
                Console.WriteLine("A vida do Joeslei é de: " + HpJoeslei);
                string escolha = Console.ReadLine();
                if (escolha == "fugir")
                {
                    Console.WriteLine("Você fugiu!");
                    break;
                }
                int AtJoeslei = ran.Next(8, 11);
                int AtLobo = ran.Next(10, 12);
                HpJoeslei = HpJoeslei - (AtLobo - DefesaJoeslei);
                if (HpJoeslei <= 0)
                {
                    Console.WriteLine("Você morreu!");
                    break;
                }
                HpLobo = HpLobo - (AtJoeslei - DefesaLobo);
                if (HpLobo <= 0)
                {
                    Console.WriteLine("Você venceu!");
                    break;
                }
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por jogar!");
        }
        public void CxEletronico02()
        {
            string nome = "Jorge", cpf = "1", nome1 = "Alex", cpf1 = "2";
            double saldo = 2000, saldo1 = 3000;
            while (true)
            {
                Console.WriteLine("Insira seu CPF");
                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Console.WriteLine("Nome {0}, CPF {1}", nome, cpf);
                    Console.WriteLine("Qual operação você deseja realizar?");
                    Console.WriteLine("1 - extrato, 2 - Pagar, 3 - Pix");
                    escolha = Console.ReadLine();
                    if (escolha == "1")
                    {
                        Console.WriteLine(saldo);
                    }
                    else if (escolha == "2")
                    {
                        Console.WriteLine("Qual o valor do pagamento?");
                        double pagamento = double.Parse(Console.ReadLine());
                        if (pagamento > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                        {
                            saldo -= pagamento;
                            Console.WriteLine("Pagamento realizado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insira a conta para a qual você deseja fazer um pix");
                        int conta = int.Parse(Console.ReadLine());
                        if (conta == 2)
                        {
                            Console.WriteLine("Insira o valor de seu pix");
                            int valor = int.Parse(Console.ReadLine());
                            if (valor > saldo)
                            {
                                Console.WriteLine("Saldo insuficiente!");
                            }
                            else
                            {
                                saldo -= valor;
                                saldo1 += valor;
                                Console.WriteLine("Pix realizado!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nome {0}, CPF {1}", nome1, cpf1);
                    Console.WriteLine("Qual operação você deseja realizar?");
                    Console.WriteLine("1 - extrato, 2 - Pagar, 3 - Pix");
                    escolha = Console.ReadLine();
                    if (escolha == "1")
                    {
                        Console.WriteLine(saldo1);
                    }
                    else if (escolha == "2")
                    {
                        Console.WriteLine("Qual o valor do pagamento?");
                        double pagamento = double.Parse(Console.ReadLine());
                        if (pagamento > saldo1)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                        {
                            saldo1 -= pagamento;
                            Console.WriteLine("Pagamento realizado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insira a conta para a qual você deseja fazer um pix");
                        int conta = int.Parse(Console.ReadLine());
                        if (conta == 1)
                        {
                            Console.WriteLine("Insira o valor de seu pix");
                            int valor = int.Parse(Console.ReadLine());
                            if (valor > saldo1)
                            {
                                Console.WriteLine("Saldo insuficiente!");
                            }
                            else
                            {
                                saldo1 -= valor;
                                saldo += valor;
                                Console.WriteLine("Pix realizado!");
                            }
                        }
                    }
                }
            }
        }
        public void ConverteVetMat03(int[] vet)
        {
            int x = 2, y = 5;
            int[,] mat = new int[x, y];
            for (int i = 0; i < y; i++)
            {
                mat[0, i] = vet[i];
            }
            int indvet = 4;
            for (int i = 0; i < y; i++)
            {
                mat[1, i] = vet[indvet];
                indvet++;
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04Lista04
        ///
        public void ApresentarPessoa01(string nome, string cpf, int idade)
        {
            Console.Clear();
            Console.WriteLine("Nome: {0}, CPF: {1} e idade: {2}", nome, cpf, idade);
        }
        public void CriaOrganizaVetor02(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random ran = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = ran.Next();


            }
            Array.Sort(vetor);
            foreach (var p in vetor)
            {
                Console.WriteLine(p);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        ///Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05Lista05
        ///

        public int PesquisaMatriz01(int numero)
        {
            Random ran = new Random();
            bool AchouNumero = false;
            int x = 5, y = 5;
            int[,] matriz = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < y; j++)
                {
                    int b = ran.Next(0, 50);
                    matriz[i, j] = b;
                    Console.Write(b + " ");
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        AchouNumero = true;
                    }
                }
            }
            Console.WriteLine();
            if (AchouNumero)
            {
                return numero;
            }
            else
            {
                return -1234;
            }
        }
        public int[] MaiorVetor02(int[] vet, int[] vet1, int[] vet2)
        {
            int[] vetRetorno = new int[10];
            for (int i = 0; i < vetRetorno.Length; i++)
            {
                if (vet[i] > vet1[i] && vet[i] > vet2[i])
                {
                    vetRetorno[i] = vet[i];
                }
                else if (vet1[i] > vet2[i])
                {
                    vetRetorno[i] = vet1[i];
                }
                else
                {
                    vetRetorno[i] = vet2[i];
                }
            }
            return vetRetorno;
        }
        public double ImprimirOpcoes03()
        {
            Console.WriteLine("1) Opção: a vista com 10% de desconto");
            Console.WriteLine("2) Opção: em duas vezes (preço da etiqueta)");
            Console.WriteLine("3) Opção: de 3 até 10 vezes com 3% de juros ao mês (somente para compras acima de R$100, 00).");
            Console.WriteLine();
            Console.WriteLine("Qual opção você deseja?");
            double opcao = double.Parse(Console.ReadLine());
            return opcao;
        }
        public double AVista03(double numero, double valor)
        {
            valor *= 0.9;
            return valor;
        }
        public double DuasVezes03(double numero, double valor)
        {
            return valor;
        }
        public double TresADez03(double numero, double valor)
        {
            Console.WriteLine("Em quantas vezes você deseja?");
            if (valor < 101)
            {
                return valor;
            }
            int parcelas = int.Parse(Console.ReadLine());
            if (parcelas > 2 && parcelas < 11)
            {
                double juros = 0.03;
                double valJuros = valor;
                juros = juros * valor * parcelas;
                valor += juros;
            }
            return valor;
        }
    }
}
