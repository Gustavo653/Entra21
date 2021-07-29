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
    public partial class Exec5 : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        public Exec5()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string insert = $"INSERT into dbo.Funcionarios (Nome, Cpf, Salario) values ('{txtNome.Text}', '{txtCpf.Text}', '{txtSalario.Text}')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Funcionarios";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            da.Fill(tabela);
            dgvItens.DataSource = tabela; 
            conn.Close();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Funcionarios Set Salario = 3000 WHERE Salario < 2000";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
