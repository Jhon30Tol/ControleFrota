using Correios.Net;
using PimFrota.Formularios.Mensagens;
using PimServices.Model;
using PimServices.RepositorySql.PimServices.RepositorySql;
using System;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
    {
    public partial class FrmCadiniMotorista : PimFrota.Formularios.Base.FrmBaseFundoCad
        {
        Motorista m = new Motorista();
        DaoMotorista daoMotorista = new DaoMotorista();
        

        public FrmCadiniMotorista()
            {
            InitializeComponent();
            }

        private void FrmCadiniMotorista_Load(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = false;
            }

        private void IncluirMotoristaBtn_Click(object sender, EventArgs e)
            {

            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = true;

            }



        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;
            }

        

        private void CepMotoristaTbx_TextChanged(object sender, EventArgs e)
            {

            }


        private void validarTxb_Click(object sender, EventArgs e)
            {

            }

        private void pesquisarCepTbx_Click(object sender, EventArgs e)
            {
            LocalizarCEP();

            }
        public void salvarMotorista(Motorista m)
            {
            m.nome = NomeMotoristaTbx.Text;
            m.cpf = CpfMotoristaTbx.Text;
            m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text);
            m.cnh = cnhMotoristaTbx.Text;
            m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text);
            m.telefoneFixo = Convert.ToInt32(telefoneMotoristaTbx.Text);
            m.celular = Convert.ToInt32(celularMotoristaTbx.Text);
            LocalizarCEP();
            FrmMensagemCadSucesso sucesso = new FrmMensagemCadSucesso();
            sucesso.Show();

            }
        private void LocalizarCEP()
            {

            if (daoMotorista.buscaCep(m)) {

                m.Cep = Convert.ToInt32(CepMotoristaTbx.Text);
                m.rua = RuaMotoristaTbx.Text;
                m.numero = Convert.ToInt32(NumeroRuaMotoristaTbx.Text);
                m.Cidade = cidadeMotoristaTbx.Text;
                m.Uf = ufMotoristaTbx.Text;
                limparDados();
                
                }
            else
                {
                MessageBox.Show("CEP Invalido !");
               
                }

            }
        public void limparDados()
            {
            NomeMotoristaTbx.Clear();
            CpfMotoristaTbx.Clear();
            DtNascimentoMotoristaTbx.Clear();
            cnhMotoristaTbx.Clear();
            DtVencCnhTbx.Clear();
            telefoneMotoristaTbx.Clear();
            celularMotoristaTbx.Clear();
            celularMotoristaTbx.Clear();
            RuaMotoristaTbx.Clear();
            NumeroRuaMotoristaTbx.Clear();
            cidadeMotoristaTbx.Clear();
            ufMotoristaTbx.Clear();
            CepMotoristaTbx.Clear();m

            }
        public void editarMotorista()
            {
            FrmCadiniMotorista frmCadiniMotorista = new FrmCadiniMotorista();


            }

        private void GravarMotoristaBtn_Click(object sender, EventArgs e)
            {
            salvarMotorista(m);
            }

        private void EditarMotoristaBtn_Click(object sender, EventArgs e)
            {
            
            }

        private void PesquisarBtn_Click(object sender, EventArgs e)
            {

            }
        }
    }


