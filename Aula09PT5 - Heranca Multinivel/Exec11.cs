using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT5___Heranca_Multinivel
{
    class Endereco1
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
    class Imovel : Endereco1
    {
        public string DataConstrucao { get; set; }
    }
    class Casa : Imovel
    {
        public string QuantQuartos { get; set; }
        public string NomeDono { get; set; }
    }
    class Hotel
    {
        public int QuantidadeApartamentos { get; set; }
        public bool[] Apartamentos { get; set; }
    }
}
