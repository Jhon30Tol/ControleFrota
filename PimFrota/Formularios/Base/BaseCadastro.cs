using PimFrota.Formularios.TelaCadastros;
using PimFrota.Formularios.TelaCadastros.CadastroCidade;
using PimFrota.Formularios.TelaCadastros.CadastroCliente;
using PimFrota.Formularios.TelaCadastros.CadastroMotorista;
using PimFrota.Formularios.TelaCadastros.CadastroProduto;
using PimFrota.Formularios.TelaCadastros.CadastroSeguro;
using PimFrota.Formularios.TelaCadastros.CadastroServico;
using PimFrota.Formularios.TelaCadastros.CadastroUsuario;
using PimFrota.Formularios.TelaCadastros.CadastroVeiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFrota.Formularios.Base
{
    public partial class BaseCadastro : Form
    {
        public BaseCadastro()
        {
            InitializeComponent();

            

        }

        public void FechaForm()
        {
            if (iniMotorista != null)
                iniMotorista.Close();

            if (iniUsuario != null)
                iniUsuario.Close();

            if (iniCidade != null)
                iniCidade.Close();

            if (iniVeiculo != null)
                iniVeiculo.Close();

            if (iniCliente != null)
                iniCliente.Close();

            if (iniProduto != null)
                iniProduto.Close();

            if (iniServico != null)
                iniServico.Close();

            if (iniSeguro != null)
                iniSeguro.Close();

        }


        FrmCadIniUsuario iniUsuario;
        FrmCadiniMotorista iniMotorista;
        FrmCadIniCidade iniCidade;
        FrmCadIniVeiculo iniVeiculo;
        FrmCadIniCliente iniCliente;
        FrmCadIniProduto iniProduto;
        FrmCadIniServico iniServico;
        FrmCadIniSeguro iniSeguro;



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniUsuario = new FrmCadIniUsuario();
            iniUsuario.TopLevel = false;
            iniUsuario.AutoScroll = true;
            iniUsuario.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniUsuario);
            iniUsuario.Show();
        }

        private void MotoristaBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniMotorista = new FrmCadiniMotorista();
            iniMotorista.TopLevel = false;
            iniMotorista.AutoScroll = true;
            iniMotorista.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniMotorista);
            iniMotorista.Show();
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniCidade = new FrmCadIniCidade();
            iniCidade.TopLevel = false;
            iniCidade.AutoScroll = true;
            iniCidade.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniCidade);
            iniCidade.Show();
        }

        private void VeiculoBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniVeiculo = new FrmCadIniVeiculo();
            iniVeiculo.TopLevel = false;
            iniVeiculo.AutoScroll = true;
            iniVeiculo.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniVeiculo);
            iniVeiculo.Show();
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniCliente = new FrmCadIniCliente();
            iniCliente.TopLevel = false;
            iniCliente.AutoScroll = true;
            iniCliente.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniCliente);
            iniCliente.Show();
        }

        private void ProdutoBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniProduto = new FrmCadIniProduto();
            iniProduto.TopLevel = false;
            iniProduto.AutoScroll = true;
            iniProduto.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniProduto);
            iniProduto.Show();
        }

        private void ServicoBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniServico = new FrmCadIniServico();
            iniServico.TopLevel = false;
            iniServico.AutoScroll = true;
            iniServico.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniServico);
            iniServico.Show();
        }

        private void SeguroBtn_Click(object sender, EventArgs e)
        {
            FechaForm();
            iniSeguro = new FrmCadIniSeguro();
            iniSeguro.TopLevel = false;
            iniSeguro.AutoScroll = true;
            iniSeguro.FormBorderStyle = FormBorderStyle.None;
            this.BaseCadastroPnl.Controls.Add(iniSeguro);
            iniSeguro.Show();
        }

        private void BaseCadastroPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaseCadastroMenuFecharPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
