using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroServico
{
    public partial class FrmCadIniServico : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniServico()
        {
            InitializeComponent();
        }

        private void IncluirServicoBtn_Click(object sender, EventArgs e)
        {
            FrmCadServico novo_servico = new FrmCadServico();
            novo_servico.TopLevel = false;
            novo_servico.AutoScroll = true;
            novo_servico.FormBorderStyle = FormBorderStyle.None;
            this.CadServicoIniPnl.Controls.Add(novo_servico);
            novo_servico.Show();
        }

        private void CancelarServicoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IncluirServicoBtn_Click_1(object sender, EventArgs e)
        {
            FrmCadServico novo_servico = new FrmCadServico();
            novo_servico.TopLevel = false;
            novo_servico.AutoScroll = true;
            novo_servico.FormBorderStyle = FormBorderStyle.None;
            this.CadServicoIniPnl.Controls.Add(novo_servico);
            novo_servico.Show();
        }

        private void CancelarServicoBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarServicoBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisarServico pesquisa_servico = new FrmPesquisarServico();
            pesquisa_servico.TopLevel = false;
            pesquisa_servico.AutoScroll = true;
            pesquisa_servico.FormBorderStyle = FormBorderStyle.None;
            this.CadServicoIniPnl.Controls.Add(pesquisa_servico);
            pesquisa_servico.Show();
        }
    }
}
