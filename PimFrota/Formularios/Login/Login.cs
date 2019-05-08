using MySql.Data.MySqlClient;
using PimFrota.Formularios.TelaHome;
using PimServices.Model;
using System.Data;
using PimServices.RepositorySql;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PimFrota.Formularios.Login 
{
    public partial class FrmLogin : Form
    {
        Usuario u = new Usuario();

        public  FrmLogin()
        {
            InitializeComponent();
            Senhatxb.PasswordChar = '*';
        }

        private void autenticaUsuario()
        {
            

            if (Usuariotxb.Text.Equals("admin") && Senhatxb.Text.Equals("admin"))
            {

                FrmHome home = new FrmHome();
                MessageBox.Show("Login efetuado com sucesso!");
                home.ShowDialog();
                this.Close();
            }
            
           
        }
          
        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            DaoLogin daoLogin = new DaoLogin();
            u.Nome = Usuariotxb.Text;
            u.Senha = Senhatxb.Text;
            

           if (daoLogin.AutenticarUsuario(u))
            {
               // FrmLogin  frmlog = new FrmLogin();
                FrmHome home = new FrmHome();
                home.ShowDialog();
                this.Close();
               // frmlog.Close();

                
            }
            else
            {
                MessageBox.Show("Dados Incorretos");
                this.Close();
            }           

        }

        private void Usuariotxb_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void Senhatxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                autenticaUsuario();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        
        }
        private void Senhatxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrarbtn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autenticaUsuario();
            }

        }

        private void Entrarbtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
