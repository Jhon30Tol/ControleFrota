using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleFrota.Formulários
{
    public partial class FrmTelainicial : ControleFrota.Formulários.FrmBase
    {
        public FrmTelainicial()
        {
            InitializeComponent();
        }

        private void FrmTelainicial_Load(object sender, EventArgs e)
        {
            //Criação de função para apresentar um pop-up com uma descrição quando o mouse é posicionado em um elemento.
            ToolTip toolTip1 = new ToolTip();

            //Configurar os atrasos para o ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            //Forçar o texto de dica de ferramenta a ser exibido ou não o formulário está ativo.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.CadastroBtn, "Cadastros");
            toolTip1.SetToolTip(this.FinanceiroBtn, "Financeiro");
            toolTip1.SetToolTip(this.EstoqueBtn, "Estoque");
            toolTip1.SetToolTip(this.ViagemBtn, "Viagens");
            toolTip1.SetToolTip(this.AvisoBtn, "Avisos");

        }

        private void CadastroBtn_Click(object sender, EventArgs e)
        {

        }

        private void FinanceiroBtn_Click(object sender, EventArgs e)
        {

        }

        private void AvisoBtn_Click(object sender, EventArgs e)
        {

        }

        private void ViagemBtn_Click(object sender, EventArgs e)
        {

        }

        private void EstoqueBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
