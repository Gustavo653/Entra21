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
    class Exec05
    {
        private string nome, cpf;
        private string[] consultas;

        public Exec05(string nome, string cpf, string[] consultas)
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
    class Exec06
    {
        private string nome;
        private double[] notas;

        public Exec06(string nome, double[] notas)
        {
            this.nome = nome;
            this.notas = notas;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNota(double[] notas)
        {
            this.notas = notas;
        }
        public double[] GetNotas()
        {
            return notas;
        }
    }
    class Exec07
    {
        private int guiche;
        private double saldo, entrada, saida;
        public Exec07(int guiche, double saldo, double entrada, double saida)
        {
            this.guiche = guiche;
            this.saldo = saldo;
            this.entrada = entrada;
            this.saida = saida;
        }
        public void SetGuiche(int guiche)
        {
            this.guiche = guiche;
        }
        public int GetGuiche()
        {
            return guiche;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public void SetEntrada(double entrada)
        {
            this.entrada = entrada;
        }
        public double GetEntrada()
        {
            return entrada;
        }
        public void SetSaida(double saida)
        {
            this.saida = saida;
        }
        public double GetSaida()
        {
            return saida;
        }
    }
    class Exec11
    {
        private double saldo;
        private int conta;
        private string nome;
        public Exec11(double saldo, int conta, string nome)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.nome = nome;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public void SetConta(int conta)
        {
            this.conta = conta;
        }
        public int GetConta()
        {
            return conta;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
    }
}
