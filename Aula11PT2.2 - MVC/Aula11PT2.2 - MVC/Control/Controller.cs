using Aula11PT2._2___MVC.Model;
using Aula11PT2._2___MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11PT2._2___MVC.Control
{
    class Controller
    {
        public static void Login(string contaInformada)
        {
            bool login = DBConnection.ContaExiste(contaInformada);
            if (login)
            {
                Form2 form2 = new Form2();
                form2.NumeroConta = contaInformada;
                form2.Show();
            }
        }
        public static void Sacar(string contaInformada, int quantia)
        {
            DBConnection.Saque(contaInformada, quantia);
        }
    }
}
