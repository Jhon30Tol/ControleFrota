using Correios.Net;
using PimServices.Model;
using PimServices.RepositorySql.PimServices.RepositorySql;
using System;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
    {
    public partial class FrmCadiniMotorista : PimFrota.Formularios.Base.FrmBaseFundoCad
        {
        Motorista m = new Motorista();

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

            SalvarMotorista();

            }



        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;
            }

        private void LocalizarCEP()
            {
            Address endereco = new Address();

            if (!string.IsNullOrWhiteSpace(CepMotoristaTbx.Text))
                {

                endereco = SearchZip.GetAddress(CepMotoristaTbx.Text);


                if (endereco != null)
                    {

                    RuaMotoristaTbx.Text = endereco.Street;
                    BairroMotoristaTbx.Text = endereco.District;


                    }
                else
                    {
                    MessageBox.Show("Cep não localizado !");
                    RuaMotoristaTbx.Clear();
                    BairroMotoristaTbx.Clear();

                    }
                }
            else
                {
                MessageBox.Show("Por favor, informe um CEP válido");
                }
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
        public void SalvarMotorista()
            {
            DaoMotorista motorista = new DaoMotorista();


            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = true;


            m.nome = NomeMotoristaTbx.Text;
            m.cpf = CpfMotoristaTbx.Text;
            m.cnh = cnhMotoristaTbx.Text;
            m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text);
            m.telefoneFixo = Convert.ToInt32(telefoneMotoristaTbx.Text);
            m.celular = Convert.ToInt32(celularMotoristaTbx.Text);
            LocalizarCEP();
            m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text);

            }
        }
    }


