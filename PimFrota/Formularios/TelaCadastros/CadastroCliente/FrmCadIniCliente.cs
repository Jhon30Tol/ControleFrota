using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroCliente
{
    public partial class FrmCadIniCliente : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniCliente()
        {
            InitializeComponent();
        }

        private void IncluirClienteBtn_Click(object sender, EventArgs e)
        {
            ClientePesquisarPnl.Visible = false;
            ClientePnl.Visible = true;
        }

        private void CancelarClienteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarClienteBtn_Click(object sender, EventArgs e)
        {
            ClientePnl.Visible = false;
            ClientePesquisarPnl.Visible = true;
        }

        private void FrmCadIniCliente_Load(object sender, EventArgs e)
        {
            ClientePesquisarPnl.Visible = false;
            ClientePnl.Visible = false;
        }
    }
}
