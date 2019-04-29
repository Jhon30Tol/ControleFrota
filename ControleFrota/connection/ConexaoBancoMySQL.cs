using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ControleFrota
{
    public class ConexaoBancoMySQL
    {
        private static MySqlConnection objConexao = null;

        private String stringconnection1 = "server=localhost;User Id = root; password=root;database=syslog;";

public void tentarAbrirConexaoLocal()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }

        public void tentarAbrirConexaoRemota()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }


        public ConexaoBancoMySQL()
        {
            try
            {
                tentarAbrirConexaoRemota();
            }
            catch
            {
                try
                {
                    tentarAbrirConexaoLocal();
                }
                catch
                {
                    Console.WriteLine(" Não foi possivel a conexão!");

                }
            }

        }

        public static MySqlConnection getConexao()
        {
            new ConexaoBancoMySQL();
            return objConexao;
        }
        public static void fecharConexao()
        {
            objConexao.Close();
        }
    }
}