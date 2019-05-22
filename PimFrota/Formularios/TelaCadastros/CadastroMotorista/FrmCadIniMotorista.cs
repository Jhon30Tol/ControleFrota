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
            CadMotoristaIniPnl.Visible = true ;
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
            BairroMotoristaTbx.Clear();
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
                m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text.ToString());
                m.cnh = cnhMotoristaTbx.Text;


                m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text.ToString());
                m.telefoneFixo = Convert.ToString(telefoneMotoristaTbx.Text);
                m.celular = Convert.ToString(celularMotoristaTbx.Text);

                var ws = new WsCorreios.AtendeClienteClient();
                var resultado = ws.consultaCEP(CepMotoristaTbx.Text);
                m.Cep = CepMotoristaTbx.Text;
                RuaMotoristaTbx.Text = resultado.end;
                m.nomeRua = resultado.end;
                m.numero = NumeroRuaMotoristaTbx.Text;
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
            else if (string.IsNullOrEmpty(DtVencCnhTbx.Text))
                {
                MessageBox.Show("Campo nao pode ser nulo!");
                return false;
                }

            else if (Convert.ToDateTime(DtVencCnhTbx.Text + " 23:59:59") >= DateTime.Now)
                {
                return true;
                }
            else if (Convert.ToDateTime(DtVencCnhTbx.Text + " 23:59:59") < DateTime.Now)
                {
                MessageBox.Show("O prazo de validade desta CNH esta Vencido!");
                return false;
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
                m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text.ToString());
                m.cnh = cnhMotoristaTbx.Text;
                m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text.ToString());
                m.telefoneFixo = Convert.ToString(telefoneMotoristaTbx.Text);
                m.celular = Convert.ToString(celularMotoristaTbx.Text);

                var ws = new WsCorreios.AtendeClienteClient();
                var resultado = ws.consultaCEP(CepMotoristaTbx.Text);
                m.Cep = CepMotoristaTbx.Text;
                RuaMotoristaTbx.Text = resultado.end;
                m.nomeRua = resultado.end;
                m.numero = NumeroRuaMotoristaTbx.Text;
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

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void ExcluirMotoristaBtn_Click(object sender, EventArgs e)
            {
            daoMotorista.ExcluirMotorista(m);
            limparDados();
            }



        private void dataGridViewMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            DaoMotorista daoMotorista = new DaoMotorista();
            dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas(m);
            NomeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString();
            CpfMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString();
            DtNascimentoMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[2].Value.ToString();
            cnhMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[3].Value.ToString();
            DtVencCnhTbx.Text = dataGridViewMotorista.CurrentRow.Cells[4].Value.ToString();
            telefoneMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[5].Value.ToString();
            celularMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[6].Value.ToString();
            CepMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[7].Value.ToString();
            RuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[8].Value.ToString();
            NumeroRuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[9].Value.ToString();
            cidadeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[10].Value.ToString();
            ufMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[11].Value.ToString();

            NomeMotoristaTbx.Enabled = false;
            CpfMotoristaTbx.Enabled = false;
            DtNascimentoMotoristaTbx.Enabled = false;
            cnhMotoristaTbx.Enabled = false;
            DtVencCnhTbx.Enabled = false;
            telefoneMotoristaTbx.Enabled = false;
            celularMotoristaTbx.Enabled = false;
            CepMotoristaTbx.Enabled = false;
            RuaMotoristaTbx.Enabled = false;
            NumeroRuaMotoristaTbx.Enabled = false;
            cidadeMotoristaTbx.Enabled = false;
            ufMotoristaTbx.Enabled = false;

            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;


            }


        private void PesquisarLbl_Click(object sender, EventArgs e)
            {

            }

        private void CpfCkbx_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void NomeCkbx_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void motoristaPesquisarPnl_Paint(object sender, PaintEventArgs e)
            {

            }
        private void validaCamposMotorista()
            {
            if (PesquisarTbx.Text == "")
                {
                MessageBox.Show("Preencha o campo antes de efetuar a pesquisa!");
                }
            }



        private void PesquisarBtn_Click_2(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;

            string nome = PesquisarTbx.Text;

            validaCamposMotorista();
            if (NomeCkbx.Checked == true)
                {

                DaoMotorista daoMotorista = new DaoMotorista();
                dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas(m);

                }

            else if (CpfCkbx.Checked == true)
                {
                DaoMotorista daoMotorista = new DaoMotorista();
                dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas(m);
                }

            }

        private void dataGridViewMotorista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }


        }
    }


