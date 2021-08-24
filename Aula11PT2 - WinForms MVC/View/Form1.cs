using Aula11PT2___WinForms_MVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11PT2___WinForms_MVC.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbExec02.Checked)
            {
                new Exec02().Show();
                this.Hide();
            }
        }
    }
}
