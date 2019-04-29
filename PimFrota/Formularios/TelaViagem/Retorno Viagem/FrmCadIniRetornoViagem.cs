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
            CadRetornoViagem novo_retorno = new CadRetornoViagem();
            novo_retorno.TopLevel = false;
            novo_retorno.AutoScroll = true;
            novo_retorno.FormBorderStyle = FormBorderStyle.None;
            this.CadRetornoIniPnl.Controls.Add(novo_retorno);
            novo_retorno.Show();
        }

        private void CancelarRetornoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
