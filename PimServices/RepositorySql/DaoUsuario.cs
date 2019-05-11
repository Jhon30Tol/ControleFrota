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

                MessageBox.Show("Usuario salvo com sucesso!");
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
                String alteratDados = "UPDATE cadastro_usuario set nome_usuario = @nome, senha_usuario = @senha, ativo = @ativo where id_usuario = @id";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", u.Id));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", u.Nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("senha", u.Senha));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ativo", u.Ativo));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Usuario Editado com sucesso!");
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

                MessageBox.Show("Usuario Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public List<Usuario> BuscarTodosUsuarios(Usuario u)
        {
            List<Usuario> todosUsuarios = new List<Usuario>();
            MySqlDataReader reader;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            // MySqlDataAdapter pesq = new MySqlDataAdapter("select id_usuario, nome_usuario, ativo from cadastro_usuario ", conn);

            cmd.CommandText = "select id_usuario, nome_usuario, ativo from cadastro_usuario ";

            try
            {

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Usuario novo = new Usuario();

                    novo.Id = (int)reader["@id"];
                    novo.Nome = reader["@nome"].ToString();
                    todosUsuarios.Add(novo);


                }

                conn.Close();
                //reader.Close();
                return todosUsuarios;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}

