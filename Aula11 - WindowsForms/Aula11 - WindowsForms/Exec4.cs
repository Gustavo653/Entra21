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
    public partial class Exec4 : Form
    {
        public Exec4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> dados = new List<string>();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UEQIVQ6;Initial Catalog=master;Integrated Security=True");
            string select = $"SELECT Nome from dbo.Nomes";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dados.Add(Convert.ToString(dr["Nome"]));
            }
            dr.Close();
            conn.Close();
            if (dados.Count > 4)
            {
                foreach (var item in dados)
                {
                    lstNomes.Items.Add("Nome: " + item);
                }
                string delete = "DELETE from dbo.Nomes";
                cmd = new SqlCommand(delete, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                string insert = $"INSERT into dbo.Nomes (Nome) values ('{txtNome.Text}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                txtNome.Text = "";
            }
        }
    }
}
