using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ViagemTour.Models
{
    public class AppQueries
    {
        private Contexto contexto;

        public void Insert(string query)
        {
            PostQuery(query);
        }

        public void Update(string query)
        {
            PostQuery(query);
        }

        public void Delete(string query)
        {
            PostQuery(query);
        }

        private void PostQuery(string query)
        {
            using (contexto = new Contexto())
            {
                contexto.EnviaDados(query);
            }
        }

        private List<Contato> GetQuery(string query, Func<SqlDataReader, List<Contato>> method)
        {
            using (contexto = new Contexto())
            {
                SqlDataReader data = contexto.RecebeDados(query);
                return method(data);
            }
        }

        public List<Contato> Listar(string stringQuery)
        {
            return GetQuery(stringQuery, TransformData);

            /*
            using (contexto = new Contexto())
            {
                SqlDataReader data = contexto.RecebeDados(stringQuery);
                return TransformData(data);
            }*/
        }

        public List<Promocao> ListarPromocao(string stringQuery)
        {
            using (contexto = new Contexto())
            {
                SqlDataReader data = contexto.RecebeDados(stringQuery);
                return TransformDataPromocao(data);
            }
        }

        public Promocao ListById(int id)
        {
            string stringQuery = string.Format("SELECT * FROM Promocao WHERE Id={0}", id);

            using (contexto = new Contexto())
            {
                SqlDataReader data = contexto.RecebeDados(stringQuery);
                return TransformDataPromocao(data).FirstOrDefault();
            }
        }

        public Contato ListByIdContato(int id)
        {
            string stringQuery = string.Format("SELECT * FROM Contato WHERE Id={0}", id);

            using (contexto = new Contexto())
            {
                SqlDataReader data = contexto.RecebeDados(stringQuery);
                return TransformData(data).FirstOrDefault();
            }
        }

        private List<Contato> TransformData(SqlDataReader sqlDataReader)
        {
            List<Contato> ListaContato = new List<Contato>();

            while (sqlDataReader.Read())
            {
                Contato contato = new Contato()
                {
                    Id = int.Parse(sqlDataReader["Id"].ToString()),
                    Nome = sqlDataReader["Nome"].ToString(),
                    Email = sqlDataReader["Email"].ToString(),
                    Mensagem = sqlDataReader["Mensagem"].ToString()
                };

                ListaContato.Add(contato);
            }

            sqlDataReader.Close();
            
            return ListaContato;
        }

        private List<Promocao> TransformDataPromocao(SqlDataReader sqlDataReader)
        {
            List<Promocao> ListaPromocao = new List<Promocao>();

            while (sqlDataReader.Read())
            {
                Promocao promocao = new Promocao()
                {
                    Id = int.Parse(sqlDataReader["Id"].ToString()),
                    Local = sqlDataReader["Local"].ToString(),
                    QuantidadeDias = int.Parse(sqlDataReader["QuantidadeDeDias"].ToString()),
                    Hospedagem = sqlDataReader["Hospedagem"].ToString(),
                    CafeDaManha = sqlDataReader["CafeDaManha"].ToString(),
                    PassagemAerea = sqlDataReader["PassagemAerea"].ToString(),
                    Preco = float.Parse(sqlDataReader["Preco"].ToString())
                };

                ListaPromocao.Add(promocao);
            }

            sqlDataReader.Close();

            return ListaPromocao;
        }
    }
}
