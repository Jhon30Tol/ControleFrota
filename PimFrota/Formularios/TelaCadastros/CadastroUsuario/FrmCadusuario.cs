using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    public partial class FrmCadusuario : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadusuario()
        {
            InitializeComponent();
            AtivoCbx.SelectedIndex = 0;
        }

        private void AtivoCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
