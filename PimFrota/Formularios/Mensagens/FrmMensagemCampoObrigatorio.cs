using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.Mensagens
{
    public partial class FrmMensagemCampoObrigatorio : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmMensagemCampoObrigatorio()
        {
            InitializeComponent();
        }

        private void MensagemOkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
