using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aula11___WindowsForms
{
    public partial class Exec2 : Form
    {
        public Exec2()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            List<Cadastro> cadastros = new List<Cadastro>();
            SqlConnection conn = new SqlConnection("Data Source=BUE205D002;Initial Catalog=BDTurmaManha;User ID=guest01;Password=@Senac2021");
            conn.Open();
            string select = "SELECT * FROM dbo.Cadastro";
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cadastro cadastro = new Cadastro(Convert.ToString(dr["usuario"]), Convert.ToString(dr["senha"]));
                cadastros.Add(cadastro);
            }
            dr.Close();
            conn.Close();
            bool login = false;
            foreach (var item in cadastros)
            {
                if(item.Usuario == txtLogin.Text && item.Senha == txtSenha.Text)
                {
                    MessageBox.Show("Login efetuado!");
                    login = true;
                    Form1 form = new Form1();
                    this.Visible = false;
                    form.Show();
                }
            }
            if (login == false)
            {
                MessageBox.Show("Usuário e/ou senha incorretos!");
            }
        }
    }
}
