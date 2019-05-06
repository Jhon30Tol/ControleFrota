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

                MessageBox.Show(Convert.ToString(v.DtaSaida), "");



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

    }
}
