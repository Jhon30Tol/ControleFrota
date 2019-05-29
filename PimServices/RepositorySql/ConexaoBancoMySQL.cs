using MySql.Data.MySqlClient;
using System;

namespace PimServices.RepositorySql
    {
    public class ConexaoBancoMySQL
        {
        public MySqlConnection conn = null;
        public String connectionString = @"server=localhost;User Id = root; password=root;database=sislog; SslMode = none";
        public MySqlConnection getConnection()
            {
            MySqlConnection conn = new MySqlConnection(connectionString);
            Console.WriteLine("Cadastro Realizado com sucesso!");
            return conn;
            }
        }
    }