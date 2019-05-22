using MySql.Data.MySqlClient;
using PimServices.Model;
using System;
using System.Collections.Generic;

namespace PimServices.RepositorySql
    {

    using System.Windows.Forms;

    namespace PimServices.RepositorySql
        {
        public class DaoMotorista : ConexaoBancoMySQL
            {
            public void SalvarMotorista(Motorista m)
                {

                try
                    {

                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String insertDados = "INSERT INTO cadastro_motorista" +
                        "(nome_rua_motorista, endereco_numero_motorista, cep_motorista," +
                        "id_cidade, cnh_motorista, nome_motorista, bairro_motorista, " +
                        "dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista," +
                        "celular,telefone_fixo)" +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?);";

                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.rua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("endereco_numero_motorista", m.numero));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep_motorista", m.Cep));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnh_motorista", m.cnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_motorista", m.nome));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro_motorista", m.Bairro));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_nascimento_motorista", m.dtaNascimento));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf_motorista", m.cpf));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_vencimento_cnh_motorista", m.dtaVencimentoCnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", m.celular));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telefone_fixo", m.telefoneFixo));

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();


                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao cadastrar Motorista, verifique a conexão com o banco de dados: " + ex.ToString());

                    }
                }

            public bool EditarMotorista(Motorista m)
                {
                try
                    {

                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String alterarDados = "UPDATE cadastro_motorista set nome_rua_motorista = @nomeRua, endereco_numero_motorista = @numeroRua, cep_motorista = @Cep," +
                    " id_cidade = @idCidade, cnh_motorista = @cnh, nome_motorista = @nome, bairro_motorista = @bairro, dta_nascimento_motorista = @dtaNascimento," +
                    "cpf_motorista = @cpf, dta_vencimento_cnh_motorista = @dtaVencimentoCnh,@telefone_fixo,@celular";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alterarDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.rua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("endereco_numero_motorista", m.numero));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep_motorista", m.Cep));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnh_motorista", m.cnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_motorista", m.nome));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("bairro_motorista", m.Bairro));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_nascimento_motorista", m.dtaNascimento));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf_motorista", m.cpf));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_vencimento_cnh_motorista", m.dtaVencimentoCnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", m.celular));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telefone_fixo", m.telefoneFixo));
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao editar o Motorista, verifique a conexão com o banco de dados: " + ex.ToString());
                    return false;
                    }
                }


            public void ExcluirMotorista(Motorista m)
                {

                try
                    {
                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String excluirDados = "DELETE FROM cadastro_motorista where id_motorista = @id_motorista";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(excluirDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_motorista", m.id_motorista));


                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Motorista Excluido com sucesso!");
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao excluir, verifique a conexão com o banco de dados: " + ex.ToString());

                    }
                }

            public List<Motorista> TodosMotoristas()
                {
                List<Motorista> todosMotoristas = new List<Motorista>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT * FROM cadastro_motorista";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

                try
                    {

                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Motorista> list = new List<Motorista>();

                    while (reader.Read())
                        {
                        Motorista novo = new Motorista();


                        novo.id_motorista = Convert.ToInt32(reader["id_motorista"].ToString());
                        novo.nome = reader["nome_motorista"].ToString();
                        novo.rua = reader["nome_rua_motorista"].ToString();
                        novo.numero = reader["endereco_numero_motorista"].ToString();
                        novo.Cep = reader["cep_motorista"].ToString();
                        novo.cnh = reader["cnh_motorista"].ToString();
                        novo.Bairro = reader["bairro_motorista"].ToString();
                        novo.dtaNascimento = Convert.ToDateTime(reader["dta_nascimento_motorista"].ToString());
                        novo.cpf = reader["cpf_motorista"].ToString();
                        novo.dtaVencimentoCnh = Convert.ToDateTime(reader["dta_vencimento_cnh_motorista"].ToString());
                        novo.celular = reader["celular"].ToString();
                        novo.telefoneFixo = reader["telefone_fixo"].ToString();

                        list.Add(novo);
                        }
                    conn.Close();

                    }
                finally
                    {
                    conn.Close();
                    }
                return todosMotoristas;
                }

            }
        /*public bool RetornaNome()
            {
            try
                {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String buscaNome = "SELECT * FROM cadastro_motorista WHERE nome_motorista = '@nome_motorista'";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(buscaNome, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_motorista", conn));
                
               
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
                }
            catch (Exception ex)
                {
                MessageBox.Show("Erro ao editar o Motorista, verifique a conexão com o banco de dados: " + ex.ToString());
                return false;
                }
            }

        }*/


        }
    }



