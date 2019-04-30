//using PimFrota.Formularios.TelaCadastros.CadastroUsuario;
//using PimFrota.Formularios.TelaHome;
using PimServices.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PimServices.RepositorySql
{
    public class DaoLogin : ConexaoBancoMySQL
    {
        public void AutenticarUsuario(Usuario u)
        {
            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
             //   String nome = ;
             //   String senha = ;
                String validarUsuario = "SELECT * FROM cadastro_usuario Where nome_usuario = '" + nome + "' and senha_usuario = '" + senha + "'; ";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(validarUsuario, conn);


                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Login efetuado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados incorretos, informe novamente! " + ex.ToString());

            }
        }
    }
}
