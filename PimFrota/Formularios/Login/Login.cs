using MySql.Data.MySqlClient;
using PimFrota.Formularios.TelaHome;
using PimServices.Model;
using System.Data;
using PimServices.RepositorySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using PimFrota.Formularios.Mensagens;

namespace PimFrota.Formularios.Login
{
    public partial class FrmLogin : Form
    {
        Usuario u = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();
            Senhatxb.PasswordChar = '*';
        }

        private void autenticaUsuario()
        {
            DaoLogin daoLogin = new DaoLogin();
            u.Nome = Usuariotxb.Text;
            u.Senha = Senhatxb.Text;

            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorio = (FrmMensagemCampoObrigatorio)Application.OpenForms["FrmMensagemCampoObrigatorio"];
            FrmMensagemCampoObrigatorio frmMsgCampoObrigatorioMsg = new FrmMensagemCampoObrigatorio();

            if (daoLogin.AutenticarUsuario(u))
            {
                this.Hide();
                FrmHome home = new FrmHome();
                home.Closed += (s, args) => this.Close();
                home.ShowDialog();
            }
            else
            {
                frmMsgCampoObrigatorioMsg.MensagemCampoObrigatorioLbl.Text = "Dados Incorretos";
                frmMsgCampoObrigatorioMsg.ShowDialog();
                Usuariotxb.Focus();
                Usuariotxb.Clear();
                Senhatxb.Clear();
            }
        }
        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            autenticaUsuario();
        }
        private void Usuariotxb_Validating(object sender, CancelEventArgs e)
        {

        }
        private void Senhatxb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Senhatxb_KeyDown(object sender, EventArgs u)
        {
          
        }
        private void FrmLogin_KeyUp(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                autenticaUsuario();
                }
            }
        private void Senhatxb_KeyUp(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                autenticaUsuario();
                }
            }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
