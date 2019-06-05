using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PimFrota.Formularios.Mensagens;
using PimServices.Model;
using PimServices.RepositorySql;

namespace PimFrota.Formularios.TelaCadastros.CadastroVeiculo
{
    public partial class FrmCadIniVeiculo : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        Veiculo veiculo = new Veiculo();
        bool modoEdit = false;

        public FrmCadIniVeiculo()
        {
            InitializeComponent();

            EditarVeiculoBtn.Enabled = false;
            ExcluirVeiculoBtn.Enabled = false;
            GravarVeiculoBtn.Enabled = false;
            IncluirVeiculoBtn.Enabled = true;
            PesquisarVeiculoBtn.Enabled = true;
        }

        public void modoGravar()
        {
            GravarVeiculoBtn.Enabled = true;
            EditarVeiculoBtn.Enabled = false;
            CancelarVeiculoBtn.Enabled = true;
            ExcluirVeiculoBtn.Enabled = false;
        }

        private void IncluirVeiculoBtn_Click(object sender, EventArgs e)
        {
           

            EditarVeiculoBtn.Enabled = false;
            ExcluirVeiculoBtn.Enabled = false;
            GravarVeiculoBtn.Enabled = true;
            IncluirVeiculoBtn.Enabled = false;
            PesquisarVeiculoBtn.Enabled = false;
            AdicionarVeiculoPnl.Visible = true;

        }

        private void CancelarVeiucloBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarVeiucloBtn_Click(object sender, EventArgs e)
        {
            PesquisarVeiculoPnl.Visible = true;
            AdicionarVeiculoPnl.Visible = false;
        }

        private void FrmCadIniVeiculo_Load(object sender, EventArgs e)
        {
            PesquisarVeiculoPnl.Visible = false;
            AdicionarVeiculoPnl.Visible = false;
        }

