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
            veiculoPesquisarPnl.Visible = false;
            veiculoPnl.Visible = true;
        }

        private void CancelarVeiucloBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarVeiucloBtn_Click(object sender, EventArgs e)
        {
            veiculoPesquisarPnl.Visible = true;
            veiculoPnl.Visible = false;
        }

        private void FrmCadIniVeiculo_Load(object sender, EventArgs e)
        {
            veiculoPesquisarPnl.Visible = false;
            veiculoPnl.Visible = false;
        }
    }
}
