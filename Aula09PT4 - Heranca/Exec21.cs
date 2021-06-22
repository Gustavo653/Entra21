using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class Veiculo
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int CV { get; set; }
        public string Combustivel { get; set; }
    }
    class Carro : Veiculo
    {
        public string Proprietario { get; set; }
        public int KMRodados { get; set; }
    }
    class Aviao : Veiculo
    {
        public string Empresa { get; set; }
        public string Linha { get; set; }
    }
    class Navio : Veiculo
    {
        public int Tamanho { get; set; }
        public int[] Cargo { get; set; }
    }
}
