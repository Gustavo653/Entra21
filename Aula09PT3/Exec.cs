using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT3
{
    class Exec01
    {
        private string nome, raca;
        private int idade;

        public Exec01(string nome, string raca, int idade)
        {
            this.nome = nome;
            this.raca = raca;
            this.idade = idade;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetRaca(string raca)
        {
            this.raca = raca;
        }
        public string GetRaca()
        {
            return raca;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetIdade()
        {
            return idade;
        }
    }
    class Exec04
    {
        private string nome, cpf;
        private string[] consultas;

        public Exec04(string nome, string cpf, string[] consultas)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.consultas = consultas;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return cpf;
        }
        public void SetConsulta(string[] consultas)
        {
            this.consultas = consultas;
        }
        public string[] GetConsultas()
        {
            return consultas;
        }

    }
}
