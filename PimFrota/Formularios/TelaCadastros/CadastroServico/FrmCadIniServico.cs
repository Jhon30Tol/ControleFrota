using PimFrota.Formularios.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroServico
{
    public partial class FrmCadIniServico : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniServico()
        {
            InitializeComponent();
            CodServicoTxb.Enabled = false;

            EditarServicoBtn.Enabled = false;
            ExcluirServicoBtn.Enabled = false;
            GravarServicoBtn.Enabled = false;
            IncluirServicoBtn.Enabled = true;
            PesquisarServicoBtn.Enabled = true;


        }

        private void IncluirServicoBtn_Click(object sender, EventArgs e)
        {
            /*FrmCadServico novo_servico = new FrmCadServico();
            novo_servico.TopLevel = false;
            novo_servico.AutoScroll = true;
            novo_servico.FormBorderStyle = FormBorderStyle.None;
            this.CadServicoIniPnl.Controls.Add(novo_servico);
            novo_servico.Show();
            */
        }

        private void CancelarServicoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IncluirServicoBtn_Click_1(object sender, EventArgs e)
        {
            servicoPesquisarPnl.Visible = false;
            servicoPnl.Visible = true;

            EditarServicoBtn.Enabled = false;
            ExcluirServicoBtn.Enabled = false;
            GravarServicoBtn.Enabled = true;
            IncluirServicoBtn.Enabled = false;
            PesquisarServicoBtn.Enabled = false;


        }

        private void CancelarServicoBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarServicoBtn_Click(object sender, EventArgs e)
        {
            servicoPesquisarPnl.Visible = true;
            servicoPnl.Visible = false;
        }

        private void FrmCadIniServico_Load(object sender, EventArgs e)
        {
            servicoPesquisarPnl.Visible = false;
            servicoPnl.Visible = false;
        }

        private void GravarServicoBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

            if (String.IsNullOrEmpty(CodVeiculoServicoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Veiculo é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.CodVeiculoServicoTbx.Focus();
            }


            else if (String.IsNullOrEmpty(NomeServicoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Servico é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.NomeServicoTbx.Focus();
            }
            else if (String.IsNullOrEmpty(ValorServicoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Valor é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.ValorServicoTbx.Focus();
            }
            else if (!Regex.IsMatch(ValorServicoTbx.Text, @"^[0-9]+$"))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Valor deve conter somente Numeros";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.ValorServicoTbx.Focus();

            }
            else if (String.IsNullOrEmpty(DescServicoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Descricao é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.DescServicoTbx.Focus();
            }
            
            else
            {
                msgCadastroSucesso.ShowDialog();
                CadServicoIniPnl.Visible = false;

                EditarServicoBtn.Enabled = false;
                ExcluirServicoBtn.Enabled = false;
                GravarServicoBtn.Enabled = false;
                IncluirServicoBtn.Enabled = true;
                PesquisarServicoBtn.Enabled = true;

            }
        }
    }
}
