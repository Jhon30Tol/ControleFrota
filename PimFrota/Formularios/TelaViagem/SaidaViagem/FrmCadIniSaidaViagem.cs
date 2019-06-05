//using PimFrota.Formularios.TelaViagem.SaidaViagem;
using MySql.Data.MySqlClient;
using PimFrota.Formularios.Mensagens;
using PimFrota.Formularios.TelaCadastros.CadastroMotorista;
using PimServices.Model;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem

{

    public partial class FrmCadIniSaidaViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        Viagem v = new Viagem();
        Cidade c = new Cidade();
        Motorista m = new Motorista();
        Veiculo veiculo = new Veiculo();
        bool modoEdit = false;
        DaoViagem daoViagem = new DaoViagem();
        bool pesqCidade = false;

        public void iniarIncluir()
        {
            CodSaidaViagTbx.Enabled = false;
            MotoristaSaidaViagTbx.Enabled = false;
            VeiculoSaidaViagTbx.Enabled = false;
            CidadeSaidaViagTbx.Enabled = false;
            CidadeDestSaidaViagTbx.Enabled = false;
            DtaSaidaDtm.Enabled = false;
            DtaRetornoDtm.Enabled = false;
            KmSaidaTbx.Enabled = false;
            passageiroTbx.Enabled = false;
            kmRetornoTbx.Enabled = false;

            PesquisarMotoristaBtn.Enabled = false;
            PesquisarBtn.Enabled = false;
            pesquisaCidadeSaidaBtn.Enabled = false;
            pesquisaCidadeDestinoBtn.Enabled = false;

            EditarViagemBtn.Enabled = false;
            ExcluirViagemBtn.Enabled = false;
            GravarViagemBtn.Enabled = false;


        }


        public void PosGravar()
        {

            CadViagemIniPnl.Visible = false;
            CadViagemIniPnl.Visible = false;

            IniciaForm();




        }

        public void IniciaForm()
        {
            motoristaPesquisarPnl.Visible = false;
            veiculoPesquisarPnl.Visible = false;
            cidadePesquisarPnl.Visible = false;
            saidaViagemPesquisaPnl.Visible = false;
            msgNaoRetornouLbl.Visible = false;
            KmRodadoLbl.Visible = false;
            valKmRodadoLbl.Visible = false;

        }

        public FrmCadIniSaidaViagem()
        {
            InitializeComponent();
            CadViagemIniPnl.Visible = false;

            IniciaForm();

            iniarIncluir();




        }

        private void IncluirViagemBtn_Click(object sender, EventArgs e)
        {

            CadViagemIniPnl.Visible = true;
            saidaViagemPesquisaPnl.Visible = false;
            GravarViagemBtn.Enabled = true;


            MotoristaSaidaViagTbx.Text = "<-- Clique para incluir o motorista";
            VeiculoSaidaViagTbx.Text = "<-- Clique para incluir o veiculo";
            CidadeSaidaViagTbx.Text = "<-- Clique para incluir a cidade de saida";
            CidadeDestSaidaViagTbx.Text = "<-- Clique para incluir a cidade de destino";

            DtRetornoLbl.Visible = false;
            DtaRetornoDtm.Visible = false;

            KmRetornoLbl.Visible = false;
            kmRetornoTbx.Visible = false;

            saidaViagemPnl.Visible = true;


            CodSaidaViagTbx.Enabled = false;
            MotoristaSaidaViagTbx.Enabled = false;
            VeiculoSaidaViagTbx.Enabled = false;
            CidadeSaidaViagTbx.Enabled = false;
            CidadeDestSaidaViagTbx.Enabled = false;
            DtaSaidaDtm.Enabled = true;
            DtaRetornoDtm.Enabled = false;
            KmSaidaTbx.Enabled = true;
            passageiroTbx.Enabled = true;
            kmRetornoTbx.Enabled = false;

            PesquisarMotoristaBtn.Enabled = true;
            PesquisarBtn.Enabled = true;
            pesquisaCidadeSaidaBtn.Enabled = true;
            pesquisaCidadeDestinoBtn.Enabled = true;

        }

        private void CancelarViagemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniSaidaViagem_Load(object sender, EventArgs e)
        {
        }

        private void GravarViagemBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso frmMsgSucesso = (FrmMensagemCadSucesso)Application.OpenForms["FrmMensagemCadSucesso"];
            FrmMensagemCadSucesso frmMsgSucessomsg = new FrmMensagemCadSucesso();





            if (MotoristaSaidaViagTbx.Text == "<-- Clique para incluir o motorista") 
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Motorista é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.MotoristaSaidaViagTbx.Focus();

            }

            else if (VeiculoSaidaViagTbx.Text == "<-- Clique para incluir o veeiculo")    
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Veiculo é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.VeiculoSaidaViagTbx.Focus();


            }

            else if (CidadeSaidaViagTbx.Text == "<-- Clique para incluir a cidade de saida")
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cidade de Saida é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.CidadeSaidaViagTbx.Focus();


            }

            else if (CidadeDestSaidaViagTbx.Text == "<-- Clique para incluir a cidade de destino")
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Cidade de Destino é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.CidadeDestSaidaViagTbx.Focus();


            }

            else if (String.IsNullOrEmpty(KmSaidaTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Km Saida é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.kmRetornoTbx.Focus();
            }

            else if (!Regex.IsMatch(KmSaidaTbx.Text, @"^[0-9]+$"))
             {
                 frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Km deve conter somente Numeros";
                 frmMsgCampoObrigatorioMsg.ShowDialog();
                 this.kmRetornoTbx.Focus();

            }


           else if
                      (modoEdit == false)
                {
                    DaoViagem dao = new DaoViagem();
                    v.DtaSaida = Convert.ToDateTime(DtaSaidaDtm.Text);
                    v.KmSaida = Convert.ToInt32(KmSaidaTbx.Text);
                    v.passageiro = passageiroTbx.Text;

                    dao.SalvarViagem(v);


                    frmMsgSucessomsg.MensagemSucessoLbl.Text = "Viagem Salva com Sucesso !";
                    frmMsgSucessomsg.ShowDialog();

                BotaoViagemPnl.Visible = false;



                    CodSaidaViagTbx.Text = " ";
                    MotoristaSaidaViagTbx.Text = " ";
                    VeiculoSaidaViagTbx.Text = " ";
                    CidadeSaidaViagTbx.Text = " ";
                    CidadeDestSaidaViagTbx.Text = " ";
                    DtaSaidaDtm.Text.Trim();
                    KmSaidaTbx.Text = " ";
                    passageiroTbx.Text = " ";

                    PosGravar();
                }
                else
                {
                    DaoViagem dao = new DaoViagem();

                    v.KmSaida = Convert.ToInt32(KmSaidaTbx.Text);
                    v.passageiro = passageiroTbx.Text;
                    v.DtaRetorno = Convert.ToDateTime(DtaRetornoDtm.Text);
                    v.DtaSaida = Convert.ToDateTime(DtaSaidaDtm.Text);
                    v.KmRetorno = Convert.ToInt32(kmRetornoTbx.Text);

                    dao.EditarViagem(v);
                    frmMsgSucessomsg.MensagemSucessoLbl.Text = "Viagem Editada com Sucesso !";
                    frmMsgSucessomsg.ShowDialog();
                    BotaoViagemPnl.Visible = false;


                PosGravar();

                }

            

        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {
            
            motoristaPesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;

        }

        private void saidaViagemPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MotoristaSaidaViagTbx.Text = dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString();
            v.Id_motorista = Convert.ToInt32(dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString());

            motoristaPesquisarPnl.Visible = false;
            saidaViagemPnl.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = PesquisarMotoristaTbx.Text;

            if (PesquisaNomeMotoristaCkbx.Checked == true)
            {

                DaoViagem daoViagem = new DaoViagem();
                dataGridViewMotorista.DataSource = daoViagem.PesquisarNomeMotoristas(nome);
                PesquisaTodosMotoristasCkb.Enabled = false;
            }
            else if (PesquisaNomeMotoristaCkbx.Checked == false)
            {
                PesquisaTodosMotoristasCkb.Enabled = true;
                PesquisarMotoristaTbx.Text = "";

            }

        }

        private void NomeCkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (PesquisaNomeMotoristaCkbx.Checked == true)
            {
         
                PesquisaTodosMotoristasCkb.Enabled = false;
            }
            else if (PesquisaNomeMotoristaCkbx.Checked == false)
            {
                PesquisaTodosMotoristasCkb.Enabled = true;
                PesquisarMotoristaTbx.Text = "";

            }

        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {
            
            veiculoPesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
        }

        private void dataGridViewVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VeiculoSaidaViagTbx.Text = dataGridViewVeiculo.CurrentRow.Cells[0].Value.ToString();
            v.Id_veiculo = Convert.ToInt32(dataGridViewVeiculo.CurrentRow.Cells[1].Value.ToString());

            veiculoPesquisarPnl.Visible = false;
            saidaViagemPnl.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome = pesquisarVeiculoTbx.Text;
            
            if (ModeloVeiculoCkb.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewVeiculo.DataSource = daoViagem.PesquisarModeloVeiculos(nome);
                TodosVeiculosCkbx.Enabled = false;

            }
            else if (ModeloVeiculoCkb.Checked == false)
            {
                TodosVeiculosCkbx.Enabled = true;
                pesquisarVeiculoTbx.Text = "";

            }
        }

        private void TodosVeiculosCkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosVeiculosCkbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewVeiculo.DataSource = daoViagem.PesquisarTodosVeiculos(veiculo);
                ModeloVeiculoCkb.Enabled = false;
                pesquisaVeiculoBtn.Enabled = false;
                pesquisarVeiculoTbx.Enabled = false;
                pesquisarVeiculoTbx.Text = "";
            }
            else if (TodosVeiculosCkbx.Checked == false)
            {
                ModeloVeiculoCkb.Enabled = true;
                pesquisaVeiculoBtn.Enabled = true;
                pesquisarVeiculoTbx.Enabled = true;
                pesquisarVeiculoTbx.Text = "";
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string nome = pesquisaCidadeTbx.Text;

            if (CidadeCkbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewCidade.DataSource = daoViagem.PesquisarCidadeDestino(nome);
                TodasCidadesCbx.Enabled = false;

            }
            else if (CidadeCkbx.Checked == false)
            {
                TodasCidadesCbx.Enabled = true;

            }
        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (pesqCidade == true)
            {
                CidadeSaidaViagTbx.Text = dataGridViewCidade.CurrentRow.Cells[0].Value.ToString();
                v.Id_cidadeSaida = Convert.ToInt32(dataGridViewCidade.CurrentRow.Cells[2].Value.ToString());

                cidadePesquisarPnl.Visible = false;
                saidaViagemPnl.Visible = true;

            }
            else
            {
                CidadeDestSaidaViagTbx.Text = dataGridViewCidade.CurrentRow.Cells[0].Value.ToString();
                v.Id_cidadeDestino = Convert.ToInt32(dataGridViewCidade.CurrentRow.Cells[2].Value.ToString());

                cidadePesquisarPnl.Visible = false;
                saidaViagemPnl.Visible = true;


            }

            pesqCidade = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pesqCidade = true;
            cidadePesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
            saidaViagemPesquisaPnl.Location = new Point(3, 7);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cidadePesquisarPnl.Visible = true;
            saidaViagemPnl.Visible = false;
        }

        private void KmSaidaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void PesquisarViagemBtn_Click(object sender, EventArgs e)
        {
            
            DtaRetornoDtm.Visible = true;
            GravarViagemBtn.Enabled = false;
            CadViagemIniPnl.Visible = true;

            saidaViagemPesquisaPnl.Visible = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nome = pesquisaSaidaViagemTbx.Text;


            if (pesqMotoristaCbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewSaiViagem.DataSource = daoViagem.PesquisarMotoristaViagens(nome);

            }
            else if (pesqVeiculoCbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewSaiViagem.DataSource = daoViagem.PesquisarVeiculoViagens(nome);
            }

        }

        private void pesquTodosCkbx_CheckedChanged(object sender, EventArgs e)
        {

            if (pesquTodosCkbx.Checked == true)
            {

            pesqMotoristaCbx.Enabled = false;
            pesqVeiculoCbx.Enabled = false;
            pesquisaSaidaViagemTbx.Enabled = false;
            PesquisarBtn.Enabled = false;
            pesquisaSaidaViagemTbx.Text = "";

                DaoViagem daoViagem = new DaoViagem();
                dataGridViewSaiViagem.DataSource = daoViagem.PesquisarTodasViagens(v);

                
            }
            if (pesquTodosCkbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesqVeiculoCbx.Enabled = true;
                pesquisaSaidaViagemTbx.Enabled = true;
                PesquisarBtn.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
                

            }
        }
            

