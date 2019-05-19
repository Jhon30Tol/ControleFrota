using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.Mensagens
{
    public partial class FrmMensagemErroCadastro : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmMensagemErroCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fecharbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CentralizaLabel()
        {
            int x = (panel1.Size.Width - MEnsagemErroLbl.Width) / 2;
            int y = (panel1.Size.Height - MEnsagemErroLbl.Height) / 2;

            MEnsagemErroLbl.Location = new Point(x, y);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CentralizaLabel();

        }
    }
}
