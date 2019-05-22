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
          //  atualizarGrid();
            }

        private void FrmCadiniMotorista_Load(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = true;
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
           // atualizarGrid();

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
                m.rua = resultado.end;
                m.numero = NumeroRuaMotoristaTbx.Text;
                BairroMotoristaTbx.Text = resultado.bairro;
                m.Bairro = resultado.bairro;
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
                m.rua = resultado.end;
                m.numero = NumeroRuaMotoristaTbx.Text;
                BairroMotoristaTbx.Text = resultado.bairro;
                m.Bairro = resultado.bairro;
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

            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;


            }
        public void atualizarGrid()
            {
            DaoMotorista daoMotorista = new DaoMotorista();

            dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas();

          //  dataGridViewMotorista.Columns[0].Visible = false;
          /*
            dataGridViewMotorista.Columns[0].HeaderText = "id_motorista";
            dataGridViewMotorista.Columns[2].HeaderText = "Nome";
            dataGridViewMotorista.Columns[3].HeaderText = "CPF";
            dataGridViewMotorista.Columns[4].HeaderText = "Data.Nasc";
            dataGridViewMotorista.Columns[5].HeaderText = "CNH";
            dataGridViewMotorista.Columns[6].HeaderText = "Venc.CNH";
            dataGridViewMotorista.Columns[7].HeaderText = "Telefone";
            dataGridViewMotorista.Columns[8].HeaderText = "Celular";
            dataGridViewMotorista.Columns[9].HeaderText = "CEP";
            dataGridViewMotorista.Columns[10].HeaderText = "Rua";
            dataGridViewMotorista.Columns[11].HeaderText = "Numero";
            dataGridViewMotorista.Columns[12].HeaderText = "Bairro";
            dataGridViewMotorista.Columns[13].HeaderText = "Cidade";
            dataGridViewMotorista.Columns[14].HeaderText = "UF";


            dataGridViewMotorista.Columns[0].Width = 40;
            dataGridViewMotorista.Columns[1].Width = 150;
            dataGridViewMotorista.Columns[3].Width = 80;
            dataGridViewMotorista.Columns[4].Width = 75;
            dataGridViewMotorista.Columns[5].Width = 80;
            */
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
            string cpf = PesquisarTbx.Text;

            // Motorista m = new Motorista();
            //   validaCamposMotorista();
            if (NomeCkbx.Checked == true)
                {

                dataGridViewMotorista.DataSource = daoMotorista.NomeMotoristas(nome);

                }

            else if (CpfCkbx.Checked == true)
                {
                dataGridViewMotorista.DataSource = daoMotorista.CpfMotoristas(cpf);
                }
            else if (PesquisatTodosCkb.Checked == true)
            {
                 atualizarGrid();

            }
           

        }
       


        private void dataGridViewMotorista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void NomeCkbx_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void PesquisatTodosCkb_CheckedChanged(object sender, EventArgs e)
        {
            DaoMotorista daoMotorista = new DaoMotorista();
            dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas();
        }

        private void motoristaPesquisarPnl_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
    }


