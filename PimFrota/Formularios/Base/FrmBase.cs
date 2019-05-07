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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            usuarioLogadoLbl.Text = "Wagner Neves";
        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void versaoLbl_Click(object sender, EventArgs e)
        {

        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
