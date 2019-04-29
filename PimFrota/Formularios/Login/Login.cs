using PimFrota.Formularios.TelaCadastros.CadastroUsuario;
using PimFrota.Formularios.TelaHome;
using PimServices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFrota.Formularios.Login 
{
    public partial class Login : Form
    {
        public string ativo;
       
        public string nome;
        public Login()
        {
            InitializeComponent();
            Senhatxb.PasswordChar = '*';
        }

        private void validarUsuario()
        {
            if (Usuariotxb.Text.Equals("admin") && Senhatxb.Text.Equals("admin"))
            {

                FrmHome home = new FrmHome();
                MessageBox.Show("Login efetuado com sucesso!");
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados incorretos, informe novamente!");
                Usuariotxb.Text = "";
                Senhatxb.Text = "";
                //Usuariotxb.Text.Focus();
            }
        }
        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            validarUsuario();

        }

        private void Usuariotxb_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void Senhatxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validarUsuario();
            }
        }
    }
}
