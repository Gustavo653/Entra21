using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09PT4
{
    class DadosBancarios
    {
        public int NumConta { get; set; }
        public double ValorConta { get; set; }
        public int SenhaConta { get; set; }
    }
    class Pessoa3 : DadosBancarios
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
    class CaixaEletronico : Pessoa3
    {
        public int Id { get; set; }
        public double ValorInterno { get; set; }
    }
   class Funcionario1
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}
