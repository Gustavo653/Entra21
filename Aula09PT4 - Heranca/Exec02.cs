using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class Comportamento
    {
        public double Comer(double kilos)
        {
            double dopamina = kilos;
            dopamina *= 250;
            return dopamina;
        }
        public int Descansar(int horas)
        {
            int conforto = horas;
            conforto *= 100;
            return conforto;
            Console.WriteLine("Você ganhou " + conforto + " de conforto");
        }
        public double Trabalhar(int horas)
        {
            double dinheiro = horas;
            dinheiro *= 24.52;
            return dinheiro;
            Console.WriteLine("Você ganhou " + dinheiro + " de dinheiro");
        }
    }
    class Pessoa2 : Comportamento
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Dopamina { get; set; }
        public double Dinheiro { get; set; }
    }
    class Cachorro : Comportamento
    {
        public string Nome { get; set; }
        public double Dopamina { get; set; }
        public int Conforto { get; set; }
    }
}
