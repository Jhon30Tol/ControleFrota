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
        Endereco endereco = new Endereco();
        bool modoEdit = false;

        public FrmCadiniMotorista()
            {
            InitializeComponent();
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

        private void GravarMotoristaBtn_Click(object sender, EventArgs e)
            {
            FrmMensagemCadSucesso msgCadastroSucesso = new FrmMensagemCadSucesso();

            if (modoEdit == false)
                {
                if (validaCampos() == true)
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
                    msgCadastroSucesso.ShowDialog(); limparDados();
                    }
                else
                    {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                    }
                }
            else if (modoEdit == true)
                {
                if (validaCampos() == true)
                    {

                    m.nome = NomeMotoristaTbx.Text;
                    m.cpf = CpfMotoristaTbx.Text;
                    m.dtaNascimento = Convert.ToDateTime(DtNascimentoMotoristaTbx.Text.ToString());
                    m.cnh = cnhMotoristaTbx.Text;

                    m.dtaVencimentoCnh = Convert.ToDateTime(DtVencCnhTbx.Text.ToString());
                    m.telefoneFixo = Convert.ToString(telefoneMotoristaTbx.Text);
                    m.celular = Convert.ToString(celularMotoristaTbx.Text);

                    m.Cep = CepMotoristaTbx.Text;
                    m.rua = RuaMotoristaTbx.Text;
                    m.numero = NumeroRuaMotoristaTbx.Text;
                    m.Bairro = BairroMotoristaTbx.Text;
                    m.Cidade = cidadeMotoristaTbx.Text;
                    m.Uf = ufMotoristaTbx.Text;

                    daoMotorista.EditarMotorista(m);
                    msgCadastroSucesso.MensagemSucessoLbl.Text = "Motorista editado com sucesso !";
                    msgCadastroSucesso.ShowDialog();
                    limparDados();
                    motoristaPesquisarPnl.Enabled = true;
                    }
                else
                    {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                    }
                }
            }

        private bool validaCampos()
            {
            if (NomeMotoristaTbx.Text == "" && CpfMotoristaTbx.Text == "" && DtNascimentoMotoristaTbx.Text == "" &&
               cnhMotoristaTbx.Text == "" && DtVencCnhTbx.Text == "" && telefoneMotoristaTbx.Text == "" &&
               celularMotoristaTbx.Text == "" && CepMotoristaTbx.Text == "" && RuaMotoristaTbx.Text == "" && NomeMotoristaTbx.Text == "" && BairroMotoristaTbx.Text == "" &&
               cidadeMotoristaTbx.Text == "" && ufMotoristaTbx.Text == "")
                {
                MessageBox.Show("Todos os dados devem ser preenchidos!");
                return false;
                }
            else
                {
                return true;
                }
            }

        private void EditarMotoristaBtn_Click(object sender, EventArgs e)
            {
            modoEdit = true;

            NomeMotoristaTbx.Enabled = true;
            RuaMotoristaTbx.Enabled = true;
            NumeroRuaMotoristaTbx.Enabled = true;
            CepMotoristaTbx.Enabled = true;
            cnhMotoristaTbx.Enabled = true;
            DtVencCnhTbx.Enabled = true;
            BairroMotoristaTbx.Enabled = true;
            DtNascimentoMotoristaTbx.Enabled = true;
            CpfMotoristaTbx.Enabled = true;
            celularMotoristaTbx.Enabled = true;
            telefoneMotoristaTbx.Enabled = true;

            PesquisarMotoristaBtn.Enabled = false;
            PesquisarBtn.Enabled = true;
            EditarMotoristaBtn.Enabled = true;
            ExcluirMotoristaBtn.Enabled = false;

            cidadeMotoristaTbx.Enabled = true;
            ufMotoristaTbx.Enabled = true;
            permissao();
            }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        public void permissao()
            {
            if (EditarMotoristaBtn != null)
                {
                GravarMotoristaBtn.Enabled = true;
                }
            else
                {
                MessageBox.Show("Campos nao atualizados.");
                GravarMotoristaBtn.Enabled = false;
                }
            }

        public void PosGravar()
            {

            CadMotoristaIniPnl.Visible = false;
            IniciaForm();
            atualizarGrid();
            }
        public void IniciaForm()
            {
            motoristaPesquisarPnl.Visible = false;
            }
        private void ExcluirMotoristaBtn_Click(object sender, EventArgs e)
            {
            FrmMensagemCadSucesso frmMsgSucesso = (FrmMensagemCadSucesso)Application.OpenForms["FrmMensagemCadSucesso"];
            FrmMensagemCadSucesso frmMsgSucessomsg = new FrmMensagemCadSucesso();

            FrmMsgSimNao frmMsgExcluirv = (FrmMsgSimNao)Application.OpenForms["FrmSairSistema"];
            FrmMsgSimNao frmMsgExcluir = new FrmMsgSimNao();

            frmMsgExcluir.ShowDialog();

            if (frmMsgExcluir.btnSairClick == true)
                {
                DaoMotorista daoMotorista = new DaoMotorista();
                daoMotorista.ExcluirMotorista(m);
                PosGravar();
                }
            daoMotorista.ExcluirMotorista(m);
            limparDados();
            }

        public void atualizarGrid()
            {
            DaoMotorista daoMotorista = new DaoMotorista();

            dataGridViewMotorista.DataSource = daoMotorista.TodosMotoristas();
            }



        private void PesquisarLbl_Click(object sender, EventArgs e)
            {

            }

        private void PesquisarBtn_Click_2(object sender, EventArgs e)
            {
            motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = false;

            string nome = PesquisarTbx.Text;
            string cpf = PesquisarTbx.Text;

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

            m.nome = NomeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString();
            m.id_motorista = Convert.ToInt32(dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString());
            RuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[2].Value.ToString();
            NumeroRuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[3].Value.ToString();
            CepMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[4].Value.ToString();
            cnhMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[5].Value.ToString();
            DtVencCnhTbx.Text = dataGridViewMotorista.CurrentRow.Cells[6].Value.ToString();
            BairroMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[7].Value.ToString();
            DtNascimentoMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[8].Value.ToString();
            CpfMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[9].Value.ToString();
            celularMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[10].Value.ToString();
            telefoneMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[11].Value.ToString();
            cidadeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[12].Value.ToString();
            ufMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[13].Value.ToString();

            NomeMotoristaTbx.Enabled = false;
            RuaMotoristaTbx.Enabled = false;
            NumeroRuaMotoristaTbx.Enabled = false;
            CepMotoristaTbx.Enabled = false;
            cnhMotoristaTbx.Enabled = false;
            DtVencCnhTbx.Enabled = false;
            BairroMotoristaTbx.Enabled = false;
            DtNascimentoMotoristaTbx.Enabled = false;
            CpfMotoristaTbx.Enabled = false;
            celularMotoristaTbx.Enabled = false;
            telefoneMotoristaTbx.Enabled = false;
            cidadeMotoristaTbx.Enabled = false;
            ufMotoristaTbx.Enabled = false;

            motoristaPesquisarPnl.Visible = false;
            CadMotoristaIniPnl.Visible = true;

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

        private void dataGridViewMotorista_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            NomeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString();
            m.id_motorista = Convert.ToInt32(dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString());
            RuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[2].Value.ToString();
            NumeroRuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[3].Value.ToString();
            CepMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[4].Value.ToString();
            cnhMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[5].Value.ToString();
            DtVencCnhTbx.Text = dataGridViewMotorista.CurrentRow.Cells[6].Value.ToString();
            BairroMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[7].Value.ToString();
            DtNascimentoMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[8].Value.ToString();
            CpfMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[9].Value.ToString();
            telefoneMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[10].Value.ToString();
            cidadeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[11].Value.ToString();
            ufMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[12].Value.ToString();
            CadMotoristaIniPnl.Visible = true;
            }

        private void BotaoCadastroPnl_Paint(object sender, PaintEventArgs e)
            {

            }

        private void PesquisarTbx_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }


