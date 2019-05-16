﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
        //FrmCadusuario novo_usuario = new FrmCadusuario();
        


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
            IncluirUsuBtn.Enabled = true;

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
            AtivoCbx.Text = "S";

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void GravarUsuBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();


            if (String.IsNullOrEmpty(AtivoCbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Ativo é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.AtivoCbx.Focus();
            }
                

            else if (String.IsNullOrEmpty(NomeUsuarioTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeUsuarioTbx.Focus();
            }

            else if (String.IsNullOrEmpty(SenhaUsuarioTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Senha é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.SenhaUsuarioTbx.Focus();
            }

            else
            { 

                if
                  (modoEdit == false)
                {
                    Usuario u = new Usuario();
                    DaoUsuario dao = new DaoUsuario();

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


                    FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

                    msgCadastroSucesso.ShowDialog();

                }
                else
                {
                    Usuario u = new Usuario();
                    DaoUsuario dao = new DaoUsuario();

                    u.Id = Convert.ToInt32(CodUsuarioTbx.Text);
                    u.Nome = NomeUsuarioTbx.Text;
                    u.Senha = SenhaUsuarioTbx.Text;
                    u.Ativo = AtivoCbx.Text;
                    dao.EditarrUsuario(u);
                }

               // InitializeComponent();
                iniciaForm();
            }
            
        }

        private void PesquisarUsuBtn_Click(object sender, EventArgs e)
        {

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
            dataGridViewUsuario.DataSource = daoUsuario.BuscarTodosUsuarios(u);
            string nome = PesquisarTbx.Text;
        

            if (AtivoCkbx.Checked == true)
            {
                DaoUsuario daoUsuario = new DaoUsuario();
                dataGridViewUsuario.DataSource = daoUsuario.BuscarPorNomeAtivo(nome);
                
            }
            else
            {
                DaoUsuario daoUsuario = new DaoUsuario();
                dataGridViewUsuario.DataSource = daoUsuario.BuscarPorNomeInativo(nome);
               
            }
            
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

                dataGridViewUsuario.DataSource = daoUsuario.BuscarTodosUsuarios(u);
                AtivoCkbx.Enabled = false;
                PesquisarTbx.Text = "";
                PesquisarTbx.Enabled = false;
 
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
            AtivoCbx.Text = dataGridViewUsuario.CurrentRow.Cells[0].Value.ToString();
            NomeUsuarioTbx.Text = dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            u.Senha =  dataGridViewUsuario.CurrentRow.Cells[2].Value.ToString();
            u.Id = Convert.ToInt32(dataGridViewUsuario.CurrentRow.Cells[3].Value.ToString());


            MessageBox.Show(Convert.ToString(u.Id));


            // u.Id = Convert.ToInt32(CodUsuarioTbx.Text);

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
            //FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
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

        private void NomeUsuarioTbx_Validating(object sender, CancelEventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            if (!Regex.IsMatch(NomeUsuarioTbx.Text, @"^[a-zA-Z]+$"))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome deve conter somente Letras";
                frmMsgCampoObrigatorioMsg.ShowDialog();
            }
            else if (NomeUsuarioTbx.TextLength < 3)
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome deve conter mais que 3 Letras";
                frmMsgCampoObrigatorioMsg.ShowDialog();
            }
        }
    }
    
}
