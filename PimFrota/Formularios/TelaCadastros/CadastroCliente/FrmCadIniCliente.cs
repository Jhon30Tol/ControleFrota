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
            FrmCadCliente novo_cliente = new FrmCadCliente();
            novo_cliente.TopLevel = false;
            novo_cliente.AutoScroll = true;
            novo_cliente.FormBorderStyle = FormBorderStyle.None;
            this.CadClienteIniPnl.Controls.Add(novo_cliente);
            novo_cliente.Show();
        }

        private void CancelarClienteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarClienteBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaCliente pesquisar_cliente = new FrmPesquisaCliente();
            pesquisar_cliente.TopLevel = false;
            pesquisar_cliente.AutoScroll = true;
            pesquisar_cliente.FormBorderStyle = FormBorderStyle.None;
            this.CadClienteIniPnl.Controls.Add(pesquisar_cliente);
            pesquisar_cliente.Show();
        }
    }
}
