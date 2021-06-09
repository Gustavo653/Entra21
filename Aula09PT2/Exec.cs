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

        public Exec02()
        {
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

            if (idade > 4)
            {
                Console.WriteLine(nome);
                Console.WriteLine(nomeDono);
                Console.WriteLine(idade);
            }
        }

        public void MostrarCachorros()
        {

        }

        public Exec03()
        {
        }
    }
}
