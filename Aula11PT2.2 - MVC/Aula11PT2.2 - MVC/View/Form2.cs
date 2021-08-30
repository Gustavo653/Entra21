using Aula11PT2._2___MVC.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11PT2._2___MVC.View
{
    public partial class Form2 : Form
    {
        public string NumeroConta { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.Sacar(NumeroConta, Convert.ToInt32(textBox1.Text));
        }
    }
}
