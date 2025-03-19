using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaPlaca
{
    public static class Database
    {
        public static void SalvarPlacaDeCarro(string placa)
        {
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            if (conexao.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Conectado ao banco de dados!");
            else
                Console.WriteLine("Não conectado");

            string query = "insert into placadecarro (Placa) values(@placa)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public static List<string> ListaPlacas()
        {
            List<string> placas = new List<string>();
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
               "; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "select * from placadecarro";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader conteudo = cmd.ExecuteReader();
            while (conteudo.Read()) { 
                placas.Add(conteudo.GetString("Placa"));
            }
            return placas;
           
        }

    }
}
