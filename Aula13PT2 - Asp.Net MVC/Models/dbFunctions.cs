using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Aula13PT2___Asp.Models
{
    public class dbFunctions
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=CASSIMIRO;Initial Catalog=Cassimiro.sistem;Integrated Security=True");
        public static void InsereConta(string numeroConta, string saldo)
        {
            string insert = $"INSERT into dbo.Conta1(NumeroConta,Saldo) values ('{numeroConta}',{Convert.ToInt32(saldo)})";
            SqlCommand cmd = new SqlCommand(insert, Connection);
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();

            }
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
