<<<<<<< HEAD
﻿using System;
=======
﻿using MySql.Data.MySqlClient;
using PimServices.Model;
using System;
>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace PimServices.RepositorySql
{
    public class DaoMotorista
    {

    }
=======
using System.Windows.Forms;

namespace PimServices.RepositorySql
{
    public class DaoMotorista: ConexaoBancoMySQL
    {
        public void SalvarMotorista(Motorista m)
        {
        /*
            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO cadastro_motorista" +
                    "(nome_rua_motorista, endereco_numero_motorista, cep_motorista," +
                    "id_cidade, cnh_motorista, nome_motorista, bairro_motorista, " +
                    "dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista)" +
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
                
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.nomeRua));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("endereco_numero_motorista", m.numeroRua));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep_motorista", m.cep));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_cidade", m.idCidade));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnh_motorista", m.cnh));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_motorista", m.nome));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro_motorista", m.bairro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_nascimento_motorista", m.dtaNascimento));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf_motorista", m.cpf));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_vencimento_cnh_motorista", m.dtaVencimentoCnh));


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
            /*

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
                MessageBox.Show(u.Senha, "");
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
                MessageBox.Show(u.Senha, "");
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Usuario Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
            */
        }
        
    }
    
>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f
}
