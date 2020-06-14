using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;



namespace trabai.Models
{
    public class Usuario
    {
        public static void ValorUsuario(string nome, string usuário, string email, string senha)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = $"INSERT cadastro Values('{nome}','{usuário}','{email}','{senha}')";
            command.ExecuteNonQuery();
        }
     
    }
}
