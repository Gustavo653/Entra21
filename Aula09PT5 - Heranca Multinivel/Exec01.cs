using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT5___Heranca_Multinivel
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
    class Dados : Endereco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Rg { get; set; }

    }

    class Empresa : Dados
    {
        public double Saldo { get; set; }
        public int QntFunc { get; set; }

    }
    class Carro : Dados
    {
        public string Modelo { get; set; }
        public int Cv { get; set; }
    }
}
