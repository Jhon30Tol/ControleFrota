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

        private void FinanceiroBtn_Click(object sender, EventArgs e)
        {
            FrmBaseFinanceiro financeiro = new FrmBaseFinanceiro();
            financeiro.ShowDialog();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void EstoqueBtn_Click(object sender, EventArgs e)
        {
            FrmBaseEstoque baseEstoque = new FrmBaseEstoque();
            baseEstoque.ShowDialog();
        }

        private void AvisoBtn_Click(object sender, EventArgs e)
        {
            FrmBaseMensagem baseMensagem = new FrmBaseMensagem();
            baseMensagem.ShowDialog();
        }

        private void usuarioLogadoLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
