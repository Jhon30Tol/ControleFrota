using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroProduto
{
    public partial class FrmCadIniProduto : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniProduto()
        {
            InitializeComponent();
            CodProdutoTxb.Enabled = false;

            EditarProdutoBtn.Enabled = false;
            ExcluirProdutoBtn.Enabled = false;
            GravarProdutoBtn.Enabled = false;
            IncluirProdutoBtn.Enabled = true;
            PesquisarProdutoBtn.Enabled = true;
        }

        private void IncluirProdutoBtn_Click(object sender, EventArgs e)
        {
            produtoPnl.Visible = true;
            produtoPesquisarPnl.Visible = false;

            EditarProdutoBtn.Enabled = false;
            ExcluirProdutoBtn.Enabled = false;
            GravarProdutoBtn.Enabled = true;
            IncluirProdutoBtn.Enabled = false;
            PesquisarProdutoBtn.Enabled = false;
        }

        private void CancelarProdutoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarProdutoBtn_Click(object sender, EventArgs e)
        {
            produtoPnl.Visible = false;
            produtoPesquisarPnl.Visible = true;
        }

        private void FrmCadIniProduto_Load(object sender, EventArgs e)
        {
            produtoPnl.Visible = false;
            produtoPesquisarPnl.Visible = false;
        }

        private void GravarProdutoBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

            if (String.IsNullOrEmpty(NomeProdutoTxb.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Nome do Produto é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeProdutoTxb.Focus();
            }


            else if (String.IsNullOrEmpty(MarcaProdTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Marca é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.MarcaProdTbx.Focus();
            }
            else if (String.IsNullOrEmpty(FabricanteProdTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Fabricante é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.FabricanteProdTbx.Focus();
            }
            else if (String.IsNullOrEmpty(ValorProdTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Valor é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.ValorProdTbx.Focus();
            }
            else if (!Regex.IsMatch(ValorProdTbx.Text, @"^[0-9]+$"))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Valor deve conter somente Numeros";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.ValorProdTbx.Focus();

            }
            else
            {
                msgCadastroSucesso.ShowDialog();
                CadProdutoIniPnl.Visible = false;

                EditarProdutoBtn.Enabled = false;
                ExcluirProdutoBtn.Enabled = false;
                GravarProdutoBtn.Enabled = false;
                IncluirProdutoBtn.Enabled = true;
                PesquisarProdutoBtn.Enabled = true;

            }
        }
    }
}
