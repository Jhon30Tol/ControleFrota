using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFrota.Formularios.Mensagens
{
    public partial class FrmMsgSimNao : Form
    {
        public bool btnSairClick = false;

        public FrmMsgSimNao()
        {
            InitializeComponent();
        }

        private void SimSairSistemaBtn_Click(object sender, EventArgs e)
        {
            btnSairClick = true;
            this.Close();


        }

        private void NaoSairSistemaBtn_Click(object sender, EventArgs e)
        {
            btnSairClick = false;
            this.Close();

        }

        private void NaoSairSistemaBtn_Resize(object sender, EventArgs e)
        {

        }

        public void CentralizaLabel()
        {
            int x = (msgSairSistemaLbl.Size.Width - msgSairSistemaLbl.Width) / 2;
            int y = (msgSairSistemaLbl.Size.Height - msgSairSistemaLbl.Height) / 2;

            msgSairSistemaLbl.Location = new Point(x, y);
        }

        private void msgSairSistemaLbl_Resize(object sender, EventArgs e)
        {
            //CentralizaLabel();

        }
    }
}
