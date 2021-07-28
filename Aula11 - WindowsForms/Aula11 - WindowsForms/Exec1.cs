using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11___WindowsForms
{
    public partial class Exec1 : Form
    {
        public Exec1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu nome é: {txtNome.Text}" +
                $"\nSeu CPF é: {txtCpf.Text}" +
                $"\nSua idade é: {txtIdade.Text}");
        }
    }
}
