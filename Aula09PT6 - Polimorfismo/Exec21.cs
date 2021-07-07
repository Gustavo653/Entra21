using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    abstract class Operacoes
    {
        public abstract void Deposito();
        public abstract void Retirada();
        public abstract void ImpressaoExtrato();
    }
    class Transacao
    {
        public string DataTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public void ExibirTransacoes()
        {
            Console.WriteLine("Valor da transação: {0:c}", ValorTransacao);
            Console.WriteLine("Data da transação: " + DataTransacao);
        }
    }
    class Conta : Operacoes
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public virtual void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Número da conta: " + NumeroConta);
            Console.WriteLine("Saldo: {0:c}", Saldo);
        }
        public override void Deposito()
        {
            Console.WriteLine("Insira o valor a ser depositado:");
            double valor = double.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine("Saldo atual: {0:c}", Saldo);
        }
        public override void Retirada()
        {
            Console.WriteLine("Insira o valor a ser retirado:");
            double valor = double.Parse(Console.ReadLine());
            if (valor <= Saldo)
            {
                Console.WriteLine("Retirada efetuada!");
                Saldo -= valor;
                Console.WriteLine("Saldo restante: {0:c}", Saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public override void ImpressaoExtrato()
        {
            Console.WriteLine("Saldo: {0:c}", Saldo);
            Console.WriteLine("Transações");
            foreach (var item in Transacoes)
            {
                item.ExibirTransacoes();
            }
        }
    }
    class Poupanca : Conta
    {
        public int DiaAniversario { get; set; }
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("Dia do aniversário: " + DiaAniversario);
        }
        public override void Deposito()
        {
            base.Deposito();
        }
        public override void ImpressaoExtrato()
        {
            base.ImpressaoExtrato();
        }
    }
    class Limite : Conta
    {
        public double ValorLimite { get; set; }
        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine("Valor do limite: " + ValorLimite);
        }
        public override void Deposito()
        {
            base.Deposito();
        }
        public override void Retirada()
        {
            Console.WriteLine("Insira o valor a ser retirado:");
            double valor = double.Parse(Console.ReadLine());
            if (valor <= (Saldo + ValorLimite))
            {
                Console.WriteLine("Retirada efetuada!");
                Saldo -= valor;
                Console.WriteLine("Saldo restante: {0:c}", Saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public override void ImpressaoExtrato()
        {
            base.ImpressaoExtrato();
        }
    }
}
