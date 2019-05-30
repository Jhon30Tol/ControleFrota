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
                        "cnh_motorista, nome_motorista, bairro_motorista, " +
                        "dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista," +
                        "celular,telefone_fixo, Cidade_motorista, Uf_motorista)" +
                        "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?);";

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
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Cidade_motorista", m.Cidade));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Uf_motorista", m.Uf));
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
                    String alterarDados = "UPDATE cadastro_motorista set nome_rua_motorista = @rua, endereco_numero_motorista = @numero, cep_motorista = @cep," +
                    "cnh_motorista = @cnh, nome_motorista = @nome, bairro_motorista = @Bairro, dta_nascimento_motorista = @dtaNascimento," +
                    "cpf_motorista = @cpf, dta_vencimento_cnh_motorista = @dtaVencimentoCnh,telefone_fixo=@telefone,celular=@celular, Cidade_motorista = @Cidade, Uf_motorista =@Uf where id_motorista = @id";
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alterarDados, conn);
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome_rua_motorista", m.rua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("numero", m.numero));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cep", m.Cep));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cnh", m.cnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", m.nome));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Bairro", m.Bairro));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtaNascimento", m.dtaNascimento));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cpf", m.cpf));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtaVencimentoCnh", m.dtaVencimentoCnh));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("celular", m.celular));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("telefone", m.telefoneFixo));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("rua", m.rua));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", m.id_motorista));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Cidade_motorista", m.Cidade));
                    cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Uf_motorista", m.Uf));

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
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Erro ao excluir, verifique a conexão com o banco de dados: " + ex.ToString());
                    }
                }
            public List<Motorista> TodosMotoristas()
                {
                List<Motorista> list = new List<Motorista>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT id_motorista, nome_motorista, nome_rua_motorista, endereco_numero_motorista, cep_motorista, cnh_motorista, bairro_motorista, dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista, celular, telefone_fixo, Cidade_motorista, Uf_motorista FROM cadastro_motorista;";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
                try
                    {
                    MySqlDataReader reader = cmd.ExecuteReader();

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
                        novo.Cidade = reader["Cidade_motorista"].ToString();
                        novo.Uf = reader["Uf_motorista"].ToString();
                        list.Add(novo);
                        }
                    conn.Close();
                    }
                finally
                    {
                    conn.Close();
                    }
                return list;
                }
            public List<Motorista> NomeMotoristas(string nome)
                {
                List<Motorista> list = new List<Motorista>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT id_motorista, nome_motorista, nome_rua_motorista, endereco_numero_motorista, cep_motorista, cnh_motorista, bairro_motorista, dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista, celular, telefone_fixo, Cidade_motorista, Uf_motorista FROM cadastro_motorista where nome_motorista like '%" + @nome + "%'";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", nome));

                try
                    {
                    MySqlDataReader reader = cmd.ExecuteReader();

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
                        novo.Cidade = reader["Cidade_motorista"].ToString();
                        novo.Uf = reader["Uf_motorista"].ToString();
                        list.Add(novo);
                        }
                    conn.Close();
                    }
                finally
                    {
                    conn.Close();
                    }
                return list;
                }
            public List<Motorista> CpfMotoristas(string cpf)
                {
                List<Motorista> list = new List<Motorista>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT id_motorista, nome_motorista, nome_rua_motorista, endereco_numero_motorista, cep_motorista, cnh_motorista, bairro_motorista, dta_nascimento_motorista, cpf_motorista, dta_vencimento_cnh_motorista, celular, telefone_fixo, Cidade_motorista, Uf_motorista FROM cadastro_motorista where nome_motorista like '%" + @cpf + "%'";
                conn.Open();

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("nome", cpf));

                try
                    {
                    MySqlDataReader reader = cmd.ExecuteReader();

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
                        novo.Cidade = reader["Cidade_motorista"].ToString();
                        novo.Uf = reader["Uf_motorista"].ToString();
                        list.Add(novo);
                        }
                    conn.Close();
                    }
                finally
                    {
                    conn.Close();
                    }
                return list;
                }
            }
        }
    }



