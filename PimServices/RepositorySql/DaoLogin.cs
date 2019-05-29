using MySql.Data.MySqlClient;
using PimServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimServices.RepositorySql
{
    public class DaoLogin : ConexaoBancoMySQL
    {
        public bool AutenticarUsuario(Usuario u)
        {
            try
            {
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String validarUsuario = "SELECT * FROM cadastro_usuario WHERE nome_usuario = @nome AND senha_usuario = MD5(@senha) AND ativo = 's';";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(validarUsuario, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", u.Nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("senha", u.Senha));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ativo", u.Ativo));
                int retorno = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (retorno > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados incorretos, informe novamente! " + ex.ToString());
                return false;
            }
        }
    }
}
