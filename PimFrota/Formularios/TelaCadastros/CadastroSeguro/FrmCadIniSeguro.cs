using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroSeguro
{
    public partial class FrmCadIniSeguro : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniSeguro()
        {
            InitializeComponent();
            CodSeguroTbx.Enabled = false;

            EditarSeguroBtn.Enabled = false;
            ExcluirSeguroBtn.Enabled = false;
            GravarSeguroBtn.Enabled = false;
            IncluirSeguroBtn.Enabled = true;
            PesquisarSeguroBtn.Enabled = true;

        }

        private void IncluirSeguroBtn_Click(object sender, EventArgs e)
        {
            seguroPesquisarPnl.Visible = false;
            SeguroPnl.Visible = true;

            EditarSeguroBtn.Enabled = false;
            ExcluirSeguroBtn.Enabled = false;
            GravarSeguroBtn.Enabled = true;
            IncluirSeguroBtn.Enabled = false;
            PesquisarSeguroBtn.Enabled = false;

        }

        private void CancelarSeguroBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarSeguroBtn_Click(object sender, EventArgs e)
        {
            seguroPesquisarPnl.Visible = true;
            SeguroPnl.Visible = false;
        }

        private void FrmCadIniSeguro_Load(object sender, EventArgs e)
        {
            seguroPesquisarPnl.Visible = false;
            SeguroPnl.Visible = false;
        }

        private void GravarSeguroBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

            if (String.IsNullOrEmpty(AsseguradoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Assegurado é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.AsseguradoTbx.Focus();
            }


            else if (String.IsNullOrEmpty(NomeCorretorTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome Corretor é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeCorretorTbx.Focus();
            }          
            else
            {
                msgCadastroSucesso.ShowDialog();
                CadSeguroIniPnl.Visible = false;

                EditarSeguroBtn.Enabled = false;
                ExcluirSeguroBtn.Enabled = false;
                GravarSeguroBtn.Enabled = false;
                IncluirSeguroBtn.Enabled = true;
                PesquisarSeguroBtn.Enabled = true;

            }
        }
    }
}
