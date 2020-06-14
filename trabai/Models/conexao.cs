using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace trabai.Models
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            string conexao = @"Data Source=(localdb)\trabai;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            return connection;


        }
    }
}
