namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    partial class FrmCadusuario
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
            this.SenhaUsuarioTbx = new System.Windows.Forms.TextBox();
            this.NomeUsuarioTbx = new System.Windows.Forms.TextBox();
            this.CodUsuarioTbx = new System.Windows.Forms.TextBox();
            this.SenhaUsuarioLbl = new System.Windows.Forms.Label();
            this.Codusuariobl = new System.Windows.Forms.Label();
            this.NomeUsuarioLbl = new System.Windows.Forms.Label();
            this.AtvoLbl = new System.Windows.Forms.Label();
            this.AtivoCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SenhaUsuarioTbx
            // 
            this.SenhaUsuarioTbx.Location = new System.Drawing.Point(79, 132);
            this.SenhaUsuarioTbx.Name = "SenhaUsuarioTbx";
            this.SenhaUsuarioTbx.Size = new System.Drawing.Size(189, 20);
            this.SenhaUsuarioTbx.TabIndex = 106;
            // 
            // NomeUsuarioTbx
            // 
            this.NomeUsuarioTbx.Location = new System.Drawing.Point(79, 97);
            this.NomeUsuarioTbx.Name = "NomeUsuarioTbx";
            this.NomeUsuarioTbx.Size = new System.Drawing.Size(189, 20);
            this.NomeUsuarioTbx.TabIndex = 105;
            // 
            // CodUsuarioTbx
            // 
            this.CodUsuarioTbx.Enabled = false;
            this.CodUsuarioTbx.Location = new System.Drawing.Point(79, 20);
            this.CodUsuarioTbx.Name = "CodUsuarioTbx";
            this.CodUsuarioTbx.Size = new System.Drawing.Size(76, 20);
            this.CodUsuarioTbx.TabIndex = 104;
            this.CodUsuarioTbx.Text = "Automatico";
            // 
            // SenhaUsuarioLbl
            // 
            this.SenhaUsuarioLbl.AutoSize = true;
            this.SenhaUsuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.SenhaUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaUsuarioLbl.Location = new System.Drawing.Point(9, 135);
            this.SenhaUsuarioLbl.Name = "SenhaUsuarioLbl";
            this.SenhaUsuarioLbl.Size = new System.Drawing.Size(59, 17);
            this.SenhaUsuarioLbl.TabIndex = 103;
            this.SenhaUsuarioLbl.Text = "Senha:";
            // 
            // Codusuariobl
            // 
            this.Codusuariobl.AutoSize = true;
            this.Codusuariobl.BackColor = System.Drawing.Color.Transparent;
            this.Codusuariobl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codusuariobl.Location = new System.Drawing.Point(9, 23);
            this.Codusuariobl.Name = "Codusuariobl";
            this.Codusuariobl.Size = new System.Drawing.Size(63, 17);
            this.Codusuariobl.TabIndex = 102;
            this.Codusuariobl.Text = "Código:";
            // 
            // NomeUsuarioLbl
            // 
            this.NomeUsuarioLbl.AutoSize = true;
            this.NomeUsuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUsuarioLbl.Location = new System.Drawing.Point(9, 100);
            this.NomeUsuarioLbl.Name = "NomeUsuarioLbl";
            this.NomeUsuarioLbl.Size = new System.Drawing.Size(54, 17);
            this.NomeUsuarioLbl.TabIndex = 101;
            this.NomeUsuarioLbl.Text = "Nome:";
            // 
            // AtvoLbl
            // 
            this.AtvoLbl.AutoSize = true;
            this.AtvoLbl.BackColor = System.Drawing.Color.Transparent;
            this.AtvoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtvoLbl.Location = new System.Drawing.Point(14, 60);
            this.AtvoLbl.Name = "AtvoLbl";
            this.AtvoLbl.Size = new System.Drawing.Size(49, 17);
            this.AtvoLbl.TabIndex = 107;
            this.AtvoLbl.Text = "Ativo:";
            // 
            // AtivoCbx
            // 
            this.AtivoCbx.FormattingEnabled = true;
            this.AtivoCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.AtivoCbx.Location = new System.Drawing.Point(79, 56);
            this.AtivoCbx.Name = "AtivoCbx";
            this.AtivoCbx.Size = new System.Drawing.Size(76, 21);
            this.AtivoCbx.TabIndex = 108;
            this.AtivoCbx.SelectedIndexChanged += new System.EventHandler(this.AtivoCbx_SelectedIndexChanged);
            // 
            // FrmCadusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(303, 179);
            this.Controls.Add(this.AtivoCbx);
            this.Controls.Add(this.AtvoLbl);
            this.Controls.Add(this.SenhaUsuarioTbx);
            this.Controls.Add(this.NomeUsuarioTbx);
            this.Controls.Add(this.CodUsuarioTbx);
            this.Controls.Add(this.SenhaUsuarioLbl);
            this.Controls.Add(this.Codusuariobl);
            this.Controls.Add(this.NomeUsuarioLbl);
            this.Name = "FrmCadusuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodUsuarioTbx;
        private System.Windows.Forms.Label SenhaUsuarioLbl;
        private System.Windows.Forms.Label Codusuariobl;
        private System.Windows.Forms.Label NomeUsuarioLbl;
        private System.Windows.Forms.Label AtvoLbl;
        public System.Windows.Forms.ComboBox AtivoCbx;
        public System.Windows.Forms.TextBox SenhaUsuarioTbx;
        public System.Windows.Forms.TextBox NomeUsuarioTbx;
    }
}
