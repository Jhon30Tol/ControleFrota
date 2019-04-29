namespace PimFrota.Formularios.TelaCadastros.CadastroCidade
{
    partial class FrmCadCidade
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EstadoTbx = new System.Windows.Forms.TextBox();
            this.CodIbgeTbx = new System.Windows.Forms.TextBox();
            this.NomeCidadeTbx = new System.Windows.Forms.TextBox();
            this.CodCidadeTbx = new System.Windows.Forms.TextBox();
            this.EstadoLbl = new System.Windows.Forms.Label();
            this.CodCidadelbl = new System.Windows.Forms.Label();
            this.IbgeCidadeLbl = new System.Windows.Forms.Label();
            this.NomeCidadeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EstadoTbx
            // 
            this.EstadoTbx.Location = new System.Drawing.Point(118, 64);
            this.EstadoTbx.MaxLength = 2;
            this.EstadoTbx.Name = "EstadoTbx";
            this.EstadoTbx.Size = new System.Drawing.Size(56, 20);
            this.EstadoTbx.TabIndex = 99;
            this.EstadoTbx.Validating += new System.ComponentModel.CancelEventHandler(this.EstadoTbx_Validating);
            // 
            // CodIbgeTbx
            // 
            this.CodIbgeTbx.Location = new System.Drawing.Point(118, 87);
            this.CodIbgeTbx.Name = "CodIbgeTbx";
            this.CodIbgeTbx.Size = new System.Drawing.Size(95, 20);
            this.CodIbgeTbx.TabIndex = 98;
            // 
            // NomeCidadeTbx
            // 
            this.NomeCidadeTbx.Location = new System.Drawing.Point(118, 38);
            this.NomeCidadeTbx.MaxLength = 50;
            this.NomeCidadeTbx.Name = "NomeCidadeTbx";
            this.NomeCidadeTbx.Size = new System.Drawing.Size(222, 20);
            this.NomeCidadeTbx.TabIndex = 97;
            this.NomeCidadeTbx.Validating += new System.ComponentModel.CancelEventHandler(this.NomeCidadeTbx_Validating);
            // 
            // CodCidadeTbx
            // 
            this.CodCidadeTbx.Location = new System.Drawing.Point(119, 12);
            this.CodCidadeTbx.Name = "CodCidadeTbx";
            this.CodCidadeTbx.Size = new System.Drawing.Size(94, 20);
            this.CodCidadeTbx.TabIndex = 96;
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.AutoSize = true;
            this.EstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.EstadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLbl.Location = new System.Drawing.Point(49, 67);
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(63, 17);
            this.EstadoLbl.TabIndex = 95;
            this.EstadoLbl.Text = "Estado:";
            // 
            // CodCidadelbl
            // 
            this.CodCidadelbl.AutoSize = true;
            this.CodCidadelbl.BackColor = System.Drawing.Color.Transparent;
            this.CodCidadelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodCidadelbl.Location = new System.Drawing.Point(49, 15);
            this.CodCidadelbl.Name = "CodCidadelbl";
            this.CodCidadelbl.Size = new System.Drawing.Size(63, 17);
            this.CodCidadelbl.TabIndex = 94;
            this.CodCidadelbl.Text = "Código:";
            // 
            // IbgeCidadeLbl
            // 
            this.IbgeCidadeLbl.AutoSize = true;
            this.IbgeCidadeLbl.BackColor = System.Drawing.Color.Transparent;
            this.IbgeCidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbgeCidadeLbl.Location = new System.Drawing.Point(25, 90);
            this.IbgeCidadeLbl.Name = "IbgeCidadeLbl";
            this.IbgeCidadeLbl.Size = new System.Drawing.Size(87, 17);
            this.IbgeCidadeLbl.TabIndex = 93;
            this.IbgeCidadeLbl.Text = "Cod. IBGE:";
            // 
            // NomeCidadeLbl
            // 
            this.NomeCidadeLbl.AutoSize = true;
            this.NomeCidadeLbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeCidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCidadeLbl.Location = new System.Drawing.Point(44, 41);
            this.NomeCidadeLbl.Name = "NomeCidadeLbl";
            this.NomeCidadeLbl.Size = new System.Drawing.Size(68, 17);
            this.NomeCidadeLbl.TabIndex = 92;
            this.NomeCidadeLbl.Text = " Cidade:";
            // 
            // FrmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(389, 130);
            this.Controls.Add(this.EstadoTbx);
            this.Controls.Add(this.CodIbgeTbx);
            this.Controls.Add(this.NomeCidadeTbx);
            this.Controls.Add(this.CodCidadeTbx);
            this.Controls.Add(this.EstadoLbl);
            this.Controls.Add(this.CodCidadelbl);
            this.Controls.Add(this.IbgeCidadeLbl);
            this.Controls.Add(this.NomeCidadeLbl);
            this.Name = "FrmCadCidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EstadoTbx;
        private System.Windows.Forms.TextBox CodIbgeTbx;
        private System.Windows.Forms.TextBox NomeCidadeTbx;
        private System.Windows.Forms.TextBox CodCidadeTbx;
        private System.Windows.Forms.Label EstadoLbl;
        private System.Windows.Forms.Label CodCidadelbl;
        private System.Windows.Forms.Label IbgeCidadeLbl;
        private System.Windows.Forms.Label NomeCidadeLbl;
    }
}
