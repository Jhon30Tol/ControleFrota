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

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
