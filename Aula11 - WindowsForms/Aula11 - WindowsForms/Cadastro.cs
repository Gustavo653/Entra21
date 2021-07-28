using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11___WindowsForms
{
    class Cadastro
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Cadastro(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
