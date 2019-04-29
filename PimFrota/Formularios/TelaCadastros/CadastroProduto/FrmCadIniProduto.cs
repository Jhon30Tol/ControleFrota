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
            FrmCadProduto novo_produto = new FrmCadProduto();
            novo_produto.TopLevel = false;
            novo_produto.AutoScroll = true;
            novo_produto.FormBorderStyle = FormBorderStyle.None;
            this.CadProdutoIniPnl.Controls.Add(novo_produto);
            novo_produto.Show();
        }

        private void CancelarProdutoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarProdutoBtn_Click(object sender, EventArgs e)
        {
            FrmPesquisaProduto pesquisar_produto = new FrmPesquisaProduto();
            pesquisar_produto.TopLevel = false;
            pesquisar_produto.AutoScroll = true;
            pesquisar_produto.FormBorderStyle = FormBorderStyle.None;
            this.CadProdutoIniPnl.Controls.Add(pesquisar_produto);
            pesquisar_produto.Show();
        }
    }
}
