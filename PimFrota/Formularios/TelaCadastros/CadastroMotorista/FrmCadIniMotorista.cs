using PimServices.Model;
using PimServices.RepositorySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
{
    public partial class FrmCadIniMotorista : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmCadIniMotorista()
        {
            InitializeComponent();
        }

        public void modoGravar()
        {

            GravarMotoristaBtn.Enabled = true;
            EditarMotoristaBtn.Enabled = false;
            CancelarMotoristaBtn.Enabled = true;
            ExcluirMotoristaBtn.Enabled = false;
        }

        private void IncluirMotoristaBtn_Click(object sender, EventArgs e)
        {
            motoristaPnl.Visible = true;
            motoristaPesquisarPnl.Visible = false;
        }

        private void CancelarMotoristaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PesquisarMotoristaBtn_Click(object sender, EventArgs e)
        {
            motoristaPnl.Visible = false;
            motoristaPesquisarPnl.Visible = true;
        }

        private void FrmCadIniMotorista_Load(object sender, EventArgs e)
        {
            motoristaPnl.Visible = false;
            motoristaPesquisarPnl.Visible = false;
        }

        private void GravarMotoristaBtn_Click(object sender, EventArgs e)
        {
            /*
<<<<<<< HEAD
=======

>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f
            if (String.IsNullOrEmpty(CodUsuarioTbx.Text))
                MessageBox.Show("Campo nome obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(AtivoCbx.Text))
                MessageBox.Show("Campo ativo obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(NomeUsuarioTbx.Text))
                MessageBox.Show("Campo login obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (String.IsNullOrEmpty(SenhaUsuarioTbx.Text))
                MessageBox.Show("Campo senha obrigatório", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                if
                  (modoEdit == false)
                {
                    Motorista m = new Motorista();
                    Endereco e = new Endereco();
                    DaoMotorista dao = new DaoMotorista();
<<<<<<< HEAD
                   // FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
=======
                    // FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f

                    m.nome = NomeMotoristaTbx.Text;
                    m.cpf = Convert.ToInt32(CpfMotoristaTbx.Text);
                    m.cnh = Convert.ToInt32(cnhMotoristaTbx.Text);
                    m.dtaNascimento = DtNascimentoMotoristaTbx.Text;
                    m.dtaVencimentoCnh = DtVencCnhTbx.Text;
<<<<<<< HEAD
                  //  m.Motorista.nomeRua = RuaMotoristaTbx.Text;


     
=======
                    //  m.Motorista.nomeRua = RuaMotoristaTbx.Text;



>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f




<<<<<<< HEAD
        dao.SalvarUsuario(u);
=======
                    dao.SalvarMotorista(m);
                    /*
>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f

                }
                else
                {
                    // FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];
                    Motorista m = new Motorista();
                    DaoMotorista dao = new DaoMotorista();

                    u.Id = Convert.ToInt32(CodUsuarioTbx.Text);
                    u.Nome = NomeUsuarioTbx.Text;
                    u.Senha = SenhaUsuarioTbx.Text;
                    u.Ativo = AtivoCbx.Text;
                    dao.EditarrUsuario(u);
                }

                iniciaForm();
            }
            */

<<<<<<< HEAD
        }
    }
}
=======
                }
            }
        }
    

>>>>>>> fbf79a4e13891dcf9847967fc78d02dacb5b256f
