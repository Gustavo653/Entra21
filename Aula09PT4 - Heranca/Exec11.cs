using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class Calculadora
    {
        public double Soma(double n1, double n2)
        {
            double soma = n1 + n2;
            return soma;
        }
        public double Subtrair(double n1, double n2)
        {
            double subtracao = n1 - n2;
            return subtracao;
        }
        public double Multiplicar(double n1, double n2)
        {
            double multiplicacao = n1 * n2;
            return multiplicacao;
        }
        public double Divisao(double n1, double n2)
        {
            double divisao = n1 / n2;
            return divisao;
        }
    }
    class CalculadoraCientifica : Calculadora
    {
        public double Potenciacao(double n1)
        {
            double n = Math.Pow(n1, 2);
            return n;
        }
        public double Radiciacao(double n1)
        {
            double n = Math.Sqrt(n1);
            return n;
        }
    }
    class CalculadoraPersistente : Calculadora
    {
        public double GuardarValor(double n)
        {
            return n;
        }
    }
}
