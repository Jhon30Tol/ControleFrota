using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroCidade
{
    public partial class FrmCadIniCidade : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        
        public FrmCadIniCidade()
        {
            InitializeComponent();
            EditarCidadeBtn.Enabled = false;
            ExcluirCidadeBtn.Enabled = false;
            GravarCidadeBtn.Enabled = false;
            CodCidadeTbx.Enabled = false;
            
        }

        private void IncluirCidadeBtn_Click(object sender, EventArgs e)
        {
           cidadePnl.Visible = true;
            cidadePesquisarPnl.Visible = false;
            GravarCidadeBtn.Enabled = true;
            IncluirCidadeBtn.Enabled = false;
            EditarCidadeBtn.Enabled = false;
            ExcluirCidadeBtn.Enabled = false;
            PesquisarCidadeBtn.Enabled= false;




        }

        private void CancelarCidadeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarCidadeBtn_Click(object sender, EventArgs e)
        {
            cidadePnl.Visible = false;
            cidadePesquisarPnl.Visible = true;
        }

        private void FrmCadIniCidade_Load(object sender, EventArgs e)
        {
            cidadePesquisarPnl.Visible = false;
            cidadePnl.Visible = false;
        }

        private void GravarCidadeBtn_Click(object sender, EventArgs e)
        {

            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

            if (String.IsNullOrEmpty(NomeCidadeTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeCidadeTbx.Focus();
            }


            else if (String.IsNullOrEmpty(EstadoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Estado é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.EstadoTbx.Focus();
            }
            else
            {
                msgCadastroSucesso.ShowDialog();
                CadCidIniPnl.Visible = false;

                EditarCidadeBtn.Enabled = false;
                ExcluirCidadeBtn.Enabled = false;
                GravarCidadeBtn.Enabled = false;
                IncluirCidadeBtn.Enabled = true;
                PesquisarCidadeBtn.Enabled = true;

            }
        }
    }
}
