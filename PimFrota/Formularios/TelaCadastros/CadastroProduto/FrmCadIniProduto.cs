using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroProduto
{
    public partial class FrmCadIniProduto : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniProduto()
        {
            InitializeComponent();
        }

        private void IncluirProdutoBtn_Click(object sender, EventArgs e)
        {
            produtoPnl.Visible = true;
            produtoPesquisarPnl.Visible = false;
        }

        private void CancelarProdutoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarProdutoBtn_Click(object sender, EventArgs e)
        {
            produtoPnl.Visible = false;
            produtoPesquisarPnl.Visible = true;
        }

        private void FrmCadIniProduto_Load(object sender, EventArgs e)
        {
            produtoPnl.Visible = false;
            produtoPesquisarPnl.Visible = false;
        }
    }
}
