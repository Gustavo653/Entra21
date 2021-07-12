using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT7___Interface
{
   interface IPessoa2
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public List<string> ListaDeCrimes { get; set; }
        public double QtdAnosPreso { get; set; }
        public string DataDeEntradaNaPrisao { get; set; }
    }
    class Pessoa2 : IPessoa2
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public List<String> ListaDeCrimes { get; set; }
        public double QtdAnosPreso { get; set; }
        public string DataDeEntradaNaPrisao { get; set; }
    }
}
