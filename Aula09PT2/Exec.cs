using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT2
{
    class Exec01
    {
        public string nome, cpf, endereco;
        public int idade;

        public Exec01(string nome, string cpf, string endereco, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.idade = idade;
        }
    }
    class Exec02
    {
        public string nome, genero;
        public int idade;

        public Exec02(string nome, string genero, int idade)
        {
            this.nome = nome;
            this.genero = genero;
            this.idade = idade;
        }
    }
    class Exec03
    {
        public string nome, nomeDono;
        public int idade;

        public Exec03(string nome, string nomeDono, int idade)
        {
            this.nome = nome;
            this.nomeDono = nomeDono;
            this.idade = idade;
        }
    }
    class Exec04
    {
        public string nome;
        public int quantidade;
        public double preco;

        public Exec04(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }
    }
    class Exec05
    {
        public string nome, especie;
        public int tempoZoo;

        public Exec05(string nome, string especie, int tempoZoo)
        {
            this.nome = nome;
            this.especie = especie;
            this.tempoZoo = tempoZoo;
        }
    }
    class Exec06
    {
        public string nome, cpf;
        public double salario;

        public Exec06(string nome, string cpf, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            if (salario < 1500)
            {
                this.salario = salario * 1.2;
            }
        }
    }
    class Exec07
    {
        public string nome;
        public double n1, n2, n3;

        public Exec07(string nome, double n1, double n2, double n3)
        {
            this.nome = nome;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        public static void MediaAprovacao(double n1, double n2, double n3)
        {
            double media = n1 + n2 + n3;
            media /= 3;
            if (media > 7)
            {
                Console.WriteLine("O aluno foi aprovado! Sua nota foi: " + media);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado! Sua nota foi: " + media);
            }
        }
    }
}
