using MySql.Data.MySqlClient;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    public partial class FrmPesquisaUsuario : PimFrota.Formularios.Base.FrmBaseFundoCad


    {
        public FrmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void PesquisarLbl_Click(object sender, EventArgs e)
        {

        }

        public void PesquisarBtn_Click(object sender, EventArgs e)
        {
            
            string nome = PesquisarTbx.Text;
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

             if (AtivoCkbx.Checked == true)
            {
                
                MySqlDataAdapter pesqAtivo = new MySqlDataAdapter("select id_usuario, nome_usuario, ativo from cadastro_usuario where ativo = 's' and nome_usuario like '%" + @nome + "%'", conn);
                DataTable pesq2 = new DataTable();
                pesqAtivo.Fill(pesq2);
                dataGridViewUsuario.DataSource = pesq2;
            }
            else
            {
                MySqlDataAdapter pesqAtivo = new MySqlDataAdapter("select id_usuario, nome_usuario, ativo from cadastro_usuario where ativo = 'n' and nome_usuario like '%" + @nome + "%'", conn);
                DataTable pesq3 = new DataTable();
                pesqAtivo.Fill(pesq3);
                dataGridViewUsuario.DataSource = pesq3;
            }



        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            AtivoCkbx.Checked = true;
        }

        private void TodosCkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosCkbx.Checked == true)
            {

                string nome = PesquisarTbx.Text;
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                AtivoCkbx.Enabled = false;
                PesquisarTbx.Text = "";

                PesquisarTbx.Enabled = false;
                MySqlDataAdapter pesq = new MySqlDataAdapter("select id_usuario, nome_usuario, ativo from cadastro_usuario ", conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                DataTable pesq1 = new DataTable();
                pesq.Fill(pesq1);
                dataGridViewUsuario.DataSource = pesq1;
            }
            else
            {
                PesquisarTbx.Text = "";
                PesquisarTbx.Enabled = true;
                AtivoCkbx.Enabled = true;

            }

        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadusuario frmusuform = new FrmCadusuario();
            frmusuform.NomeUsuarioTbx.Text =  dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            frmusuform.AtivoCbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            frmusuform.SenhaUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];

            
        this.Hide();
        frmusuform.Show();
            frmusuform.NomeUsuarioTbx.Enabled = false;
            frmusuform.AtivoCbx.Enabled = false;
            frmusuform.SenhaUsuarioTbx.Enabled = false;
            FrmCadIniUsuario frmusuiniform = new FrmCadIniUsuario();
            frmusuiniform.CancelarUsuBtn.Enabled = true;
            //frmusuform.Show();



        }

        private void AtivoCkbx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
