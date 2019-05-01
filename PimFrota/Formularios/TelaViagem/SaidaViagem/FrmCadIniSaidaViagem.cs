//using PimFrota.Formularios.TelaViagem.SaidaViagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem
{
    public partial class FrmCadIniSaidaViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniSaidaViagem()
        {
            InitializeComponent();
        }

        private void IncluirViagemBtn_Click(object sender, EventArgs e)
        {
            
            saidaViagemPnl.Visible = true;

        }

        private void CancelarViagemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniSaidaViagem_Load(object sender, EventArgs e)
        {

        }
    }
}
