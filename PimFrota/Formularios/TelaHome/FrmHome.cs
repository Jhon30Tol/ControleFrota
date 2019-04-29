using PimFrota.Formularios.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaHome
{
    public partial class FrmHome : PimFrota.Formularios.Base.FrmBase
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void CadastroBtn_Click(object sender, EventArgs e)
        {
            BaseCadastro cadastro = new BaseCadastro();
            cadastro.ShowDialog();
        }

        private void ViagemBtn_Click(object sender, EventArgs e)
        {
            FrmBaseViagem viagem = new FrmBaseViagem();
            viagem.ShowDialog();
        }
    }
}
