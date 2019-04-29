using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PimFrota.Formularios.Mensagens;
using PimServices.Model;
using PimServices.RepositorySql;

namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    public partial class FrmCadIniUsuario : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        
        Usuario u = new Usuario();
        bool modoEdit = false;
        DaoUsuario daoUsuario = new DaoUsuario();
        FrmCadusuario novo_usuario = new FrmCadusuario();
        


        public FrmCadIniUsuario()
        {
            InitializeComponent();
            iniciaForm();
            AtivoCkbx.Checked = true;
        }

        public void iniciaForm()
        {
            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = false;
            GravarUsuBtn.Enabled = false;
            EditarUsuBtn.Enabled = false;
            CancelarUsuBtn.Enabled = false;
            ExcluirUsuBtn.Enabled = false;

        }

        public void modoGravar()
        {

            GravarUsuBtn.Enabled = true;
            EditarUsuBtn.Enabled = false;
            CancelarUsuBtn.Enabled = true;
            ExcluirUsuBtn.Enabled = false;
        }


        public void IncluirBtn_Click(object sender, EventArgs e)
        {
            modoGravar();
            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = true;
            
            //novo_usuario.TopLevel = false;
            //novo_usuario.AutoScroll = true;
            //novo_usuario.FormBorderStyle = FormBorderStyle.None;
            //this.CadUsuIniPnl.Controls.Add(novo_usuario);
            //novo_usuario.Show();
            


        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            //FrmCadusuario frmusuform = new FrmCadusuario();
            //frmusuform.Close();
            this.Close();

        }

        private void GravarUsuBtn_Click(object sender, EventArgs e)
        {

            if (modoEdit == false)
            {

                Usuario u = new Usuario();
                DaoUsuario dao = new DaoUsuario();


                FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
                u.Nome = NomeUsuarioTbx.Text;
                u.Senha = SenhaUsuarioTbx.Text;



                switch (AtivoCbx.SelectedIndex)
                {
                    case 0:
                        u.Ativo = "S";
                        break;
                    case 1:
                        u.Ativo = "N";
                        break;
                }
                dao.SalvarUsuario(u);
            }
            else
            {
                FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
                Usuario u = new Usuario();
                DaoUsuario dao = new DaoUsuario();

                u.Id = Convert.ToInt32(CodUsuarioTbx.Text);
                u.Nome = NomeUsuarioTbx.Text;
                u.Senha = SenhaUsuarioTbx.Text;
                u.Ativo = AtivoCbx.Text;
                dao.EditarrUsuario(u);
            }


            
       
            iniciaForm();
           // novo_usuario.Close();
            
        }

        private void PesquisarUsuBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaUsuario pesquisa_usuario = new FrmPesquisaUsuario();
            //pesquisa_usuario.TopLevel = false;
            //pesquisa_usuario.AutoScroll = true;
            //pesquisa_usuario.FormBorderStyle = FormBorderStyle.None;
            //this.CadUsuIniPnl.Controls.Add(pesquisa_usuario);
            usuarioPnl.Visible = false;
            usuarioPesquisaPnl.Visible = true;
            //pesquisa_usuario.Show();
        }

        private void FrmCadIniUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CadUsuIniPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
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

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // FrmCadusuario frmusuform = new FrmCadusuario();
            NomeUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            AtivoCbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            SenhaUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            //FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];


            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = true;
            NomeUsuarioTbx.Enabled = false;
            AtivoCbx.Enabled = false;
            SenhaUsuarioTbx.Enabled = false;
            CancelarUsuBtn.Enabled = true;
           



        }

        private void dataGridViewUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // CodUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            NomeUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            AtivoCbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            SenhaUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();

            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = true;

    
            NomeUsuarioTbx.Enabled = false;
            AtivoCbx.Enabled = false;
            SenhaUsuarioTbx.Enabled = false;
            CancelarUsuBtn.Enabled = true;

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

        private void EditarUsuBtn_Click(object sender, EventArgs e)
        {
            modoEdit = true;
            GravarUsuBtn.Enabled = true;
            NomeUsuarioTbx.Enabled = true;
            SenhaUsuarioTbx.Enabled = true;
            NomeUsuarioTbx.Enabled = true;
            SenhaUsuarioTbx.Enabled = true;
            AtivoCbx.Enabled = true;
        }

        private void dataGridViewUsuario_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            CodUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            NomeUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[1].Value.ToString();
            AtivoCbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            //   SenhaUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            u.Id = Convert.ToInt32(CodUsuarioTbx.Text);
            MessageBox.Show(Convert.ToString(u.Id), "");

            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = true;
            NomeUsuarioTbx.Enabled = false;
            AtivoCbx.Enabled = false;
            SenhaUsuarioTbx.Enabled = false;
            CancelarUsuBtn.Enabled = true;
            EditarUsuBtn.Enabled = true;

        }
    }
    
}
