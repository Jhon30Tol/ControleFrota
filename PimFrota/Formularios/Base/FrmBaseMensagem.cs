using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFrota.Formularios.Base
{
    public partial class FrmBaseMensagem : Form
    {
        public FrmBaseMensagem()
        {
            InitializeComponent();
            CnhGbx.Visible = false;
            AbastecimentoGpx.Visible = true;
            RodizioGpx.Visible = false;

        }
   
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();
            frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Sua CNH vencerá em 30 dias";
            frmMsgCampoObrigatorioMsg.ShowDialog();
            this.CnhGbx.Focus();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();
            frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Favor pegar requisição";
            frmMsgCampoObrigatorioMsg.ShowDialog();
            this.AbastecimentoGpx.Focus();


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();
            frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Placa final 3, Viagem de sexta (24/05/2019)";
            frmMsgCampoObrigatorioMsg.ShowDialog();
            this.RodizioGpx.Focus();
        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
