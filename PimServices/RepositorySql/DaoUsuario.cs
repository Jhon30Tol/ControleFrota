using PimServices.Model;
using MySql.Data.MySqlClient;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PimServices.RepositorySql
{

    public class DaoUsuario : ConexaoBancoMySQL
    {



        public void SalvarUsuario(Usuario u)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO cadastro_usuario(nome_usuario, senha_usuario, ativo)" +
                    "VALUES (?, MD5(?), ?);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", u.Nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("senha", u.Senha));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ativo", u.Ativo));

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public void EditarrUsuario(Usuario u)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String alteratDados = "UPDATE cadastro_usuario set nome_usuario = @nome, senha_usuario = MD5(@senha), ativo = @ativo where id_usuario = @id";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", u.Id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", u.Nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("senha", u.Senha));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ativo", u.Ativo));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public void ExcluirUsuario(Usuario u)
        {

            try
            {
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String alteratDados = "DELETE FROM cadastro_usuario where id_usuario = @id";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", u.Id));


                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public List<Usuario> BuscarTodosUsuarios(Usuario u)
        {
            List<Usuario> todosUsuarios = new List<Usuario>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "select id_usuario, nome_usuario, ativo, senha_usuario from cadastro_usuario ";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario novo = new Usuario();

                    novo.Id = (int)reader["id_usuario"];
                    novo.Nome = reader["nome_usuario"].ToString();
                    novo.Senha = reader["senha_usuario"].ToString();
                    novo.Ativo = reader["ativo"].ToString();
                    todosUsuarios.Add(novo);


                }

                conn.Close();
                return todosUsuarios;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Usuario> BuscarPorNomeAtivo(String nome)
        {
            List<Usuario> BuscarPorNomeAtivo = new List<Usuario>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaPorNome = "select id_usuario, nome_usuario, ativo, senha_usuario from cadastro_usuario where ativo = 's' and nome_usuario like '%" + @nome + "%'";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaPorNome, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nomw", nome));


            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario novo = new Usuario();

                    novo.Id = (int)reader["id_usuario"];
                    novo.Nome = reader["nome_usuario"].ToString();
                    novo.Senha = reader["senha_usuario"].ToString();
                    novo.Ativo = reader["ativo"].ToString();
                    BuscarPorNomeAtivo.Add(novo);


                }

                conn.Close();
                return BuscarPorNomeAtivo;
            }
            finally
            {
                conn.Close();
            }

        }

        public List<Usuario> BuscarPorNomeInativo(String nome)
        {
            List<Usuario> BuscarPorNomeInativo = new List<Usuario>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaPorNome = "select id_usuario, nome_usuario, ativo, senha_usuario from cadastro_usuario where ativo = 'n'and  nome_usuario like '%" + @nome + "%'";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaPorNome, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nomw", nome));


            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario novo = new Usuario();

                    novo.Id = (int)reader["id_usuario"];
                    novo.Nome = reader["nome_usuario"].ToString();
                    novo.Senha = reader["senha_usuario"].ToString();
                    novo.Ativo = reader["ativo"].ToString();
                    BuscarPorNomeInativo.Add(novo);


                }

                conn.Close();
                return BuscarPorNomeInativo;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Usuario> BuscarPorNomeUsuarioAtivo(String nome)
        {
            List<Usuario> BuscarPorNomeUsuarioAtivo = new List<Usuario>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaPorNome = "select id_usuario, nome_usuario, ativo, senha_usuario from cadastro_usuario where ativo = 's' and nome_usuario like '%" + @nome + "%'";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaPorNome, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nomw", nome));


            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Usuario novo = new Usuario();

                    novo.Id = (int)reader["id_usuario"];
                    novo.Nome = reader["nome_usuario"].ToString();
                    novo.Senha = reader["senha_usuario"].ToString();
                    novo.Ativo = reader["ativo"].ToString();
                    BuscarPorNomeUsuarioAtivo.Add(novo);


                }

                conn.Close();
                return BuscarPorNomeUsuarioAtivo;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}

