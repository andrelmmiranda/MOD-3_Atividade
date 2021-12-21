using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ViagemTour.Models
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection conexao;

        public Contexto()
        {
            conexao = new SqlConnection(@"data source=DESKTOP-UPCDEDI\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ViagemTour");
            conexao.Open();
        }

        public void EnviaDados(string stringQuery)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandText = stringQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            comando.ExecuteNonQuery();
        }

        public SqlDataReader RecebeDados(string stringQuery)
        {
            SqlCommand comando = new SqlCommand(stringQuery, conexao);

            return comando.ExecuteReader();
        }
        public void Dispose()
        {
            if(conexao.State == ConnectionState.Open) conexao.Close();
        }
    }
}
