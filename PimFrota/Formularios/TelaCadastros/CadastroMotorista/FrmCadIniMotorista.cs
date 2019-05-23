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
       

        private void GravarMotoristaBtn_Click(object sender, EventArgs e)
            {


            if (modoEdit == false)
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
            else if (modoEdit == true)
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


                    m.Cep = CepMotoristaTbx.Text;

                    m.rua = RuaMotoristaTbx.Text;
                    m.numero = NumeroRuaMotoristaTbx.Text;
                    m.Bairro = BairroMotoristaTbx.Text;
                    m.Cidade = cidadeMotoristaTbx.Text;
                    m.Uf = ufMotoristaTbx.Text;
                    
                    daoMotorista.EditarMotorista(m);
                    MessageBox.Show("Motorista Editado com sucesso!");
                    limparDados();
                }
            }

            }



        private bool validaCampos()
            {

            if (NomeMotoristaTbx.Text != "" || CpfMotoristaTbx.Text != "" || DtNascimentoMotoristaTbx.Text != "" ||
               cnhMotoristaTbx.Text != "" || DtVencCnhTbx.Text != "" || telefoneMotoristaTbx.Text != "" ||
               celularMotoristaTbx.Text != "" || CepMotoristaTbx.Text != "" || RuaMotoristaTbx.Text != "" || NomeMotoristaTbx.Text != "" || BairroMotoristaTbx.Text != "" ||
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

            PesquisarMotoristaBtn.Enabled = true;
            PesquisarBtn.Enabled = true;
            EditarMotoristaBtn.Enabled = false;
            ExcluirMotoristaBtn.Enabled = false;
            GravarMotoristaBtn.Enabled = true;

           
              
                
            }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        public void PosGravar()
            {

            CadMotoristaIniPnl.Visible = false;
            IniciaForm();




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
            m.nome =  NomeMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[0].Value.ToString();
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
            RuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[1].Value.ToString();
            NumeroRuaMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[2].Value.ToString();
            CepMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[3].Value.ToString();
            cnhMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[4].Value.ToString();
            DtVencCnhTbx.Text = dataGridViewMotorista.CurrentRow.Cells[5].Value.ToString();
            BairroMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[6].Value.ToString();
            DtNascimentoMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[7].Value.ToString();
            CpfMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[8].Value.ToString();
            // celularMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[9].Value.ToString();
            telefoneMotoristaTbx.Text = dataGridViewMotorista.CurrentRow.Cells[10].Value.ToString();
            // atualizarGrid();

           // motoristaPesquisarPnl.Visible = true;
            CadMotoristaIniPnl.Visible = true;
        }

        private void dataGridViewMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    }


