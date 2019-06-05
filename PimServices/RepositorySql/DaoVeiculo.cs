using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PimServices.Model;
using PimServices;

namespace PimServices.RepositorySql
{
    public class DaoVeiculo : ConexaoBancoMySQL
    {
        public void SalvarVeiculo(Veiculo veiculo)
        {
            String query = "insert into cadastro_veiculo(marca_veiculo, tipo_combustivel, placa_veiculo, ano_modelo, ano_veiculo, cor_veiculo, chassi_veiculo, modelo_veiculo)" +
                "value(?, ?, ?, ?, ?, ?, ?, ?);";
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.Add(new MySqlParameter("marca_veiculo", veiculo.MarcaVeiculo));
                command.Parameters.Add(new MySqlParameter("tipo_combustivel", veiculo.TipoCombustivel));
                command.Parameters.Add(new MySqlParameter("placa_veiculo", veiculo.Placa));
                command.Parameters.Add(new MySqlParameter("ano_modelo", veiculo.AnoModeloVeiculo));
                command.Parameters.Add(new MySqlParameter("ano_veiculo", veiculo.AnoVeiculo));
                command.Parameters.Add(new MySqlParameter("cor_veiculo", veiculo.CorVeiculo));
                command.Parameters.Add(new MySqlParameter("chassi_veiculo", veiculo.Chassi));
                command.Parameters.Add(new MySqlParameter("modelo_veiculo", veiculo.ModeloVeiculo));
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar veículo,  verifique a conexão com o banco de dados: {ex.ToString()}");
            }
            finally
            {
                if(conn!=null)
                    conn.Close();
            }
        }

        public void EditarVeiculo()
        {

        }

        public void ExcluirVeiculo()
        {

        }

        public void BuscarTodosVeiculos()
        {

        }

        public void BuscarVeiculoPorNome()
        {

        }

        public void BuscarVeiculoPorCodigo(String codigo)
        {
            Veiculo veiculo = new Veiculo();
            
            try
            {
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                conn.Open();

                MySqlCommand objCmd = new MySqlCommand("select marca_veiculo, modelo_veiculo, ano_modelo, ano_veiculo, chassi_veiculo, placa_veiculo, tipo_combustivel,cor_veiculo) from cadastro_veiculo where id_veiculo = ?", conn);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@id_veiculo", MySqlDbType.Int32).Value = codigo;


                objCmd.CommandType = CommandType.Text;
                Console.WriteLine("Executou commandType");
                
                MySqlDataReader dr;
                Console.WriteLine("Criou o dr");



                dr = objCmd.ExecuteReader();
                dr.Read();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar veículo,  verifique a conexão com o banco de dados: {ex.ToString()}");
            }
            finally
            {
                
                if (conn!=null)
                    conn.Close();
            }
            
           
        }
    }
}
