using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class LivrariaDAL
    {
        private string connectionString = @"Data Source=DESKTOP-EIQSN19\SQLEXPRESS;Initial Catalog=livraria;Integrated Security=true";

        public void CadastrarLivro(Livro objLivro)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Livros VALUES (@p1, @p2, @p3)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@p1", objLivro.TituloLivro);
            cmd.Parameters.AddWithValue("@p2", objLivro.SinopseLivro);
            cmd.Parameters.AddWithValue("@p3", objLivro.NomeAutor);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirLivro(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "DELETE FROM Livros WHERE CdLivro = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Livro> ListarLivros()
        {
            List<Livro> listaLivros = new List<Livro>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Livros order by TituloLivro asc";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Livro objLivro = null;
                while (dr.Read())
                {
                    objLivro = new Livro();
                    objLivro.CdLivro = Convert.ToInt32(dr["CdLivro"]);
                    objLivro.TituloLivro = dr["TituloLivro"].ToString();
                    objLivro.SinopseLivro = dr["SinopseLivro"].ToString();
                    objLivro.NomeAutor = dr["AutorLivro"].ToString();

                    listaLivros.Add(objLivro);
                }
            }

            return listaLivros;
        }

        public Livro BuscarLivro(int codigo)
        {
            Livro objLivro = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Livros WHERE CdLivro = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLivro = new Livro();
                objLivro.CdLivro = codigo;
                objLivro.TituloLivro = dr["TituloLivro"].ToString();
                objLivro.SinopseLivro = dr["SinopseLivro"].ToString();
                objLivro.NomeAutor = dr["AutorLivro"].ToString();
            }

            conn.Close();

            return objLivro;
        }

        public void AtualizarLivro(Livro l)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"UPDATE Livros SET TituloLivro = @p1, SinopseLivro = @p2,
                        AutorLivro = @p3 WHERE CdLivro = @p4";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@p1", l.TituloLivro);
            cmd.Parameters.AddWithValue("@p2", l.SinopseLivro);
            cmd.Parameters.AddWithValue("@p3", l.NomeAutor);
            cmd.Parameters.AddWithValue("@p4", l.CdLivro);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
