using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11PT2._2___MVC.Model
{
    class DBConnection
    {
        private static SqlConnection conn = new SqlConnection("");
        public static void Saque(string contaInformada, int quantia)
        {
            string update = $"UPDATE dbo.Contas Set Saldo = Saldo - {quantia} WHERE Numero = {contaInformada}";
            Execute(update);
        }
        public static bool ContaExiste(string contaInformada)
        {
            bool conta = false;
            List<string> lista = GenericSelectUnit("Numero", "Contas");
            foreach (var item in lista)
            {
                if (contaInformada == item)
                {
                    conta = true;
                }
            }
            if (conta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Execute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Select all values from column from given table, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string> GenericSelectUnit(string column, string table)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
                //lista.Add(dr[column].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }

        /// <summary>
        /// Select all values from column from given table and WHERE Condition, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string> GenericSelectUnit(string column, string table, string where)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table} WHERE {where}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
                //lista.Add(dr[column].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }

        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
    }
}
