using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exemplo
            //int[] array = new int[4];
            //int a = array.Length;
            //Console.WriteLine(a);

            ////Exemplo
            //int[] array = new int[3];
            //int a = array.Length;

            //for (int i = 0; i < a; i++)
            //{
            //    array[i] = i;
            //    Console.WriteLine(array[i]);
            //}

            ////Exemplo
            //int b = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[b];

            //for (int i = 0; i < 15; i++)
            //{
            //    array[i] = i * 2;
            //    Console.WriteLine(array[i]);
            //}

            ////Exemplo
            //int b = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[b];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i + i;
            //    Console.WriteLine(array[i]);
            //}

            ////Exemplo
            //int[] numeros = new int[3];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + i);
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Valor salvo " + i + ": " + numeros[i]);
            //}

            //LISTA 01 LISTA 01 LISTA 01 LISTA 01 LISTA 01 LISTA 01 LISTA 01
            ////01
            //int[] valor = new int[2];

            //for (int i = 0; i < valor.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + i);
            //    valor[i] = int.Parse(Console.ReadLine());
            //}
            //if (valor[0] > valor[1])
            //{
            //    Console.WriteLine(valor[0]);
            //}
            //else
            //{
            //    Console.WriteLine(valor[1]);
            //}

            ////02
            //int[] numeros = new int[3];
            //int total = 0;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Insire a nota " + i);
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i< numeros.Length; i++)
            //{
            //    total += numeros[i];
            //}

            //total /= numeros.Length;
            //Console.WriteLine("A média é: " + total);

            ////03
            //int[] numeros = new int[3];
            //int maior = 0;
            //bool x = false;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + i);
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[0] == numeros[1] && numeros[0] == numeros[2])
            //    {
            //        x = true;
            //    }
            //    else if (numeros[i] > maior)
            //    {
            //        maior = numeros[i];
            //    }
            //}
            //if (x == true)
            //{
            //    Console.WriteLine("São todos iguais!");
            //}
            //else
            //{
            //    Console.WriteLine("O maior é: " + maior);
            //}

            ////04
            //string[] nomes = new string[3];
            //string escolha;
            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    nomes[i] = Console.ReadLine();
            //}
            //while (true)
            //{
            //    Console.WriteLine("Deseja consultar todos os nomes?");
            //    escolha = Console.ReadLine();
            //    if (escolha == "Sim")
            //    {
            //        for (int i = 0; i < nomes.Length; i++)
            //        {
            //            Console.WriteLine(nomes[i]);
            //        }
            //        break;
            //    }
            //}

            ////05
            //int[] vetor = new int[5];
            //int soma = 0;

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    soma += vetor[i];
            //}
            //Console.WriteLine(soma);

            ////06
            //string[] nome = new string[4];
            //string[] cpf = new string[4];
            //string[] idade = new string[4];
            //string escolha;

            //while (true)
            //{
            //    for (int i = 0; i < nome.Length; i++)
            //    {
            //        Console.WriteLine("Vetor " + i + " " + nome[i] +" "+ cpf[i] + " " + idade[i]);
            //    }
            //    Console.WriteLine("Você deseja adicionar um novo aluno em qual vetor?");
            //    escolha = Console.ReadLine();
            //    if (escolha == "0")
            //    {
            //        Console.WriteLine("Insira o nome");
            //        nome[0] = Console.ReadLine();
            //        Console.WriteLine("Insira o cpf");
            //        cpf[0] = Console.ReadLine();
            //        Console.WriteLine("Insira a idade");
            //        idade[0] = Console.ReadLine();
            //    }
            //    else if (escolha == "1")
            //    {
            //        Console.WriteLine("Insira o nome");
            //        nome[1] = Console.ReadLine();
            //        Console.WriteLine("Insira o cpf");
            //        cpf[1] = Console.ReadLine();
            //        Console.WriteLine("Insira a idade");
            //        idade[1] = Console.ReadLine();
            //    }
            //    else if (escolha == "2")
            //    {
            //        Console.WriteLine("Insira o nome");
            //        nome[2] = Console.ReadLine();
            //        Console.WriteLine("Insira o cpf");
            //        cpf[2] = Console.ReadLine();
            //        Console.WriteLine("Insira a idade");
            //        idade[2] = Console.ReadLine();
            //    }
            //    else if (escolha == "3")
            //    {
            //        Console.WriteLine("Insira o nome");
            //        nome[3] = Console.ReadLine();
            //        Console.WriteLine("Insira o cpf");
            //        cpf[3] = Console.ReadLine();
            //        Console.WriteLine("Insira a idade");
            //        idade[3] = Console.ReadLine();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            ////07
            //string[] placa = new string[10];
            //int[] hora = new int[10];

            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("O cliente está entrando ou saindo?");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "entrando")
            //    {
            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] == null)
            //            {
            //                Console.WriteLine("Insire a placa");
            //                placa[i] = Console.ReadLine();
            //                Console.WriteLine("Insire a hora de entrada");
            //                hora[i] = int.Parse(Console.ReadLine());
            //                break;
            //            }
            //        }

            //        Console.WriteLine("Vagas ocupadas");
            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] != null)
            //            {
            //                Console.WriteLine("Vaga " + i);
            //                Console.WriteLine("Placa: " + placa[i] + " Hora de entrada: " + hora[i]);
            //            }
            //        }
            //    }
            //    else if (escolha == "saindo")
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Insire a placa");
            //            string placaSaindo = Console.ReadLine();
            //            for (int i = 0; i < placa.Length; i++)
            //            {
            //                if (placaSaindo == placa[i])
            //                {

            //                    {
            //                        Console.WriteLine("Insira a hora de saída");
            //                        int horaSaida = int.Parse(Console.ReadLine());
            //                        double valorEstacionamento = horaSaida - hora[i];
            //                        valorEstacionamento *= 3.5;
            //                        Console.WriteLine("O valor do estacionamento é de: " + valorEstacionamento);
            //                        placa[i] = null;
            //                        hora[i] = 0;
            //                        Console.WriteLine("Vaga " + i + " livre");
            //                        break;
            //                    }
            //                }
            //            }
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            ////LISTA 02 LISTA 02 LISTA 02 LISTA 02 LISTA 02 LISTA 02 LISTA 02 LISTA 02
            ////01
            //int[] vet1 = new int[1];
            //int[] vet2 = new int[1];
            //int[] vet3 = new int[1];

            //vet1[0] = 3;
            //vet2[0] = 4;
            //vet3[0] = vet1[0] + vet2[0];

            //02
            string[] produtos = new string[5];
            produtos[0] = "1 - Cuca - R$ 10";
            produtos[1] = "2 - Pão - R$ 1";
            produtos[2] = "3 - Pastel - R$ 5";
            produtos[3] = "4 - Coxinha - R$ 4";
            produtos[4] = "5 - Bolo - R$ 35";
            string[] compra = new string[10];
            int a = 0, b = 0, c = 0, d = 0, e = 0;

            while (true)
            {
                Console.WriteLine("Qual produto você deseja adicionar?");
                for (int i = 0; i < produtos.Length; i++)
                {
                    Console.WriteLine(produtos[i]);
                }

                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    for (int i = 0; i < compra.Length; i++)
                    {
                        if (compra[i] == null)
                        {
                            Console.WriteLine("O item " + produtos[0] + " foi adicionado");
                            compra[i] = produtos[0];
                            a++;
                            break;
                        }
                    }
                }
                else if (escolha == "2")
                {
                    for (int i = 0; i < compra.Length; i++)
                    {
                        if (compra[i] == null)
                        {
                            Console.WriteLine("O item " + produtos[1] + " foi adicionado");
                            compra[i] = produtos[1];
                            b++;
                            break;
                        }
                    }
                }
                else if (escolha == "3")
                {
                    for (int i = 0; i < compra.Length; i++)
                    {
                        if (compra[i] == null)
                        {
                            Console.WriteLine("O item " + produtos[2] + " foi adicionado");
                            compra[i] = produtos[2];
                            c++;
                            break;
                        }
                    }
                }
                else if (escolha == "4")
                {
                    for (int i = 0; i < compra.Length; i++)
                    {
                        if (compra[i] == null)
                        {
                            Console.WriteLine("O item " + produtos[3] + " foi adicionado");
                            compra[i] = produtos[3];
                            d++;
                            break;
                        }
                    }
                }
                else if (escolha == "5")
                {
                    for (int i = 0; i < compra.Length; i++)
                    {
                        if (compra[i] == null)
                        {
                            Console.WriteLine("O item " + produtos[4] + " foi adicionado");
                            compra[i] = produtos[4];
                            e++;
                            break;
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Sua compra:");
                        for (int i = 0; i < compra.Length; i++)
                        {
                            Console.Write(i + " ");
                            Console.WriteLine(compra[i]);
                        }
                        double total = (a * 10) + (b * 1) + (c * 5) + (d * 4) + (e * 35);
                        Console.WriteLine("O valor total de sua compra foi de: " + total);
                        Console.WriteLine("Digite o id do item a ser removido");
                        int removerItem = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < compra.Length; i++)
                        {
                            if (removerItem == i)
                            {
                                if (compra[i] == produtos[0])
                                {
                                    a--;
                                }
                                else if (compra[i] == produtos[1])
                                {
                                    b--;
                                }
                                else if (compra[i] == produtos[2])
                                {
                                    c--;
                                }
                                else if (compra[i] == produtos[3])
                                {
                                    d--;
                                }
                                else if (compra[i] == produtos[4])
                                {
                                    e--;
                                }
                                else
                                {
                                    Console.WriteLine("Item não removido");
                                }
                                Console.WriteLine(total);
                                compra[i] = null;
                                Console.WriteLine("Item apagado");
                            }
                        }
                        if (removerItem > 10)
                        {
                            break;
                        }
                        break;
                    }
                }
            }

            ////03
            //int[] v1 = new int[10];
            //int[] v2 = new int[10];
            //int[] v3 = new int[10];
            //int maior = 0;
            //Random ran = new Random();
            //for (int i = 0; i < v1.Length; i++)
            //{
            //    v1[i] = ran.Next(0, 31);
            //    v2[i] = ran.Next(0, 31);
            //    v3[i] = ran.Next(0, 31);
            //}

            //for (int i = 0; i < v1.Length; i++)
            //{
            //    if (v1[i] > v2[i] && v1[i] > v3[i])
            //    {
            //        Console.WriteLine("O maior da rodada " + i);
            //        Console.WriteLine("Foi: " + v1[i]);
            //        Console.WriteLine();
            //        maior += v1[i];
            //    }
            //    else if (v2[i] > v3[i])
            //    {
            //        Console.WriteLine("O maior da rodada " + i);
            //        Console.WriteLine("Foi: " + v2[i]);
            //        Console.WriteLine();
            //        maior += v2[i];
            //    }
            //    else
            //    {
            //        Console.WriteLine("O maior da rodada " + i);
            //        Console.WriteLine("Foi: " + v3[i]);
            //        Console.WriteLine();
            //        maior += v3[i];
            //    }
            //}
            //Console.WriteLine("A soma dos maiores foi: " + maior);

            //////04
            ////char[] letras = new char[23];
            ////char[] senha = new char[10];
            ////letras[0] = 'a';
            ////letras[1] = 'b';
            ////letras[2] = 'c';
            ////letras[3] = 'd';
            ////letras[4] = 'e';
            ////letras[5] = 'f';
            ////letras[6] = 'g';
            ////letras[7] = 'h';
            ////letras[8] = 'i';
            ////letras[9] = 'j';
            ////letras[10] = 'k';
            ////letras[11] = 'l';
            ////letras[12] = 'm';
            ////letras[13] = 'n';
            ////letras[14] = 'o';
            ////letras[15] = 'p';
            ////letras[16] = 'q';
            ////letras[17] = 'r';
            ////letras[18] = 's';
            ////letras[19] = 't';
            ////letras[20] = 'u';
            ////letras[21] = 'v';
            ////letras[22] = 'x';
            ////Console.WriteLine("Quantos caracteres possui sua senha?");
            ////int carac = int.Parse(Console.ReadLine());
            ////for (int i = 0; i < carac; i++)
            ////{
            ////    senha[i] = char.Parse(Console.ReadLine());
            ////}

            ////for (int i = 0; i < senha.Length; i++)
            ////{
            ////    senha[i] = letras[i + 3];
            ////    Console.WriteLine(senha[i]);
            ////}

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //04 e 05
            ////declaração das variáveis
            //string palavra, encrypt = "";

            ////Esta é a perfumaria que eu falei...
            ////método write escreve na tela do prompt do usuario
            //Console.Write("|---------------------------------|\n");
            //Console.Write("| 1 - Criptografar um mensagem    |\n");
            //Console.Write("| 2 - Decriptografar uma mensagem |\n");
            //Console.Write("| 0 - Sair                        |\n");
            //Console.Write("|---------------------------------|\n");
            //Console.Write(" Escolha a opçao: ");

            ////Aqui é feito uma conversão, pois o opcao é inicialmente uma string
            //int opcao = int.Parse(Console.ReadLine());

            ////depois da conversão o switch verifica a opcao digitada
            //switch (opcao)

            //{

            //    //caso a opcao seja 1
            //    case 1:
            //        Console.Write("Entre com a mensagem para ser criptografada: ");

            //        //palavra é a variavel que o usuario vai digitar
            //        //O método .ToLower() transforma qualquer letra maiúscula em minúscula
            //        palavra = Console.ReadLine().ToLower();

            //        //enquanto a palavra for menor que i
            //        for (int i = 0; i < palavra.Length; i++)

            //        {
            //            //Devolve o codigo ASCII da letra
            //            int ASCII = (int)palavra[i];

            //            //Coloca a chave fixa adicionando 10 posições no numero da tabela ASCII
            //            int ASCIIC = ASCII + 3;

            //            //Concatena o texto e o coloca na variável
            //            encrypt += Char.ConvertFromUtf32(ASCIIC);
            //        }

            //        //Mostra o resultado final, concatenando a variável em que está o texto cifrado
            //        Console.Write("Resultado: " + encrypt);

            //        //Aguarda o usuário pressionar uma tecla para sair
            //        Console.ReadKey();

            //        //representa o final do case 1
            //        break;

            //    //caso a opcao escolhida for 2
            //    case 2:
            //        Console.Write("Entre com a mensagem para ser decriptografada: ");

            //        palavra = Console.ReadLine().ToLower();

            //        for (int i = 0; i < palavra.Length; i++)

            //        {

            //            int ASCII = (int)palavra[i];

            //            //Coloca a chave fixa retirando 10 posições no numero da tabela ASCII
            //            int ASCIIC = ASCII - 10;

            //            encrypt += Char.ConvertFromUtf32(ASCIIC);

            //        }

            //        Console.Write(encrypt);

            //        Console.ReadKey();

            //        break;
            //}

            ////////////////////////////////////////////////////////////////////////////////////
            //Lista 03Lista 03Lista 03Lista 03Lista 03Lista 03Lista 03Lista 03Lista 03Lista 03

            ////01
            //int[] seq1 = new int[10];
            //double[] seq2 = new double[11];
            //int[] seq3 = new int[10];
            //int[] seq4 = new int[10];
            //int contseq1 = 0;
            //int contseq3 = 1;
            //bool x3 = false;
            //int contseq4 = 4;
            //bool x4 = false;


            //for (int i = 10; i > 0; i--)
            //{
            //    seq1[contseq1] = i;
            //    contseq1++;
            //}
            //for (int i = 0; i < seq1.Length; i++)
            //{
            //    Console.WriteLine(seq1[i]);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < seq2.Length; i++)
            //{
            //    seq2[i] = Math.Pow(i, 2);
            //}
            //for (int i = 0; i < seq2.Length; i++)
            //{
            //    Console.WriteLine(seq2[i]);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < seq3.Length; i++)
            //{
            //    if (contseq3 < 6)
            //    {
            //        seq3[i] = contseq3;
            //        contseq3++;
            //    }
            //    else
            //    {
            //        if (x3 == false)
            //        {
            //            contseq3 = 10;
            //            x3 = true;
            //        }
            //        seq3[i] = contseq3;
            //        contseq3 += 10;
            //    }
            //}
            //for (int i = 0; i < seq3.Length; i++)
            //{
            //    Console.WriteLine(seq3[i]);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < seq4.Length; i++)
            //{
            //    if (x4 == false)
            //    {
            //        seq4[i] = contseq4;
            //        x4 = true;
            //    }
            //    else
            //    {
            //        contseq4 += 3;
            //        seq4[i] = contseq4;
            //    }
            //}
            //for (int i = 0; i < seq4.Length; i++)
            //{
            //    Console.WriteLine(seq4[i]);
            //}

            ////02
            //int[] array = new int[5];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(array);
            //foreach (int p in array)
            //{
            //    Console.WriteLine(p);
            //}

            ////03
            //int[] array = new int[5];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Insira o valor " + i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(array);
            //Array.Reverse(array);
            //foreach (int p in array)
            //{
            //    Console.WriteLine(p);
            //}

            ////04
            //string[] user = new string[5];
            //string[] password = new string[5];
            //user[0] = "admin";
            //password[0] = "password";

            //while (true)
            //{
            //    Console.WriteLine("Bem vindo a ProWay");
            //    Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");
            //    Console.WriteLine("Faça seu login");
            //    Console.WriteLine("Insira seu usuário");
            //    string usr = Console.ReadLine();
            //    Console.WriteLine("Insira sua senha");
            //    string pswd = Console.ReadLine();

            //    for (int i = 0; i < user.Length; i++)
            //    {
            //        if (usr == user[0])
            //        {
            //            if (pswd == password[0])
            //            {
            //                while (true)
            //                {
            //                    Console.WriteLine("Você deseja:");
            //                    Console.WriteLine("1 - Criar Usuário / 2 - Deletar Usuário / 3 - Fazer LogOut");
            //                    int escolha = int.Parse(Console.ReadLine());
            //                    if (escolha == 1)
            //                    {
            //                        Console.WriteLine("Insira o nome e a senha do novo usuário");
            //                        usr = Console.ReadLine();
            //                        pswd = Console.ReadLine();
            //                        for (int a = 0; a < user.Length; a++)
            //                        {
            //                            if (user[a] == null)
            //                            {
            //                                user[a] = usr;
            //                                password[a] = pswd;
            //                                Console.WriteLine("Usuário adicionado");
            //                                break;
            //                            }
            //                            else
            //                            {
            //                                Console.WriteLine("A lista está cheia");
            //                                //Está escapando esta mensagem sem querer
            //                            }
            //                        }
            //                    }
            //                    else if (escolha == 2)
            //                    {
            //                        for (int a = 0; a < user.Length; a++)
            //                        {
            //                            Console.WriteLine("Id: " + a + " Usuário: " + user[a] + " Senha: " + password[a]);
            //                        }
            //                        Console.WriteLine("Insira o id a ser deletado");
            //                        int idDel = int.Parse(Console.ReadLine());
            //                        user[idDel] = null;
            //                        password[idDel] = null;
            //                        Console.WriteLine("Usuário deletado");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("LogOut");
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //        else if (usr == user[i])
            //        {
            //            if (pswd == password[i])
            //            {
            //                Console.WriteLine("Você está logado");
            //                Console.WriteLine("Fazendo LogOut");
            //            }
            //        }
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////
            //DesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafioDesafio

            //string[] pessoas = new string[15];
            //string[] niver = new string[15];
            //string[] e = new string[15];

            //while (true)
            //{
            //    Console.WriteLine("Qual função você deseja?");
            //    Console.WriteLine("a - cadastrar");
            //    Console.WriteLine("b - excluir");
            //    Console.WriteLine("c - alterar dia / mês");
            //    Console.WriteLine("d - consultar por dia e mes");
            //    Console.WriteLine("e - mostrar todos os aniversariantes");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "a")
            //    {
            //        for (int i = 0; i < pessoas.Length; i++)
            //        {
            //            if (pessoas[i] == null)
            //            {
            //                Console.WriteLine("Insira o nome e o aniversário");
            //                pessoas[i] = Console.ReadLine();
            //                niver[i] = Console.ReadLine();
            //                break;
            //            }
            //        }
            //    }
            //    else if (escolha == "b")
            //    {
            //        for (int i = 0; i < pessoas.Length; i++)
            //        {
            //            Console.WriteLine("Id: " + i + " Nome: " + pessoas[i] + " Aniversário: " + niver[i]);
            //        }
            //        Console.WriteLine("Qual pessoa você deseja apagar?");
            //        escolha = Console.ReadLine();
            //        for (int a = 0; a < pessoas.Length; a++)
            //        {
            //            if (escolha == pessoas[a])
            //            {
            //                pessoas[a] = null;
            //                niver[a] = null;
            //                Console.WriteLine("Usuário deletado");
            //                break;
            //            }
            //        }
            //    }
            //    else if (escolha == "c")
            //    {
            //        for (int i = 0; i < pessoas.Length; i++)
            //        {
            //            Console.WriteLine("Id: " + i + " Nome: " + pessoas[i] + " Aniversário: " + niver[i]);
            //        }
            //        Console.WriteLine("Qual pessoa você deseja alterar?");
            //        escolha = Console.ReadLine();
            //        for (int a = 0; a < pessoas.Length; a++)
            //        {
            //            if (escolha == pessoas[a])
            //            {
            //                Console.WriteLine("Insira a nova data");
            //                escolha = Console.ReadLine();
            //                niver[a] = escolha;
            //                Console.WriteLine("Aniversário atualizado");
            //            }
            //        }
            //    }
            //    else if (escolha == "d")
            //    {
            //        for (int i = 0; i < pessoas.Length; i++)
            //        {
            //            Console.WriteLine("Id: " + i + " Nome: " + pessoas[i] + " Aniversário: " + niver[i]);
            //        }
            //        Console.WriteLine("Qual data você deseja consultar?");
            //        escolha = Console.ReadLine();
            //        for (int a = 0; a < pessoas.Length; a++)
            //        {
            //            if (escolha == niver[a])
            //            {
            //                Console.WriteLine("Nome: " + pessoas[a] + " Aniversário: " + niver[a]);
            //            }
            //        }
            //    }
            //    else if (escolha == "e")
            //    {
            //        //Console.WriteLine("Insira a letra inicial");
            //        //escolha = Console.ReadLine();
            //        //string[] nomes = Array.FindAll(pessoas, g => g == escolha);
            //        //for (int i = 0; i < nomes.Length; i++)
            //        //{
            //        //    Console.WriteLine(nomes[i]);
            //        //}
            //    }
            //    else
            //    {
            //        Console.WriteLine("Encerrando o programa");
            //        Environment.Exit(0);
            //    }
            //}        }
        }
    }
}
