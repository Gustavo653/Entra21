using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class Pagamento
    {
        public double ValorPagamento { get; set; }
        public string DataPagamento { get; set; }
    }
    class CCredito : Pagamento
    {
        public void Calcular(double valorPagamento)
        {
            Console.WriteLine("Valor total: " + valorPagamento);
            Console.WriteLine("Valor da taxa: " + (valorPagamento * 0.04));
            Console.WriteLine("Valor líquido: " + (valorPagamento * 0.96));
        }
    }
    class CDebito : Pagamento
    {
        public void Calcular(double valorPagamento)
        {
            Console.WriteLine("Valor total: " + valorPagamento);
            Console.WriteLine("Valor da taxa: " + (valorPagamento * 0.02));
            Console.WriteLine("Valor líquido: " + (valorPagamento * 0.98));
        }
    }
    class Boleto : Pagamento
    {
        public string CodBarra { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
    }
}
