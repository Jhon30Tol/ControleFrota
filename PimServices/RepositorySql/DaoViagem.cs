﻿using MySql.Data.MySqlClient;
using PimServices.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimServices.RepositorySql
{
    public class DaoViagem : ConexaoBancoMySQL
    {

        public void SalvarViagem(Viagem v)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO viagem(id_motorista, id_veiculo, id_cidade_destino, id_cidade_origem, dta_saida, km_cidade_origem, passageiro_viagem)" +
                    "VALUES (?, ?, ?, ?, ?, ?, ?);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_motorista", v.Id_motorista));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_veiculo", v.Id_veiculo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_cidade_destino", v.Id_cidadeDestino));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_cidade_origem", v.Id_cidadeSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dta_saida", v.DtaSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("km_cidade_origem", v.KmSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("passageiro_viagem", v.passageiro));




                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Viagem salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a viagem, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public void EditarViagem(Viagem v)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String alteratDados = "UPDATE viagem " +
                                      "SET id_motorista = @id_motorista, " +
                                      "id_veiculo = @Id_veiculo, " +
                                      "id_cidade_destino = @Id_cidadeDestino, " +
                                      "id_cidade_origem = @Id_cidadeRetorno, " +
                                      "km_cidade_origem = @KmSaida, " +
                                      "passageiro_viagem = @passageiro, " +
                                      "dta_retorno = @DtaRetorno, " +
                                      "dta_saida = @DtaSaida " +
                                     // "km_cidade_retorno = @KmRetorno" +
                                      "WHERE id_viagem = @id_viagem";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_viagem", v.Id_viagem));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_motorista", v.Id_motorista));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Id_veiculo", v.Id_veiculo));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Id_cidadeDestino", v.Id_cidadeDestino));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("Id_cidadeRetorno", v.Id_cidadeSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("KmSaida", v.KmSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("passageiro", v.passageiro));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("DtaRetorno", v.DtaRetorno));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("DtaSaida", v.DtaSaida));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("KmRetorno", v.KmRetorno));

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Viagem Editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar viagem, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }




        public void ExcluirViagem(Viagem v)
        {

            try
            {
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String alteratDados = "DELETE FROM viagem where id_viagem = @id";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", v.Id_viagem));


                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Viagem Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir viagem, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }



        public void GravarRetornoViagem(Viagem v)
        {


            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String alteratDados = "UPDATE viagem set dta_retorno = @dtaRetornoViagem, km_cidade_retorno = @kmRetorno where id_viagem = @id";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(alteratDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtaRetornoViagem", v.DtaRetorno));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", v.Id_viagem));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("kmRetorno", v.KmRetorno));




                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Retorno registrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }

        }
        /*
             public List<Viagem> PesquisarTodasViagens(Viagem v)
             {
                List<Viagem> pesquisarTodasViagens = new List<Viagem>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);

                String selecionaTodos = "SELECT " +
                                        "v.id_viagem as Codigo_Viagem," +
                                        "m.nome_motorista as Nome_Motorista, " +
                                        "a.modelo_veiculo as Modelo_Veiculo, " +
                                        "c.nome_cidade as Cidade_Saida, " +
                                        "b.nome_cidade as Cidade_Destino, " +
                                        "date(v.dta_saida) as Data_Saida, " +
                                        "v.km_cidade_origem as Km_saida, " +
                                        "v.passageiro_viagem as Passageiro, " +
                                        "v.km_cidade_retorno as Km_retorno " +
                                        "FROM viagem v " +
                                        "JOIN cadastro_motorista m " +
                                        "JOIN cadastro_veiculo a " +
                                        "JOIN cadastro_cidade c " +
                                        "JOIN cadastro_cidade b " +
                                        "ON v.id_motorista = m.id_motorista  " +
                                        "AND v.id_veiculo = a.id_veiculo " +
                                        "AND  v.id_cidade_origem = c.id_cidade " +
                                        "AND  v.id_cidade_destino = b.id_cidade ;";

                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

                try
                {

                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                       Viagem novo = new Viagem();

                        novo.Id_viagem = (int)reader["v.Id_viagem"];
                      //  novo.Id_motorista = (int)reader["Id_motorista"];
                        //novo.Id_veiculo = (int)reader["Id_veiculo"];
                        pesquisarTodasViagens.Add(novo);


                    }

                    conn.Close();
                    return pesquisarTodasViagens;
                }
                finally
                {
                    conn.Close();
                }
            

            /*
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            PesquisarTbx.Text = "";

            MySqlDataAdapter pesq1 = new MySqlDataAdapter("SELECT " +
            "v.id_viagem as Codigo_Viagem," +
            "m.nome_motorista as Nome_Motorista, " +
            "a.modelo_veiculo as Modelo_Veiculo, " +
            "c.nome_cidade as Cidade_Saida, " +
            "b.nome_cidade as Cidade_Destino, " +
            "date(v.dta_saida) as Data_Saida, " +
            "v.km_cidade_origem as Km_saida, " +
            "v.passageiro_viagem as Passageiro, " +
            "v.km_cidade_retorno as Km_retorno " +
            "FROM viagem v " +
            "JOIN cadastro_motorista m " +
            "JOIN cadastro_veiculo a " +
            "JOIN cadastro_cidade c " +
            "JOIN cadastro_cidade b " +
            "ON v.id_motorista = m.id_motorista  " +
            "AND v.id_veiculo = a.id_veiculo " +
            "AND  v.id_cidade_origem = c.id_cidade " +
            "AND  v.id_cidade_destino = b.id_cidade ;", conn);
            DataTable pesq3 = new DataTable();
            pesq1.Fill(pesq3);
            dataGridViewSaiViagem.DataSource = pesq3;
            

        }
        */

    }
}
