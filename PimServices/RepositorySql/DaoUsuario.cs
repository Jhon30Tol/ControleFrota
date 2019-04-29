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


      //  FrmMensagemCadSucesso msgSucesso = new FrmMensagemCadSucesso();

 


    public class DaoUsuario: ConexaoBancoMySQL
    {
       // FrmCadIniusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];

        public void SalvarUsuario(Usuario u)
        {
      
            try
            {
                
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO cadastro_usuario(nome_usuario, senha_usuario, ativo)" +
                    "VALUES (?, ?, ?);";
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
                 
        //teste novo git        

                //  MessageBox.Show(id_usuario, "");
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
               // MessageBox.Show(cmd.Parameters(),"");
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Usuario salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        /*
              public static MUsuario PesquisaLogin(MUsuario usuario)
              {
                  SqlConnection conexao = new SqlConnection();
                  conexao.ConnectionString = Conexao.ConnectionString;
                  conexao.Open();

                  SqlCommand comando = new SqlCommand();
                  comando.Connection = conexao;
                  comando.CommandText = "select * from usuario where login=@login and senha=@senha";

                  SqlParameter param = new SqlParameter("@login", SqlDbType.VarChar);
                  param.Value = usuario.login;
                  comando.Parameters.Add(param);

                  param = new SqlParameter("@senha", SqlDbType.VarChar);
                  param.Value = MUsuario.Cripitografar(usuario.senha);
                  comando.Parameters.Add(param);

                  try
                  {
                      comando.Connection = conexao;
                      SqlDataReader reader = comando.ExecuteReader();

                      if (reader != null)
                      {
                          if (reader.Read())
                          {
                              usuario.id = (int)reader["id"];
                              usuario.login = reader["login"].ToString();
                              usuario.status = (int)reader["status"];
                          }
                          reader.Close();
                      }
                      conexao.Close();
                  }
                  catch (Exception ex)
                  {
                      conexao.Close();
                  }

                  return usuario;




              }

              */

    }

}

