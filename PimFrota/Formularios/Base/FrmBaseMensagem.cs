using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFrota.Formularios.Base
{
    public partial class FrmBaseMensagem : Form
    {
        public FrmBaseMensagem()
        {
            InitializeComponent();
            CnhGbx.Visible = false;
            AbastecimentoGpx.Visible = false;
            RodizioGpx.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CnhGbx.Visible = true;
            AbastecimentoGpx.Visible = false;
            RodizioGpx.Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbastecimentoGpx.Visible = true;
            CnhGbx.Visible = false;
            RodizioGpx.Visible = false;

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CnhGbx.Visible = false;
            AbastecimentoGpx.Visible = false;
            RodizioGpx.Visible = true;
        }
    }
}
