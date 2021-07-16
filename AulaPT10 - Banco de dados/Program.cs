using System;
using System.Data.SqlClient;

namespace AulaPT10___Banco_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exemplo
            //while (true)
            //{
            //    Console.WriteLine("O que você deseja fazer?");
            //    string escolha = Console.ReadLine().ToLower();
            //    if (escolha == "select")
            //    {
            //        MostrarDados();
            //    }
            //    else if (escolha == "insert")
            //    {
            //        SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //        conn.Open();
            //        Console.WriteLine("Nome");
            //        string nome = Console.ReadLine();
            //        Console.WriteLine("Idade");
            //        int idade = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Cpf");
            //        string cpf = Console.ReadLine();
            //        string insert = "INSERT into dbo.Pessoa (Nome, Cpf, idade) values ('" + nome + "', '" + cpf + "', '" + idade + "')";
            //        SqlCommand cmd;
            //        cmd = new SqlCommand(insert, conn);
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //    }
            //    else if (escolha == "update")
            //    {
            //        Console.WriteLine("Mostrando todos os nomes, escolha qual você deseja alterar");
            //        MostrarDados(2);
            //        string nome = Console.ReadLine();
            //        Console.WriteLine("Insira o novo nome");
            //        string novoNome = Console.ReadLine();
            //        Console.WriteLine("Insira o novo Cpf");
            //        string novoCpf = Console.ReadLine();
            //        Console.WriteLine("Insira a nova Idade");
            //        int novaIdade = int.Parse(Console.ReadLine());

            //        SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //        conn.Open();
            //        string update = "UPDATE dbo.Pessoa Set Nome = '" + novoNome + "', Cpf = '" + novoCpf + "', Idade = " + novaIdade + " WHERE Nome = '" + nome + "'";
            //        SqlCommand cmd = new SqlCommand();
            //        cmd = new SqlCommand(update, conn);
            //        cmd.ExecuteNonQuery();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mostrando todos os nomes, escolha qual você deseja deletar");
            //        MostrarDados(2);
            //        string nome = Console.ReadLine();
            //        SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //        conn.Open();
            //        string delete = "DELETE from dbo.Pessoa where Nome = '" + nome + "'";
            //        SqlCommand cmd = new SqlCommand(delete, conn);
            //        cmd.ExecuteNonQuery();
            //    }
            //}

            ////01
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //conn.Open();
            //SqlCommand cmd;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o cliente " + (i + 1));
            //    Console.WriteLine("Insira o nome:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o Cpf:");
            //    string cpf = Console.ReadLine();
            //    Console.WriteLine("Insira o Idade:");
            //    int idade = int.Parse(Console.ReadLine());
            //    string insert = "INSERT into dbo.Cliente (Nome, Cpf, idade) values ('" + nome + "', '" + cpf + "', '" + idade + "')";
            //    cmd = new SqlCommand(insert, conn);
            //    cmd.ExecuteNonQuery();
            //}
            //string select = "SELECT Nome, Idade, Cpf FROM dbo.Cliente";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Nome: " + dr["Nome"]);
            //    Console.WriteLine("Cpf: " + dr["Cpf"]);
            //    Console.WriteLine("Idade: " + dr["Idade"]);
            //    Console.WriteLine();
            //}
            //conn.Close();            

            ////02
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //conn.Open();
            //SqlCommand cmd;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o cachorro " + (i + 1));
            //    Console.WriteLine("Insira o nome:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o nome do dono:");
            //    string nomeDono = Console.ReadLine();
            //    Console.WriteLine("Insira o telefone do dono:");
            //    string telefoneDono = Console.ReadLine();
            //    string insert = "INSERT into dbo.PetShop (Nome, NomeDoDono, TelefoneDoDono) values ('" + nome + "', '" + nomeDono + "', '" + telefoneDono + "')";
            //    cmd = new SqlCommand(insert, conn);
            //    cmd.ExecuteNonQuery();
            //}
            //string select = "SELECT Nome, NomeDoDono, TelefoneDoDono FROM dbo.PetShop";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Nome: " + dr["Nome"]);
            //    Console.WriteLine("Cpf: " + dr["NomeDoDono"]);
            //    Console.WriteLine("Idade: " + dr["TelefoneDoDono"]);
            //    Console.WriteLine();
            //}
            //conn.Close();

            ////03
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //SqlCommand cmd;
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o funcionario " + (i + 1));
            //    Console.WriteLine("Insira o nome:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o cargo:");
            //    string cargo = Console.ReadLine();
            //    Console.WriteLine("Insira o salário:");
            //    int salario = int.Parse(Console.ReadLine());
            //    string insert = "INSERT into dbo.Funcionarios (Nome, Cargo, Salario) values ('" + nome + "', '" + cargo + "', '" + salario + "')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //conn.Open();
            //string select = "SELECT Nome, Cargo, Salario FROM dbo.Funcionarios WHERE Salario > 3000";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Nome: " + dr["Nome"]);
            //    Console.WriteLine("Cargo: " + dr["Cargo"]);
            //    Console.WriteLine("Salario: {0:c}", dr["Salario"]);
            //    Console.WriteLine();
            //}
            //conn.Close();

            ////04
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //SqlCommand cmd;
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o email " + (i + 1));
            //    Console.WriteLine("Insira o email:");
            //    string email = Console.ReadLine();
            //    string insert = "INSERT into dbo.Emails (Email) values ('" + email + "')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //conn.Open();
            //string select = "SELECT * FROM dbo.Emails WHERE Email LIKE '%@outlook.com%' OR Email LIKE '%@outlook.br%'";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Email: " + dr["Email"]);
            //    Console.WriteLine();
            //}
            //conn.Close();

            ////05
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //SqlCommand cmd;       

            //conn.Open();
            //string update = "UPDATE dbo.Funcionarios Set Salario = " + 3000 + " WHERE Salario < 3000";
            //cmd = new SqlCommand(update, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //conn.Open();
            //string select = "SELECT Nome, Cargo, Salario FROM dbo.Funcionarios WHERE Salario >= 3000";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Nome: " + dr["Nome"]);
            //    Console.WriteLine("Cargo: " + dr["Cargo"]);
            //    Console.WriteLine("Salario: {0:c}", dr["Salario"]);
            //    Console.WriteLine();
            //}
            //conn.Close();

            ////06
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            //conn.Open();
            //string delete = "DELETE from dbo.Emails WHERE NOT Email LIKE '%@outlook.com%' OR Email NOT LIKE '%@outlook.br%'";
            ////string delete = "DELETE from dbo.Emails WHERE Email NOT LIKE '%@outlook.com%' OR NOT Email  LIKE '%@outlook.br%'";
            ////string delete = "DELETE from dbo.Emails WHERE NOT CONTAINS(Email, '@outlook.com')";
            //SqlCommand cmd = new SqlCommand(delete, conn);
            //cmd.ExecuteNonQuery();

            //string select = "SELECT Email FROM dbo.Emails";
            //SqlDataReader dr;
            //cmd = new SqlCommand(select, conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Email: " + dr["Email"]);
            //    Console.WriteLine();
            //}
            //conn.Close();

            //07
            SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            SqlCommand cmd;

            conn.Open();
            string update = "UPDATE dbo.Funcionarios Set Salario = Salario * 1.2593";
            cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            update = "UPDATE dbo.Funcionarios Set Salario = Salario * 0.9424 WHERE Salario > 5000";
            cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            conn.Open();
            string select = "SELECT Nome, Cargo, Salario FROM dbo.Funcionarios";
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Nome: " + dr["Nome"]);
                Console.WriteLine("Cargo: " + dr["Cargo"]);
                Console.WriteLine("Salario: {0:c}", dr["Salario"]);
                Console.WriteLine();
            }
            conn.Close();
        }
        public static void MostrarDados()
        {
            SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            conn.Open();
            string select = "SELECT Nome, Idade, Cpf FROM dbo.Pessoa";
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Nome: " + dr["Nome"]);
                Console.WriteLine("Cpf: " + dr["Cpf"]);
                Console.WriteLine("Idade: " + dr["Idade"]);
                Console.WriteLine();
            }
            conn.Close();
        }
        public static void MostrarDados(int a)
        {
            SqlConnection conn = new SqlConnection("Data Source = BUE205D12; Initial Catalog = tempdb; User ID=guest01;Password=@Senac2021");
            conn.Open();
            string select = "SELECT Nome, Idade, Cpf FROM dbo.Pessoa";
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand(select, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Nome: " + dr["Nome"]);
                Console.WriteLine();
            }
            conn.Close();
        }
    }
}
