using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroCliente
{
    public partial class FrmCadIniCliente : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniCliente()
        {
            InitializeComponent();
            EditarClienteBtn.Enabled = false;
            ExcluirClienteBtn.Enabled = false;
            PesquisarBtn.Enabled = true;
            GravarClienteBtn.Enabled = false;
        }

        private void IncluirClienteBtn_Click(object sender, EventArgs e)
        {
            ClientePesquisarPnl.Visible = false;
            ClientePnl.Visible = true;
            EditarClienteBtn.Enabled = false;
            ExcluirClienteBtn.Enabled = false;
            PesquisarBtn.Enabled = false;
            CodClienteTbx.Enabled = false;
            GravarClienteBtn.Enabled = true;

        }

        private void CancelarClienteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarClienteBtn_Click(object sender, EventArgs e)
        {
            ClientePnl.Visible = false;
            ClientePesquisarPnl.Visible = true;
        }

        private void FrmCadIniCliente_Load(object sender, EventArgs e)
        {
            ClientePesquisarPnl.Visible = false;
            ClientePnl.Visible = false;
        }

        private void GravarClienteBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();





            if (String.IsNullOrEmpty(NomeClienteTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeClienteTbx.Focus();
            }


            else if (String.IsNullOrEmpty(CpfClienteTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cpf é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.CpfClienteTbx.Focus();
            }

            else if (String.IsNullOrEmpty(DtaNascClienteDtm.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Data Nascimento é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.DtaNascClienteDtm.Focus();
            }
            else if (!Regex.IsMatch(CpfClienteTbx.Text, @"^[0-9]+$"))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cpf deve conter somente Numeros";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.CpfClienteTbx.Focus();

            }
            else  
            {
                msgCadastroSucesso.ShowDialog();
                CadClienteIniPnl.Visible = false;
                BotaoCadastroPnl.Refresh();

            }



        }
    }
}
