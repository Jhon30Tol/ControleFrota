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
                        "dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista)" +
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";

                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.nomeRua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("endereco_numero_motorista", m.numeroRua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep_motorista", m.Cep));
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

                    MessageBox.Show("Motorista salvo com sucesso!");
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao cadastrar Motorista, verifique a conexão com o banco de dados: " + ex.ToString());

                    }
                }

            public void EditarMotorista(Motorista m)
                {


                try
                    {

                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String alterarDados = "UPDATE cadastro_motorista set nome_rua_motorista = @nomeRua, endereco_numero_motorista = @numeroRua, cep_motorista = @Cep," +
                    " id_cidade = @idCidade, cnh_motorista = @cnh, nome_motorista = @nome, bairro_motorista = @bairro, dta_nascimento_motorista = @dtaNascimento," +
                    "cpf_motorista = @cpf, dta_vencimento_cnh_motorista = @dtaVencimentoCnh";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alterarDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.nomeRua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("endereco_numero_motorista", m.numeroRua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep_motorista", m.Cep));
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

                    MessageBox.Show("Motorista Editado com sucesso!");
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao editar o Motorista, verifique a conexão com o banco de dados: " + ex.ToString());

                    }
                }
            public bool buscaCep(Motorista m)
                {

                try
                    {

                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String buscaCepNoBanco = "SELECT c.nome, " +
                                             "b.nome , " +
                                             "a.nome_cidade, " +
                                             "c.id_uf " +
                                             "FROM cadastro_endereco c " +
                                             "JOIN cadastro_bairro b " +
                                             "JOIN cadastro_cidade a " +
                                             "ON c.id_bairro = b.id_bairro " +
                                             "AND c.id_cidade = a.id_cidade" +
                                             "where c.cep = @cep;";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(buscaCepNoBanco, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_cidade", m.Cidade));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cod_ibge", m.Cep));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("uf_estado", m.Uf));
                    int retorno = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Prepare();                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("cheguei aqui");
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
                    MessageBox.Show("CEP Invalido! " + ex.ToString());
                    return false;
                    }

                }

            public void ExcluirMotorista(Motorista m)
                {

                try
                    {
                    MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                    conn = new MySqlConnection(connectionString);
                    String excluirDados = "DELETE FROM ccadastro_motorista where nome_motorista = @nome";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(excluirDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_motorista", m.nome));


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

            public List<Motorista> buscarMotoristas(Motorista m)
                {
                List<Motorista> todosMotoristas = new List<Motorista>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT FROM cadastro_motorista" +
                        "nome_rua_motorista, endereco_numero_motorista, cep_motorista," +
                        "id_cidade, cnh_motorista, nome_motorista, bairro_motorista, " +
                        "dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

                try
                    {

                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                        {
                        Motorista novo = new Motorista();

                        novo.nome = reader["id_usuario"].ToString();
                        novo.nomeRua = reader["nome_rua_motorista"].ToString();
                        novo.numeroRua = reader["endereco_numero_rua"].ToString();
                        novo.cep = (int)reader["cep_motorista"];
                        novo.idCidade = (int)reader["id_cidade"];
                        novo.cnh = reader["id_cidade"].ToString();
                        novo.cnh = reader["cnh_motorista"].ToString();
                        novo.nome = reader["nome_motorista"].ToString();
                        novo.Bairro = reader["bairro_motorista"].ToString();
                        novo.dtaNascimento = (DateTime)reader["dta_nascimento_motorista"];
                        novo.cpf = reader["cpf_motorista"].ToString();
                        novo.dtaVencimentoCnh = (DateTime)reader["dta_vencimento_cnh_motorista"];
                        todosMotoristas.Add(novo);


                        }

                    conn.Close();
                    return todosMotoristas;
                    }
                finally
                    {
                    conn.Close();
                    }
                }

            }

        }
    }



