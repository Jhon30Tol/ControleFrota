using PimFrota.Formularios.TelaFinanceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.Base
{
    public partial class FrmBaseFinanceiro : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmBaseFinanceiro()
        {
            InitializeComponent();
        }

        public void FecharFormFinanceiro()
        {
            if (financeiro != null)
                financeiro.Close();
        }
        FrmFinanceiro financeiro;

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NovaVendaBtn_Click(object sender, EventArgs e)
        {
            FecharFormFinanceiro();
            financeiro = new FrmFinanceiro();
            financeiro.TopLevel = false;
            financeiro.AutoScroll = true;
            financeiro.FormBorderStyle = FormBorderStyle.None;
            this.BaseFinPnl.Controls.Add(financeiro);
            financeiro.Show();
        }
    }
}
