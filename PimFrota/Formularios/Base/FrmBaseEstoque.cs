using PimFrota.Formularios.TelaEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.Base
{
    public partial class FrmBaseEstoque : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmBaseEstoque()
        {
            InitializeComponent();
        }

        public void FechaForm()
        {
            if (estoqueProduto != null)
                estoqueProduto.Close();

            if (estoqueServico != null)
                estoqueServico.Close();
        }
        FrmEstoqueProduto estoqueProduto;
        FrmEstoqueServico estoqueServico;

        private void ProdutoBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            estoqueProduto = new FrmEstoqueProduto();
            estoqueProduto.TopLevel = false;
            estoqueProduto.AutoScroll = true;
            estoqueProduto.FormBorderStyle = FormBorderStyle.None;
            this.BaseEstoquePnl.Controls.Add(estoqueProduto);
            estoqueProduto.Show();
        }

        
        private void Fecharbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServicoBtn_Click_1(object sender, EventArgs e)
        {
            FechaForm();
            estoqueServico = new FrmEstoqueServico();
            estoqueServico.TopLevel = false;
            estoqueServico.AutoScroll = true;
            estoqueServico.FormBorderStyle = FormBorderStyle.None;
            this.BaseEstoquePnl.Controls.Add(estoqueServico);
            estoqueServico.Show();

        }

        private void BaseEstoquePnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
