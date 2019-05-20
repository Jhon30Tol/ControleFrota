using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PimFrota.Formularios.TelaViagem;
using PimFrota.Formularios.TelaViagem.Retorno_Viagem;

namespace PimFrota.Formularios.Base
{
    public partial class FrmBaseViagem : PimFrota.Formularios.Base.FrmBaseFundoCad
    {
        public FrmBaseViagem()
        {
            InitializeComponent();
        }

        public void FechaFormViagem()
        {
            if (iniSaidaViagem != null)
                iniSaidaViagem.Close();

            if (iniRetornoViagem != null)
                iniRetornoViagem.Close();
        }


        FrmCadIniSaidaViagem iniSaidaViagem;
        FrmCadIniRetornoViagem iniRetornoViagem;


        public object FrmBaseViagemPnl { get; private set; }

        private void Fecharbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaidaViagemBtn_Click(object sender, EventArgs e)
        {
            FechaFormViagem();
            iniSaidaViagem = new FrmCadIniSaidaViagem();
            iniSaidaViagem.TopLevel = false;
            iniSaidaViagem.AutoScroll = true;
            iniSaidaViagem.FormBorderStyle = FormBorderStyle.None;
            this.BaseIniViagemPnl.Controls.Add(iniSaidaViagem);
            iniSaidaViagem.Show();
        }

        private void RetornoViagemBtn_Click(object sender, EventArgs e)
        {
            FechaFormViagem();
            iniRetornoViagem = new FrmCadIniRetornoViagem();
            iniRetornoViagem.TopLevel = false;
            iniRetornoViagem.AutoScroll = true;
            iniRetornoViagem.FormBorderStyle = FormBorderStyle.None;
            this.BaseIniViagemPnl.Controls.Add(iniRetornoViagem);
            iniRetornoViagem.Show();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BaseIniViagemPnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ManutencaoViagemBtn_Click(object sender, EventArgs e)
        {
            FechaFormViagem();
            iniSaidaViagem = new FrmCadIniSaidaViagem();
            iniSaidaViagem.TopLevel = false;
            iniSaidaViagem.AutoScroll = true;
            iniSaidaViagem.FormBorderStyle = FormBorderStyle.None;
            this.BaseIniViagemPnl.Controls.Add(iniSaidaViagem);
            iniSaidaViagem.Show();
        }
    }
}
