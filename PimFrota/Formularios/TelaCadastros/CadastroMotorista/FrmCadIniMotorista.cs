using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
{
    public partial class FrmCadIniMotorista : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniMotorista()
        {
            InitializeComponent();
        }

        private void IncluirMotoristaBtn_Click(object sender, EventArgs e)
        {
            FrmCadMotorista novo_motorista = new FrmCadMotorista();
            novo_motorista.TopLevel = false;
            novo_motorista.AutoScroll = true;
            novo_motorista.FormBorderStyle = FormBorderStyle.None;
            this.CadMotoristaIniPnl.Controls.Add(novo_motorista);
            novo_motorista.Show();
        }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaMotorista pesquisar_motorista = new FrmPesquisaMotorista();
            pesquisar_motorista.TopLevel = false;
            pesquisar_motorista.AutoScroll = true;
            pesquisar_motorista.FormBorderStyle = FormBorderStyle.None;
            this.CadMotoristaIniPnl.Controls.Add(pesquisar_motorista);
            pesquisar_motorista.Show();
        }
    }
}
