using MySql.Data.MySqlClient;
using PimServices.Model;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem.Retorno_Viagem
{
    public partial class FrmCadIniRetornoViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        Viagem v = new Viagem();


        public FrmCadIniRetornoViagem()
        {
            InitializeComponent();
            retViagemPesquisaPnl.Visible = false;
            IncluirRetornoBtn.Visible = false;

        }

        private void IncluirRetornoBtn_Click(object sender, EventArgs e)
        {
            
            BotaoRetornoPnl.Visible = true;
        }

        private void CancelarRetornoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniRetornoViagem_Load(object sender, EventArgs e)
        {
            CodSaidaViagRTbx.Enabled = false;
            MotoristaSaidaViagRTbx.Enabled = false;
            VeiculoSaidaViagRTbx.Enabled = false;
            CidadeSaidaViagRTbx.Enabled = false;
            CidadeDestSaidaViagRTbx.Enabled = false;
            DtSaidaViagRTbx.Enabled = false;

            GravarRetornoBtn.Enabled = false;
            EditarRetornoBtn.Visible = false;
            ExcluirRetornoBtn.Visible = false;

        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();



            if (pesquTodosCkbx.Checked == true)
            {

                MySqlDataAdapter pesq1 = new MySqlDataAdapter("SELECT " +
                    "v.id_viagem as Codigo_Viagem," +
                    "m.nome_motorista as Nome_Motorista, " +
                    "a.modelo_veiculo as Modelo_Veiculo, " +
                    "c.nome_cidade as Cidade_Saida, " +
                    "b.nome_cidade as Cidade_Destino, " +
                    "date(v.dta_saida) as Data_Saida " +
                    "FROM viagem v " +
                    "JOIN cadastro_motorista m " +
                    "JOIN cadastro_veiculo a " +
                    "JOIN cadastro_cidade c " +
                    "JOIN cadastro_cidade b " +
                    "ON v.id_motorista = m.id_motorista  " +
                    "AND v.id_veiculo = a.id_veiculo " +
                    "AND  v.id_cidade_origem = c.id_cidade " +
                    "AND  v.id_cidade_destino = b.id_cidade " +
                    "WHERE v.dta_retorno IS NULL ;", conn);
                DataTable pesq3 = new DataTable();
                pesq1.Fill(pesq3);
                dataGridViewRetViagem.DataSource = pesq3;

            }
            else if(pesqMotoristaCbx.Checked == true)
            {
                MySqlDataAdapter pesq1 = new MySqlDataAdapter("SELECT " +
                   "v.id_viagem as Codigo_Viagem," +
                   "m.nome_motorista as Nome_Motorista, " +
                   "a.modelo_veiculo as Modelo_Veiculo, " +
                   "c.nome_cidade as Cidade_Saida, " +
                   "b.nome_cidade as Cidade_Destino, " +
                   "date(v.dta_saida) as Data_Saida " +
                   "FROM viagem v " +
                   "JOIN cadastro_motorista m " +
                   "JOIN cadastro_veiculo a " +
                   "JOIN cadastro_cidade c " +
                   "JOIN cadastro_cidade b " +
                   "ON v.id_motorista = m.id_motorista  " +
                   "AND v.id_veiculo = a.id_veiculo " +
                   "AND  v.id_cidade_origem = c.id_cidade " +
                   "AND  v.id_cidade_destino = b.id_cidade " +
                   "WHERE v.dta_retorno IS NULL " +
                   "and m.nome_motorista like '%" + @nome + "%'", conn);
                DataTable pesq3 = new DataTable();
                pesq1.Fill(pesq3);
                dataGridViewRetViagem.DataSource = pesq3;
            }
            else if(pesqVeiculoCbx.Checked == true)
            {
                MySqlDataAdapter pesq1 = new MySqlDataAdapter("SELECT " +
                  "v.id_viagem as Codigo_Viagem," +
                  "m.nome_motorista as Nome_Motorista, " +
                  "a.modelo_veiculo as Modelo_Veiculo, " +
                  "c.nome_cidade as Cidade_Saida, " +
                  "b.nome_cidade as Cidade_Destino, " +
                  "date(v.dta_saida) as Data_Saida " +
                  "FROM viagem v " +
                  "JOIN cadastro_motorista m " +
                  "JOIN cadastro_veiculo a " +
                  "JOIN cadastro_cidade c " +
                  "JOIN cadastro_cidade b " +
                  "ON v.id_motorista = m.id_motorista  " +
                  "AND v.id_veiculo = a.id_veiculo " +
                  "AND  v.id_cidade_origem = c.id_cidade " +
                  "AND  v.id_cidade_destino = b.id_cidade " +
                  "WHERE v.dta_retorno IS NULL " +
                  "and a.modelo_veiculo like '%" + @nome + "%'", conn);
                DataTable pesq3 = new DataTable();
                pesq1.Fill(pesq3);
                dataGridViewRetViagem.DataSource = pesq3;
            }


        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CodSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[0].Value.ToString();
            MotoristaSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[1].Value.ToString();
            VeiculoSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[2].Value.ToString();
            CidadeSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[3].Value.ToString();
            CidadeDestSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[4].Value.ToString();
            DtSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[5].Value.ToString();
          //  kmRetornoTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[6].Value.ToString();
            v.Id_viagem = Convert.ToInt32(CodSaidaViagRTbx.Text);


            CodSaidaViagRTbx.Enabled = false;
            MotoristaSaidaViagRTbx.Enabled = false;
            VeiculoSaidaViagRTbx.Enabled = false;
            CidadeSaidaViagRTbx.Enabled = false;
            CidadeDestSaidaViagRTbx.Enabled = false;
            DtSaidaViagRTbx.Enabled = false;
            GravarRetornoBtn.Enabled = true;

            retViagemPesquisaPnl.Visible = false;
            retornoViagemPnl.Visible = true;

        }

        private void PesquisarRetornoBtn_Click(object sender, EventArgs e)
        {
            retornoViagemPnl.Visible = false;
            retViagemPesquisaPnl.Visible = true;

        }

        private void GravarRetornoBtn_Click(object sender, EventArgs e)
        {
            DaoViagem dao = new DaoViagem();
            v.DtaRetorno = Convert.ToDateTime(DtaRetornoDtm.Text);
            v.KmRetorno = Convert.ToInt32(kmRetornoTbx.Text);

            dao.GravarRetornoViagem(v);
            CadRetornoIniPnl.Visible = false;
            CancelarRetornoBtn.Visible = false;
            PesquisarRetornoBtn.Visible = false;
            GravarRetornoBtn.Visible = false;
        }

        private void TodosCkbx_CheckedChanged(object sender, EventArgs e)
        {

            if (pesquTodosCkbx.Checked == true)
            {

                pesqMotoristaCbx.Enabled = false;
                pesqVeiculoCbx.Enabled = false;
                PesquisarTbx.Enabled = false;
                PesquisarBtn.Enabled = false;
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
                    "date(v.dta_saida) as Data_Saida " +
                    "FROM viagem v " +
                    "JOIN cadastro_motorista m " +
                    "JOIN cadastro_veiculo a " +
                    "JOIN cadastro_cidade c " +
                    "JOIN cadastro_cidade b " +
                    "ON v.id_motorista = m.id_motorista  " +
                    "AND v.id_veiculo = a.id_veiculo " +
                    "AND  v.id_cidade_origem = c.id_cidade " +
                    "AND  v.id_cidade_destino = b.id_cidade " +
                    "WHERE v.dta_retorno IS NULL ;", conn);
                DataTable pesq3 = new DataTable();
                pesq1.Fill(pesq3);
                dataGridViewRetViagem.DataSource = pesq3;
            }
            if (pesquTodosCkbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesqVeiculoCbx.Enabled = true;
                PesquisarTbx.Enabled = true;
                PesquisarBtn.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";

            }


        }

        private void retornoViagemPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesqMotoristaCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqMotoristaCbx.Checked == true)
            {
                pesqVeiculoCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }
            if(pesqMotoristaCbx.Checked == false)
            {
                pesqVeiculoCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";
            }

        }

        private void pesqVeiculoCbx_CheckedChanged(object sender, EventArgs e)
        {
            if(pesqVeiculoCbx.Checked == true)
            {
                pesqMotoristaCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }

            if (pesqVeiculoCbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";
            }
        }
    }
}
