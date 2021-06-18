using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
    class Pessoa : Endereco
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
    }
    class Empresa : Endereco
    {
        public string Nome { get; set; }
        public int QuantFunc { get; set; }
    }
    class Habitacao : Endereco
    {
        public string NomeDono { get; set; }
        public string TipoHab { get; set; }
    }
}
