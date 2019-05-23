using MySql.Data.MySqlClient;
using PimFrota.Formularios.Mensagens;
using PimServices.Model;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaViagem.Retorno_Viagem
{
    public partial class FrmCadIniRetornoViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        Viagem v = new Viagem();
        int kmSaidaValidar;


        public FrmCadIniRetornoViagem()
        {
            InitializeComponent();
            retViagemPesquisaPnl.Visible = false;
            IncluirRetornoBtn.Visible = false;

        }

        private void IncluirRetornoBtn_Click(object sender, EventArgs e)
        {
            
            BotaoRetornoPnl.Visible = true;
        }

        private void CancelarRetornoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadIniRetornoViagem_Load(object sender, EventArgs e)
        {
            CodSaidaViagRTbx.Enabled = false;
            MotoristaSaidaViagRTbx.Enabled = false;
            VeiculoSaidaViagRTbx.Enabled = false;
            CidadeSaidaViagRTbx.Enabled = false;
            CidadeDestSaidaViagRTbx.Enabled = false;
            DtSaidaViagRTbx.Enabled = false;
            kmSaidaTbx.Enabled = false;

            GravarRetornoBtn.Enabled = false;
            EditarRetornoBtn.Visible = false;
            ExcluirRetornoBtn.Visible = false;
            informativoIniciarPesquisaLbl.Visible = true;
            retornoViagemPnl.Visible = false;
            retViagemPesquisaPnl.Visible = false;

        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {
            string nome = PesquisarTbx.Text;
            



            if (pesquTodosCkbx.Checked == true)
            {

                DaoViagem daoViagem = new DaoViagem();
                dataGridViewRetViagem.DataSource = daoViagem.PesquisarTodasRetorno(v);

            }
            else if(pesqMotoristaCbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewRetViagem.DataSource = daoViagem.PesquisarMotoristaRetorno(nome);
            }
            else if(pesqVeiculoCbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewRetViagem.DataSource = daoViagem.PesquisarVeiculoRetorno(nome);
            }


        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MotoristaSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[0].Value.ToString();
            CodSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[1].Value.ToString();
            VeiculoSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[2].Value.ToString();
            CidadeSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[3].Value.ToString();
            CidadeDestSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[4].Value.ToString();
            DtSaidaViagRTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[5].Value.ToString();
            kmSaidaValidar = Convert.ToInt32(dataGridViewRetViagem.CurrentRow.Cells[6].Value.ToString());
            kmSaidaTbx.Text = dataGridViewRetViagem.CurrentRow.Cells[6].Value.ToString();




            CodSaidaViagRTbx.Enabled = false;
            MotoristaSaidaViagRTbx.Enabled = false;
            VeiculoSaidaViagRTbx.Enabled = false;
            CidadeSaidaViagRTbx.Enabled = false;
            CidadeDestSaidaViagRTbx.Enabled = false;
            DtSaidaViagRTbx.Enabled = false;
            GravarRetornoBtn.Enabled = true;

            retViagemPesquisaPnl.Visible = false;
            retornoViagemPnl.Visible = true;





        }

        private void PesquisarRetornoBtn_Click(object sender, EventArgs e)
        {
            retornoViagemPnl.Visible = false;
            retViagemPesquisaPnl.Visible = true;
            informativoIniciarPesquisaLbl.Visible = false;

        }

        private void GravarRetornoBtn_Click(object sender, EventArgs e)
        {
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            FrmMensagemCadSucesso frmMsgSucesso = (FrmMensagemCadSucesso)Application.OpenForms["FrmMensagemCadSucesso"];
            FrmMensagemCadSucesso frmMsgSucessomsg = new FrmMensagemCadSucesso();


             if (String.IsNullOrEmpty(kmRetornoTbx.Text))
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Km Retorno é obrigatorio";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                this.kmRetornoTbx.Focus();
            }



            else 
            {

                int kmRetorno = Convert.ToInt32(kmRetornoTbx.Text);


                if (kmRetorno < kmSaidaValidar)
                {
                    frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Campo Km Retorno deve ser maior que Km de saida";
                    frmMsgCampoObrigatorioMsg.ShowDialog();
                    this.kmRetornoTbx.Focus();
                }
                else
                {
                    DaoViagem dao = new DaoViagem();
                    v.DtaRetorno = Convert.ToDateTime(DtaRetornoDtm.Text);
                    v.KmRetorno = Convert.ToInt32(kmRetornoTbx.Text);
                    v.Id_viagem = Convert.ToInt32(CodSaidaViagRTbx.Text);

                    dao.GravarRetornoViagem(v);
                    CadRetornoIniPnl.Visible = false;
                    CancelarRetornoBtn.Visible = false;
                    PesquisarRetornoBtn.Visible = false;
                    GravarRetornoBtn.Visible = false;


                    frmMsgSucessomsg.MensagemSucessoLbl.Text = "Percorrido  " + Convert.ToString(kmRetorno - kmSaidaValidar) + "  Km";
                    frmMsgSucessomsg.ShowDialog();

                    frmMsgSucessomsg.MensagemSucessoLbl.Text = "Retorno Efetuado com Sucesso !";
                    frmMsgSucessomsg.ShowDialog();
                }
            }



            
        }

        private void TodosCkbx_CheckedChanged(object sender, EventArgs e)
        {

            if (pesquTodosCkbx.Checked == true)
            {
                DaoViagem daoViagem = new DaoViagem();
                dataGridViewRetViagem.DataSource = daoViagem.PesquisarTodasRetorno(v);

                pesqMotoristaCbx.Enabled = false;
                pesqVeiculoCbx.Enabled = false;
                PesquisarTbx.Enabled = false;
                PesquisarBtn.Enabled = false;
                PesquisarTbx.Text = "";


              
            }
            if (pesquTodosCkbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesqVeiculoCbx.Enabled = true;
                PesquisarTbx.Enabled = true;
                PesquisarBtn.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";

            }


        }

        private void retornoViagemPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesqMotoristaCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pesqMotoristaCbx.Checked == true)
            {
                pesqVeiculoCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }
            if(pesqMotoristaCbx.Checked == false)
            {
                pesqVeiculoCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";
            }

        }

        private void pesqVeiculoCbx_CheckedChanged(object sender, EventArgs e)
        {
            if(pesqVeiculoCbx.Checked == true)
            {
                pesqMotoristaCbx.Enabled = false;
                pesquTodosCkbx.Enabled = false;
            }

            if (pesqVeiculoCbx.Checked == false)
            {
                pesqMotoristaCbx.Enabled = true;
                pesquTodosCkbx.Enabled = true;
                dataGridViewRetViagem.DataSource = null;
                PesquisarTbx.Text = "";
            }
        }

        private void EditarRetornoBtn_Click(object sender, EventArgs e)
            {

            }
        }
}
