using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
{
    public partial class FrmCadiniMotorista : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadiniMotorista()
        {
            InitializeComponent();
        }

        private void FrmCadiniMotorista_Load(object sender, EventArgs e)
        {
            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = false;
        }

        private void IncluirMotoristaBtn_Click(object sender, EventArgs e)
        {
            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = true;
        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {
            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;
        }
    }
    }
    

