﻿using PimFrota.Formularios.Login;
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

        public void UsuarioLogado()
        {
            
            FrmLogin frmlogin = (FrmLogin)Application.OpenForms["FrmLogin"];

            
            
            usuarioLogadoLbl.Text = frmlogin.Usuariotxb.Text;
        //    usuarioLogadoLbl.SelectionFont = new Font("Roboto", 30, FontStyle.Bold);



        }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
