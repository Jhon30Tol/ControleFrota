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
            seguroPesquisarPnl.Visible = false;
            SeguroPnl.Visible = true;
        }

        private void CancelarSeguroBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarSeguroBtn_Click(object sender, EventArgs e)
        {
            seguroPesquisarPnl.Visible = true;
            SeguroPnl.Visible = false;
        }

        private void FrmCadIniSeguro_Load(object sender, EventArgs e)
        {
            seguroPesquisarPnl.Visible = false;
            SeguroPnl.Visible = false;
        }
    }
}
