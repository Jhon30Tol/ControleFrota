using PimFrota.Formularios.Login;
using PimFrota.Formularios.Mensagens;
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

namespace PimFrota.Formularios.Base
{
    public partial class FrmBase : Form
    {




        public FrmBase()
        {
            InitializeComponent();
            UsuarioLogado();



        }

        

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            FrmSairSistema sairSistema = new FrmSairSistema();
            sairSistema.ShowDialog();
            
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void versaoLbl_Click(object sender, EventArgs e)
        {

        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            


        }

        public void UsuarioLogado()
        {
            FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
            usuarioLogadoLbl.Text = frmLogin.Usuariotxb.Text;
        }

        private void usuarioLogadoLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
