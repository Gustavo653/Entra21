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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "01")
            {
                Exec1 exec = new Exec1();
                this.Visible = false;
                exec.Show();
            }
            else if (comboBox1.Text == "02")
            {
                Exec2 exec = new Exec2();
                this.Visible = false;
                exec.Show();
            }
            else if (comboBox1.Text == "03")
            {
                Exec3 exec = new Exec3();
                this.Visible = false;
                exec.Show();
            }
            else if (comboBox1.Text == "04")
            {
                Exec4 exec = new Exec4();
                this.Visible = false;
                exec.Show();
            }
            else
            {
                Exec5 exec = new Exec5();
                this.Visible = false;
                exec.Show();
            }
        }
    }
}