private void pesqMotoristaCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqMotoristaCbx.Checked == true)
            {
                pesqVeiculoCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
                string nome = PesquisarMotoristaTbx.Text;

            }
            if (pesqMotoristaCbx.Checked == false)
            {
                pesqVeiculoCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
            }
        }

        private void pesqVeiculoCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqVeiculoCbx.Checked == true)
            {
                pesqMotoristaCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }

            if (pesqVeiculoCbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewSaiViagem.DataSource = null;
                pesquisaSaidaViagemTbx.Text = "";
            }
        }

        private void dataGridViewRetViagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DaoViagem dao = new DaoViagem();

            CodSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[1].Value.ToString();
            MotoristaSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[0].Value.ToString();
            VeiculoSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[2].Value.ToString();
            CidadeSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[3].Value.ToString();
            CidadeDestSaidaViagTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[4].Value.ToString();
            DtaSaidaDtm.Text = dataGridViewSaiViagem.CurrentRow.Cells[5].Value.ToString();
            KmSaidaTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[6].Value.ToString();
            DtaRetornoDtm.Text = dataGridViewSaiViagem.CurrentRow.Cells[7].Value.ToString();
            kmRetornoTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[8].Value.ToString();
            passageiroTbx.Text = dataGridViewSaiViagem.CurrentRow.Cells[9].Value.ToString();

            v.Id_viagem = Convert.ToInt32(dataGridViewSaiViagem.CurrentRow.Cells[1].Value.ToString());
            v.Id_motorista = Convert.ToInt32(dataGridViewSaiViagem.CurrentRow.Cells[10].Value.ToString());
            v.Id_veiculo = Convert.ToInt32(dataGridViewSaiViagem.CurrentRow.Cells[11].Value.ToString());
            v.Id_cidadeSaida = Convert.ToInt32(dataGridViewSaiViagem.CurrentRow.Cells[12].Value.ToString());
            v.Id_cidadeDestino = Convert.ToInt32(dataGridViewSaiViagem.CurrentRow.Cells[13].Value.ToString());

            int KmSaidaCalc = Convert.ToInt32(KmSaidaTbx.Text);
            int KmRetornoCalc = Convert.ToInt32(kmRetornoTbx.Text);

          


            if (DtaRetornoDtm.Text == "01/01/2000")
            {
                DtaRetornoDtm.Visible = false;
                KmRetornoLbl.Visible = false;
                DtRetornoLbl.Visible = false;
                kmRetornoTbx.Visible = false;
                msgNaoRetornouLbl.Visible = true;
                KmRodadoLbl.Visible = false;
                valKmRodadoLbl.Visible = false;
            }
            else if (DtaRetornoDtm.Text != "01/01/2000")
            {
                msgNaoRetornouLbl.Visible = false;
                DtaRetornoDtm.Visible = true;
                KmRetornoLbl.Visible = true;
                DtRetornoLbl.Visible = true;
                kmRetornoTbx.Visible = true;
                valKmRodadoLbl.Text = Convert.ToString(KmRetornoCalc - KmSaidaCalc);
                KmRodadoLbl.Visible = true;
                valKmRodadoLbl.Visible = true;
            }



            v.Id_viagem = Convert.ToInt32(CodSaidaViagTbx.Text);

            IncluirViagemBtn.Enabled = false;
            ExcluirViagemBtn.Enabled = true;
            


            saidaViagemPesquisaPnl.Visible = false;
            EditarViagemBtn.Enabled = true;
        }

        private void saidaViagemPesquisaPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CadViagemIniPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void veiculoPesquisarPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            saidaViagemPesquisaPnl.Location = new Point(0, 0);
        }

        private void EditarViagemBtn_Click(object sender, EventArgs e)
        {
            modoEdit = true;
            MotoristaSaidaViagTbx.Enabled = false;
            VeiculoSaidaViagTbx.Enabled = false;
            CidadeSaidaViagTbx.Enabled = false;
            CidadeDestSaidaViagTbx.Enabled = false;
            DtaSaidaDtm.Enabled = true;
            DtaRetornoDtm.Enabled = true;
            KmSaidaTbx.Enabled = true;
            passageiroTbx.Enabled = true;
            kmRetornoTbx.Enabled = true;

            PesquisarMotoristaBtn.Enabled = true;
            PesquisarBtn.Enabled = true;
            pesquisaCidadeSaidaBtn.Enabled = true;
            pesquisaCidadeDestinoBtn.Enabled = true;

            EditarViagemBtn.Enabled = false;
            ExcluirViagemBtn.Enabled = false;
            GravarViagemBtn.Enabled = true;

        }

        private void ExcluirViagemBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCadSucesso frmMsgSucesso = (FrmMensagemCadSucesso)Application.OpenForms["FrmMensagemCadSucesso"];
            FrmMensagemCadSucesso frmMsgSucessomsg = new FrmMensagemCadSucesso();

            FrmMsgSimNao frmMsgExcluirv = (FrmMsgSimNao)Application.OpenForms["FrmSairSistema"];
            FrmMsgSimNao frmMsgExcluir = new FrmMsgSimNao();

            frmMsgExcluir.msgSairSistemaLbl.Text = "Deseja mesmo Excluir esta viagem ?";
            frmMsgExcluir.ShowDialog();

            if (frmMsgExcluir.btnSairClick == true)
            {
                DaoViagem dao = new DaoViagem();
                dao.ExcluirViagem(v);
                frmMsgSucessomsg.MensagemSucessoLbl.Text = "Viagem Excluida com Sucesso !";
                frmMsgSucessomsg.ShowDialog();
                PosGravar();
                BotaoViagemPnl.Visible = false;



            }

            
        }

        private void CidadeCkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (CidadeCkbx.Checked == true)
            {
                
                TodasCidadesCbx.Enabled = false;

            }
            else if (CidadeCkbx.Checked == false)
            {
                TodasCidadesCbx.Enabled = true;
                pesquisaCidadeTbx.Text = "";

            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TodasCidadesCbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewCidade.DataSource = daoViagem.PesquisarTodosDestino(c);
                CidadeCkbx.Enabled = false;
                pesquisaCidadeBtn.Enabled = false;
                pesquisaCidadeTbx.Enabled = false;
                pesquisaCidadeTbx.Text = "";

            }

            else if (TodasCidadesCbx.Checked == false)
            {
                CidadeCkbx.Enabled = true;
                pesquisaCidadeBtn.Enabled = true;
                pesquisaCidadeTbx.Enabled = true;
                pesquisaCidadeTbx.Text = "";


            }
        }

        private void PesquisaTodosMotoristasCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (PesquisaTodosMotoristasCkb.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewMotorista.DataSource = daoViagem.PesquisarTodosMotoristas(m);
                PesquisaNomeMotoristaCkbx.Enabled = false;
                pesquisaMotoristaBtn.Enabled = false;
                PesquisarMotoristaTbx.Enabled = false;
            }
            else if (PesquisaTodosMotoristasCkb.Checked == false)
            {
                PesquisaNomeMotoristaCkbx.Enabled = true;
                pesquisaMotoristaBtn.Enabled = true;
                PesquisarMotoristaTbx.Enabled = true;
                PesquisarMotoristaTbx.Text = "";

            }
        }

        private void ModeloVeiculoCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeloVeiculoCkb.Checked == true)
            {
                TodosVeiculosCkbx.Enabled = false;
            }
            else if (ModeloVeiculoCkb.Checked == false)
            {
                TodosVeiculosCkbx.Enabled = true;
                pesquisarVeiculoTbx.Text = "";

            }
        }
    }
}
 