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
        Endereco endereco = new Endereco();


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
            using (var ws = new WsCorreios.AtendeClienteClient())
                try
                    {
                    var resultado = ws.consultaCEP(CepMotoristaTbx.Text);
                    RuaMotoristaTbx.Text = resultado.end;
                    BairroMotoristaTbx.Text = resultado.bairro;
                    cidadeMotoristaTbx.Text = resultado.cidade;
                    ufMotoristaTbx.Text = resultado.uf;

                    }
                catch (System.Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
        public void salvarMotorista(Motorista m)
            {




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
            CepMotoristaTbx.Clear();

            }
        public void editarMotorista()
            {
            FrmCadiniMotorista frmCadiniMotorista = new FrmCadiniMotorista();


            }

        private void GravarMotoristaBtn_Click(object sender, EventArgs e)
            {

            if (validaCampos())
                {
                m.nome = NomeMotoristaTbx.Text;
                m.cpf = CpfMotoristaTbx.Text;
                m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text);
                m.cnh = cnhMotoristaTbx.Text;
                m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text);
                m.telefoneFixo = Convert.ToInt32(telefoneMotoristaTbx.Text);
                m.celular = Convert.ToInt32(celularMotoristaTbx.Text);

                var ws = new WsCorreios.AtendeClienteClient();
                var resultado = ws.consultaCEP(CepMotoristaTbx.Text);
                RuaMotoristaTbx.Text = resultado.end;
                m.nomeRua = resultado.end;
                BairroMotoristaTbx.Text = resultado.bairro;
                m.bairro = resultado.bairro;
                cidadeMotoristaTbx.Text = resultado.cidade;
                m.Cidade = resultado.cidade;
                ufMotoristaTbx.Text = resultado.uf;
                m.Uf = resultado.uf;

                daoMotorista.SalvarMotorista(m);
                MessageBox.Show("Motorista cadastrado com sucesso!");
                limparDados();
                }
            }


        private bool validaCampos()
            {

            if (NomeMotoristaTbx.Text != "" || CpfMotoristaTbx.Text != "" || DtNascimentoMotoristaTbx.Text != "" ||
               cnhMotoristaTbx.Text != "" || DtVencCnhTbx.Text != "" || telefoneMotoristaTbx.Text != "" ||
               celularMotoristaTbx.Text != "" || CepMotoristaTbx.Text != "" || NomeMotoristaTbx.Text != "" || BairroMotoristaTbx.Text != "" ||
               cidadeMotoristaTbx.Text != "" || ufMotoristaTbx.Text != "")
                {
                return true;
                }
            else
                {
                MessageBox.Show("Preencha todos os campos antes de salvar Motorista.");
                return false;
                }
            }


        private void EditarMotoristaBtn_Click(object sender, EventArgs e)
            {

            if (validaCampos())
                {
                m.nome = NomeMotoristaTbx.Text;
                m.cpf = CpfMotoristaTbx.Text;
                m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text);
                m.cnh = cnhMotoristaTbx.Text;
                m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text);
                m.telefoneFixo = Convert.ToInt32(telefoneMotoristaTbx.Text);
                m.celular = Convert.ToInt32(celularMotoristaTbx.Text);

                var ws = new WsCorreios.AtendeClienteClient();
                var resultado = ws.consultaCEP(CepMotoristaTbx.Text);
                RuaMotoristaTbx.Text = resultado.end;
                m.nomeRua = resultado.end;
                BairroMotoristaTbx.Text = resultado.bairro;
                m.bairro = resultado.bairro;
                cidadeMotoristaTbx.Text = resultado.cidade;
                m.Cidade = resultado.cidade;
                ufMotoristaTbx.Text = resultado.uf;
                m.Uf = resultado.uf;

                daoMotorista.EditarMotorista(m);
                MessageBox.Show("Motorista editado com sucesso!");
                limparDados();
                }
            }

        private void PesquisarBtn_Click(object sender, EventArgs e)
            {

            }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
            {

            }

        private void ExcluirMotoristaBtn_Click(object sender, EventArgs e)
            {
            daoMotorista.ExcluirMotorista(m);
            limparDados();
            }
        }
    }
    

