using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT6___Polimorfismo
{
    //1
    class Ingresso
    {
        public double Valor { get; set; }

        public Ingresso(double valor)
        {
            Valor = valor;
        }
        public virtual void ImprimeValor()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Valor comum: " + Valor);
            Console.WriteLine("Método sobreescrito!");
        }
    }
    //a
    class Vip : Ingresso
    {
        public double ValorAdicional { get; set; }
        public Vip(double valor) : base(valor)
        {
        }
        public override void ImprimeValor()
        {
            Console.WriteLine("O adicional VIP foi de: " + ValorAdicional);
            Console.WriteLine("O valor total foi de: " + (Valor + ValorAdicional));
            base.ImprimeValor();
        }
    }
    //b
    class Normal : Ingresso
    {
        public Normal(double valor) : base(valor)
        {
        }
        public override void ImprimeValor()
        {
            Console.WriteLine("Ingresso normal");
            base.ImprimeValor();
        }
    }
    //c
    class CamaroteInferior : Vip
    {
        public string Localizacao { get; set; }
        public CamaroteInferior(double valor) : base(valor)
        {
        }
        public override void ImprimeValor()
        {
            Console.WriteLine("O adicional será de: " + ValorAdicional);
            Console.WriteLine("O total será de: " + (Valor + ValorAdicional));
            Console.WriteLine("Localização: " + Localizacao);
        }
    }
    class CamaroteSuperior : Vip
    {
        public string Localizacao { get; set; }
        public CamaroteSuperior(double valor) : base(valor)
        {
        }
        public override void ImprimeValor()
        {
            Console.WriteLine("O adicional será de: " + (ValorAdicional*3));
            Console.WriteLine("O total será de: " + (Valor + (ValorAdicional*3)));
            Console.WriteLine("Localização: " + Localizacao);
        }
    }
}
