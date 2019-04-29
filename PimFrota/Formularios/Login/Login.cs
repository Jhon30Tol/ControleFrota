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
        //public int id;
        public string nome;
        public Login()
        {
            InitializeComponent();
        }

        private void Entrarbtn_Click(object sender, EventArgs e)
        {
            
            FrmHome home = new FrmHome();
            home.ShowDialog();
            this.Close();

            /*
            
            Usuario cry = new Usuario();


            //FrmCadusuario frmusu = (FrmCadusuario)Application.OpenForms["FrmCadusuario"];


            cry.Nome = Usuariotxb.Text;
            cry.Nome = Senhatxb.Text;

            Usuario novocry = new Usuario();

            novocry = Usuario.ControllerUsuario.PesquisaLogin(usuario);

            if (novocry.id != 0)
            {
                //id = novocry.id;
                ativo = novocry.Ativo;
                nome = novocry.Nome;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }

            */
    
        }

        private void Usuariotxb_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
