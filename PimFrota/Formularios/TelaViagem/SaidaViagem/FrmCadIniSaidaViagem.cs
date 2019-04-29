using PimFrota.Formularios.TelaViagem.SaidaViagem;
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
            CadSaidaViagem nova_saida = new CadSaidaViagem();
            nova_saida.TopLevel = false;
            nova_saida.AutoScroll = true;
            nova_saida.FormBorderStyle = FormBorderStyle.None;
            this.CadViagemIniPnl.Controls.Add(nova_saida);
            nova_saida.Show();
        }

        private void CancelarViagemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
