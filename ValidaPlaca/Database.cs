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
            string stringDeConexao = "Server=127.0.0.1;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;SslMode=None";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            if (conexao.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Conectado ao banco de dados!");
            else
                Console.WriteLine("Não conectado");

            conexao.Close();
        }
    }
}