        private void GravarVeiculoBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            if (modoEdit == false)
            {
                if (String.IsNullOrEmpty(MarcaVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Marca é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.MarcaVeiculoTbx.Focus();
                }
                else if (String.IsNullOrEmpty(AnoModeloVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Ano/Modelo é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.AnoModeloVeiculoTbx.Focus();
                }
               else if (String.IsNullOrEmpty(ChassiTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Chassi é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.ChassiTbx.Focus();
                }
               else if (String.IsNullOrEmpty(TipCombustivelCbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Combustível é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.TipCombustivelCbx.Focus();
                }
                else if (String.IsNullOrEmpty(ModeloVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Modelo é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.ModeloVeiculoTbx.Focus();
                }
                else if (String.IsNullOrEmpty(AnoVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Ano é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.AnoVeiculoTbx.Focus();
                }
               else if (String.IsNullOrEmpty(CorVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cor é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.CorVeiculoTbx.Focus();
                }
               else if (String.IsNullOrEmpty(PlacaTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Placa é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.PlacaTbx.Focus();
                }
                else
                {
                   
                    switch (TipCombustivelCbx.SelectedIndex)
                    {
                        case 0:
                            veiculo.TipoCombustivel = "Gasolina";
                            break;
                        case 1:
                            veiculo.TipoCombustivel = "Etanol";
                            break;
                        case 2:
                            veiculo.TipoCombustivel = "Gás Natural";
                            break;
                        case 3:
                            veiculo.TipoCombustivel = "Diesel";
                            break;
                        case 4:
                            veiculo.TipoCombustivel = "Flex";
                            break;
                    }
                    veiculo.CorVeiculo = CorVeiculoTbx.Text;

                 
                    FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();
                    msgCadastroSucesso.ShowDialog();
                   

                    AdicionarVeiculoPnl.Visible = false;

                    EditarVeiculoBtn.Enabled = false;
                    ExcluirVeiculoBtn.Enabled = false;
                    GravarVeiculoBtn.Enabled = false;
                    IncluirVeiculoBtn.Enabled = true;
                    PesquisarVeiculoBtn.Enabled = true;

                }
            }
            if (modoEdit == true)
            {
                if (String.IsNullOrEmpty(MarcaVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Marca é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.MarcaVeiculoTbx.Focus();
                }
                if (String.IsNullOrEmpty(AnoModeloVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Ano/Modelo é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.AnoModeloVeiculoTbx.Focus();
                }
                if (String.IsNullOrEmpty(ChassiTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Chassi é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.ChassiTbx.Focus();
                }
                if (String.IsNullOrEmpty(TipCombustivelCbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Combustível é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.TipCombustivelCbx.Focus();
                }
                if (String.IsNullOrEmpty(AnoVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Ano é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.AnoVeiculoTbx.Focus();
                }
                if (String.IsNullOrEmpty(CorVeiculoTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cor é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.CorVeiculoTbx.Focus();
                }
                if (String.IsNullOrEmpty(PlacaTbx.Text))
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Placa é obrigatório";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.PlacaTbx.Focus();
                }
                else
                {
                    veiculo.MarcaVeiculo = MarcaVeiculoTbx.Text;
                    veiculo.ModeloVeiculo = ModeloVeiculoTbx.Text;
                    veiculo.AnoModeloVeiculo = Convert.ToInt32(AnoModeloVeiculoTbx.Text);
                    veiculo.AnoVeiculo = Convert.ToInt32(AnoVeiculoTbx.Text);
                    veiculo.Chassi = ChassiTbx.Text;
                    veiculo.Placa = PlacaTbx.Text;
                    switch (TipCombustivelCbx.SelectedIndex)
                    {
                        case 0:
                            veiculo.TipoCombustivel = "Gasolina";
                            break;
                        case 1:
                            veiculo.TipoCombustivel = "Etanol";
                            break;
                        case 2:
                            veiculo.TipoCombustivel = "Gás Natural";
                            break;
                        case 3:
                            veiculo.TipoCombustivel = "Diesel";
                            break;
                        case 4:
                            veiculo.TipoCombustivel = "Flex";
                            break;
                    }
                    veiculo.CorVeiculo = CorVeiculoTbx.Text;

                    DaoVeiculo daoVeiculo = new DaoVeiculo();
                    daoVeiculo.EditarVeiculo();

                    FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();
                    msgCadastroSucesso.ShowDialog();
                    this.Close();
                }
            }
        }

        private void EditarVeiculoBtn_Click_1(object sender, EventArgs e)
        {
            modoEdit = true;
            AdicionarVeiculoPnl.Visible = true;
            PesquisarVeiculoPnl.Visible = false;

            PesquisaCodVeiculoBtn.Enabled = true;
            CodVeiculoTbx.Enabled = true;
            CodVeiculoTbx.Text = null;

            DesativaCampos();
        }

        private void PesquisaCodVeiculoBtn_Click(object sender, EventArgs e)
        {
            DaoVeiculo pesquisa_veiculo = new DaoVeiculo();
            Veiculo veiculo = new Veiculo();

            if (veiculo.MarcaVeiculo != null)
            {
                AtivaCampos();

                MarcaVeiculoTbx.Text = veiculo.MarcaVeiculo.ToString();
                ModeloVeiculoTbx.Text = veiculo.ModeloVeiculo.ToString();
                AnoModeloVeiculoTbx.Text = veiculo.AnoModeloVeiculo.ToString();
                AnoVeiculoTbx.Text = veiculo.AnoVeiculo.ToString();
                ChassiTbx.Text = veiculo.Chassi.ToString();
                PlacaTbx.Text = veiculo.Placa.ToString();
                TipCombustivelCbx.Text = veiculo.TipoCombustivel.ToString();
                CorVeiculoTbx.Text = veiculo.CorVeiculo.ToString();
            }
        }

        private void AtivaCampos()
        {
            MarcaVeiculoTbx.Enabled = true;
            ModeloVeiculoTbx.Enabled = true;
            AnoModeloVeiculoTbx.Enabled = true;
            AnoVeiculoTbx.Enabled = true;
            ChassiTbx.Enabled = true;
            PlacaTbx.Enabled = true;
            TipCombustivelCbx.Enabled = true;
            CorVeiculoTbx.Enabled = true;

            MarcaVeiculoTbx.Text = null;
            ModeloVeiculoTbx.Text = null;
            AnoModeloVeiculoTbx.Text = null;
            AnoVeiculoTbx.Text = null;
            ChassiTbx.Text = null;
            PlacaTbx.Text = null;
            TipCombustivelCbx.Text = null;
            CorVeiculoTbx.Text = null;
        }

        private void DesativaCampos()
        {
            MarcaVeiculoTbx.Enabled = false;
            ModeloVeiculoTbx.Enabled = false;
            AnoModeloVeiculoTbx.Enabled = false;
            AnoVeiculoTbx.Enabled = false;
            ChassiTbx.Enabled = false;
            PlacaTbx.Enabled = false;
            TipCombustivelCbx.Enabled = false;
            CorVeiculoTbx.Enabled = false;

            MarcaVeiculoTbx.Text = null;
            ModeloVeiculoTbx.Text = null;
            AnoModeloVeiculoTbx.Text = null;
            AnoVeiculoTbx.Text = null;
            ChassiTbx.Text = null;
            PlacaTbx.Text = null;
            TipCombustivelCbx.Text = null;
            CorVeiculoTbx.Text = null;
        }

        private void linhaVeiculoLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
