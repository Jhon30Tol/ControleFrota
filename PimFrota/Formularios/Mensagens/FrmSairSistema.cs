using PimFrota.Formularios.Base;
using PimFrota.Formularios.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.Mensagens
{
    public partial class FrmSairSistema : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmSairSistema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimSairSistemaBtn_Click(object sender, EventArgs e)
        {
            foreach (FrmLogin  frmLogin in Application.OpenForms)
            {
                if (frmLogin is FrmLogin)
                {
                    frmLogin.Close();
                    break;
                }
            }
            this.Close();

        }
    }
}
