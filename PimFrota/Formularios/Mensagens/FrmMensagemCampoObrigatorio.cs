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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CentralizaLabel()
        {
            int x = (panel1.Size.Width - MensagemCampoObrigatorioLbl.Width) / 2;
            int y = (panel1.Size.Height - MensagemCampoObrigatorioLbl.Height) / 2;

            MensagemCampoObrigatorioLbl.Location = new Point(x, y);
        }

        private void MensagemCampoObrigatorioLbl_Resize(object sender, EventArgs e)
        {
            CentralizaLabel();
        }
    }
}
