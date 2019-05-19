using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PimServices.Model;
using PimServices.RepositorySql;

namespace PimFrota.Formularios.Mensagens
{
    public partial class FrmMensagemCadSucesso : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmMensagemCadSucesso()
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

        private void MensagemSucessoLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void CentralizaLabel()
        {
            int x = (panel1.Size.Width - MensagemSucessoLbl.Width) / 2;
            int y = (panel1.Size.Height - MensagemSucessoLbl.Height) / 2;

            MensagemSucessoLbl.Location = new Point(x, y);
        }

        private void MensagemSucessoLbl_Resize(object sender, EventArgs e)
        {
            CentralizaLabel();

        }
    }
}
