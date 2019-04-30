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
            motoristaPnl.Visible = true;
            motoristaPesquisarPnl.Visible = false;
        }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {
            motoristaPnl.Visible = false;
            motoristaPesquisarPnl.Visible = true;
        }

        private void FrmCadIniMotorista_Load(object sender, EventArgs e)
        {
            motoristaPnl.Visible = false;
            motoristaPesquisarPnl.Visible = false;
        }
    }
}
