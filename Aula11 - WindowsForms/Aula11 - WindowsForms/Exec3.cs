using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11___WindowsForms
{
    public partial class Exec3 : Form
    {
        public Exec3()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            string insert = $"INSERT into dbo.NomeProduto (Nome) values ('{txtNome.Text}')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Produto adicionado com sucesso!");
            txtNome.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstItens.Items.Clear();
            List<string> dados = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            string select = $"SELECT Nome from dbo.NomeProduto";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dados.Add(Convert.ToString(dr["Nome"]));
            }
            foreach (var item in dados)
            {
                lstItens.Items.Add("Nome: " + item);
            }
        }
    }
}
