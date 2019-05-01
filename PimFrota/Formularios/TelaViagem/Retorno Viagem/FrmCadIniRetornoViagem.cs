using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem.Retorno_Viagem
{
    public partial class FrmCadIniRetornoViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniRetornoViagem()
        {
            InitializeComponent();
        }

        private void IncluirRetornoBtn_Click(object sender, EventArgs e)
        {
            
            BotaoRetornoPnl.Visible = true;
        }

        private void CancelarRetornoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniRetornoViagem_Load(object sender, EventArgs e)
        {

        }
    }
}
