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
            
        }

        private void IncluirCidadeBtn_Click(object sender, EventArgs e)
        {
           cidadePnl.Visible = true;

        }

        private void CancelarCidadeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarCidadeBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaCidade pesquisar_cidade = new FrmPesquisaCidade();
            pesquisar_cidade.TopLevel = false;
            pesquisar_cidade.AutoScroll = true;
            pesquisar_cidade.FormBorderStyle = FormBorderStyle.None;
            this.CadCidIniPnl.Controls.Add(pesquisar_cidade);
            pesquisar_cidade.Show();
        }

        private void FrmCadIniCidade_Load(object sender, EventArgs e)
        {
            cidadePesquisarPnl.Visible = false;
            cidadePnl.Visible = false;
        }
    }
}
