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
        }

        private void IncluirSeguroBtn_Click(object sender, EventArgs e)
        {
            FrmCadSeguro novo_seguro = new FrmCadSeguro();
            novo_seguro.TopLevel = false;
            novo_seguro.AutoScroll = true;
            novo_seguro.FormBorderStyle = FormBorderStyle.None;
            this.CadSeguroIniPnl.Controls.Add(novo_seguro);
            novo_seguro.Show();
        }

        private void CancelarSeguroBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarSeguroBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisarSeguro pesquisar_Seguro = new FrmPesquisarSeguro();
            pesquisar_Seguro.TopLevel = false;
            pesquisar_Seguro.AutoScroll = true;
            pesquisar_Seguro.FormBorderStyle = FormBorderStyle.None;
            this.CadSeguroIniPnl.Controls.Add(pesquisar_Seguro);
            pesquisar_Seguro.Show();
        }
    }
}
