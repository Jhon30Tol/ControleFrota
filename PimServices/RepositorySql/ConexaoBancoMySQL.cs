using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimServices.RepositorySql
{

    public class ConexaoBancoMySQL
    {

        public MySqlConnection conn = null;
        public String connectionString = @"server=localhost;User Id = root; password=senha;database=sislog; SslMode = none";
        public MySqlConnection getConnection()
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                Console.WriteLine("Cadastro Realizado com sucesso!");
                return conn;
            }
        
    }
}