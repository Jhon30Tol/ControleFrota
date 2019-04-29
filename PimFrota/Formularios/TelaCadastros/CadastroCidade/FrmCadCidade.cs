using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroCidade
{
    public partial class FrmCadCidade : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadCidade()
        {
            InitializeComponent();
        }

        private void PlacaLbl_Click(object sender, EventArgs e)
        {

        }

        private void PlacaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeCidadeTbx_Validating(object sender, CancelEventArgs e)
        {
            if (NomeCidadeTbx.Text.Length < 3)
            {
                MessageBox.Show("Nome Inválido");
            }
        }

        private void EstadoTbx_Validating(object sender, CancelEventArgs e)
        {
            if (EstadoTbx.Text.Length < 2)
            {
                MessageBox.Show("Utilize a sigla do Estado");
            }
        }
    }
}
