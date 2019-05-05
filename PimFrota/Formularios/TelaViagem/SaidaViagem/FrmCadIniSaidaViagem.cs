//using PimFrota.Formularios.TelaViagem.SaidaViagem;
using MySql.Data.MySqlClient;
using PimFrota.Formularios.TelaCadastros.CadastroMotorista;
using PimServices.Model;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem

{

    public partial class FrmCadIniSaidaViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        Viagem v = new Viagem();
        bool modoEdit = false;
        DaoViagem daoViagem = new DaoViagem();
        bool pesqCidade = false;

        public FrmCadIniSaidaViagem()
        {
            InitializeComponent();
            motoristaPesquisarPnl.Visible = false;
            veiculoPesquisarPnl.Visible = false;
            cidadePesquisarPnl.Visible = false;
            saidaViagemPesquisaPnl.Visible = false;


        }

        private void IncluirViagemBtn_Click(object sender, EventArgs e)
        {

            saidaViagemPnl.Visible = true;

        }

        private void CancelarViagemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniSaidaViagem_Load(object sender, EventArgs e)
        {

        }

        private void GravarViagemBtn_Click(object sender, EventArgs e)
        {

            DaoViagem dao = new DaoViagem();
            v.DtaSaida = Convert.ToDateTime(DtaSaidaDtm.Text);
            v.KmSaida = Convert.ToInt32(KmSaidaTbx.Text);
            v.passageiro = passageiroTbx.Text;

            dao.SalvarViagem(v);

        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {

            motoristaPesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;

        }

        private void saidaViagemPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            v.Id_motorista = Convert.ToInt32(dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString());
            MotoristaSaidaViagTbx.Text = dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString();

            motoristaPesquisarPnl.Visible = false;
            saidaViagemPnl.Visible = true;

            MessageBox.Show(Convert.ToString(v.Id_motorista), "");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

            MySqlDataAdapter pesq1 = new MySqlDataAdapter("select id_motorista, nome_motorista, cpf_motorista, dta_vencimento_cnh_motorista from cadastro_motorista where nome_motorista like '%" + @nome + "%'", conn);
            DataTable pesq3 = new DataTable();
            pesq1.Fill(pesq3);
            dataGridViewMotorista.DataSource = pesq3;

        }

        private void NomeCkbx_CheckedChanged(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            PesquisarTbx.Text = "";

            PesquisarTbx.Enabled = false;
            MySqlDataAdapter pesq = new MySqlDataAdapter("select id_motorista, nome_motorista, cpf_motorista, dta_vencimento_cnh_motorista from cadastro_motorista ", conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            DataTable pesq1 = new DataTable();
            pesq.Fill(pesq1);
            dataGridViewMotorista.DataSource = pesq1;
        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {
            veiculoPesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
        }

        private void dataGridViewVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            v.Id_veiculo = Convert.ToInt32(dataGridViewVeiculo.CurrentRow.Cells[0].Value.ToString());
            VeiculoSaidaViagTbx.Text = dataGridViewVeiculo.CurrentRow.Cells[1].Value.ToString();

            veiculoPesquisarPnl.Visible = false;
            saidaViagemPnl.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

            MySqlDataAdapter pesq1 = new MySqlDataAdapter("select id_veiculo, modelo_veiculo,marca_veiculo, cor_veiculo, ano_modelo, placa_veiculo from cadastro_veiculo where modelo_veiculo like '%" + @nome + "%'", conn);
            DataTable pesq3 = new DataTable();
            pesq1.Fill(pesq3);
            dataGridViewVeiculo.DataSource = pesq3;
        }

        private void TodosVeiculosCkbx_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            PesquisarTbx.Text = "";

            PesquisarTbx.Enabled = false;
            MySqlDataAdapter pesq = new MySqlDataAdapter("select id_veiculo, modelo_veiculo,marca_veiculo, cor_veiculo, ano_modelo, placa_veiculo from cadastro_veiculo", conn);
            DataTable pesq1 = new DataTable();
            pesq.Fill(pesq1);
            dataGridViewVeiculo.DataSource = pesq1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

            MySqlDataAdapter pesq11 = new MySqlDataAdapter("select  id_cidade, nome_cidade, uf_estado FROM cadastro_cidade where nome_cidade like '%" + @nome + "%'", conn);
            DataTable pesq3 = new DataTable();
            pesq11.Fill(pesq3);
            dataGridViewCidade.DataSource = pesq3;

        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (pesqCidade == true)
            {

                v.Id_cidadeSaida = Convert.ToInt32(dataGridViewCidade.CurrentRow.Cells[0].Value.ToString());
                CidadeSaidaViagTbx.Text = dataGridViewCidade.CurrentRow.Cells[1].Value.ToString();

                cidadePesquisarPnl.Visible = false;
                saidaViagemPnl.Visible = true;

            }
            else
            {
                v.Id_cidadeDestino = Convert.ToInt32(dataGridViewCidade.CurrentRow.Cells[0].Value.ToString());
                CidadeDestSaidaViagTbx.Text = dataGridViewCidade.CurrentRow.Cells[1].Value.ToString();

                cidadePesquisarPnl.Visible = false;
                saidaViagemPnl.Visible = true;


            }

            pesqCidade = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesqCidade = true;
            cidadePesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cidadePesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
        }

        private void KmSaidaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void PesquisarViagemBtn_Click(object sender, EventArgs e)
        {
            saidaViagemPesquisaPnl.Visible = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = pesquisaSaidaViagemTbx.Text;
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
                dataGridViewSaiViagem.DataSource = pesq3;

            }
            else if (pesqMotoristaCbx.Checked == true)
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
                dataGridViewSaiViagem.DataSource = pesq3;
            }
            else if (pesqVeiculoCbx.Checked == true)
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
                dataGridViewSaiViagem.DataSource = pesq3;
            }
        }

        private void pesquTodosCkbx_CheckedChanged(object sender, EventArgs e)
        {

            if (pesquTodosCkbx.Checked == true)
            {

            pesqMotoristaCbx.Enabled = false;
            pesqVeiculoCbx.Enabled = false;
            pesquisaSaidaViagemTbx.Enabled = false;
            PesquisarBtn.Enabled = false;
            pesquisaSaidaViagemTbx.Text = "";


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
            dataGridViewSaiViagem.DataSource = pesq3;
            }
            if (pesquTodosCkbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesqVeiculoCbx.Enabled = true;
                pesquisaSaidaViagemTbx.Enabled = true;
                PesquisarBtn.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
                

            }
        }
            

private void pesqMotoristaCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqMotoristaCbx.Checked == true)
            {
                pesqVeiculoCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }
            if (pesqMotoristaCbx.Checked == false)
            {
                pesqVeiculoCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
            }
        }

        private void pesqVeiculoCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqVeiculoCbx.Checked == true)
            {
                pesqMotoristaCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }

            if (pesqVeiculoCbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
            }
        }

        private void dataGridViewRetViagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[0].Value.ToString();
            MotoristaSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[1].Value.ToString();
            VeiculoSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[2].Value.ToString();
            CidadeSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[3].Value.ToString();
            CidadeDestSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[4].Value.ToString();
            DtaSaidaDtm.Text = dataGridViewSaiViagem.CurrentRow.Cells[5].Value.ToString();
            v.Id_viagem = Convert.ToInt32(CodSaidaViagTbx.Text);

            saidaViagemPesquisaPnl.Visible = false;
        }
    }
}
 