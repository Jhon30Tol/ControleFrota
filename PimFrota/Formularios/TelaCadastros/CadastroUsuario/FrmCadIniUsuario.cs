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
            IncluirUsuBtn.Enabled = false;

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void GravarUsuBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(CodUsuarioTbx.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(AtivoCbx.Text))
                MessageBox.Show("Campo ativo obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(NomeUsuarioTbx.Text))
                MessageBox.Show("Campo login obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(SenhaUsuarioTbx.Text))
                MessageBox.Show("Campo senha obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            { 

                if
                  (modoEdit == false)
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
            }
            
        }

        private void PesquisarUsuBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaUsuario pesquisa_usuario = new FrmPesquisaUsuario();

            dataGridViewUsuario.DataSource = null;
            dataGridViewUsuario.Columns.Clear();
            dataGridViewUsuario.Rows.Clear();
            dataGridViewUsuario.Refresh();
            PesquisarTbx.Enabled = true;

            usuarioPnl.Visible = false;
            usuarioPesquisaPnl.Visible = true;
            CancelarUsuBtn.Enabled = true;
            GravarUsuBtn.Enabled = false;

        

        }

        private void FrmCadIniUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void CadUsuIniPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {
            /*
             string nome = PesquisarTbx.Text;
             MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
             MySqlCommand cmd = new MySqlCommand();
             conn.Open();

              */


            dataGridViewUsuario.DataSource = daoUsuario.BuscarTodosUsuarios(u);

            /*
            

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
            */
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void dataGridViewUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
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
            u.Id = Convert.ToInt32(CodUsuarioTbx.Text);

            usuarioPesquisaPnl.Visible = false;
            usuarioPnl.Visible = true;
            NomeUsuarioTbx.Enabled = false;
            AtivoCbx.Enabled = false;
            SenhaUsuarioTbx.Enabled = false;
            CancelarUsuBtn.Enabled = true;
            EditarUsuBtn.Enabled = true;
            ExcluirUsuBtn.Enabled = true;
            IncluirUsuBtn.Enabled = false;

        }

        private void ExcluirUsuBtn_Click(object sender, EventArgs e)
        {
            FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
            Usuario u = new Usuario();
            DaoUsuario dao = new DaoUsuario();

            u.Id = Convert.ToInt32(CodUsuarioTbx.Text);
 
            dao.ExcluirUsuario(u);
            usuarioPnl.Visible = false;
        }

        private void AtivoCkbx_CheckedChanged(object sender, EventArgs e)
        {

        }

       private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

   
    }
    
}
