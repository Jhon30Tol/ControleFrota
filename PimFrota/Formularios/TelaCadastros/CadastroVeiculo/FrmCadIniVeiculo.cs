using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroVeiculo
{
    public partial class FrmCadIniVeiculo : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniVeiculo()
        {
            InitializeComponent();
        }

        private void IncluirVeiucloBtn_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo novo_veiculo = new FrmCadVeiculo();
            novo_veiculo.TopLevel = false;
            novo_veiculo.AutoScroll = true;
            novo_veiculo.FormBorderStyle = FormBorderStyle.None;
            this.CadVeiculoIniPnl.Controls.Add(novo_veiculo);
            novo_veiculo.Show();
        }

        private void CancelarVeiucloBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarVeiucloBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisarVeiculo pesquisa_veiculo = new FrmPesquisarVeiculo();
            pesquisa_veiculo.TopLevel = false;
            pesquisa_veiculo.AutoScroll = true;
            pesquisa_veiculo.FormBorderStyle = FormBorderStyle.None;
            this.CadVeiculoIniPnl.Controls.Add(pesquisa_veiculo);
            pesquisa_veiculo.Show();
        }
    }
}
