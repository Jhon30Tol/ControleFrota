namespace PimFrota.Formularios.Mensagens
{
    partial class FrmSairSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSairSistema));
            this.msgSairSistemaLbl = new System.Windows.Forms.Label();
            this.SimSairSistemaBtn = new System.Windows.Forms.Button();
            this.NaoSairSistemaBtn = new System.Windows.Forms.Button();
            this.SairSistemaPnl = new System.Windows.Forms.Panel();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.SairSistemaPnl.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgSairSistemaLbl
            // 
            this.msgSairSistemaLbl.AutoSize = true;
            this.msgSairSistemaLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgSairSistemaLbl.Location = new System.Drawing.Point(36, 54);
            this.msgSairSistemaLbl.Name = "msgSairSistemaLbl";
            this.msgSairSistemaLbl.Size = new System.Drawing.Size(239, 16);
            this.msgSairSistemaLbl.TabIndex = 32;
            this.msgSairSistemaLbl.Text = "Deseja mesmo sair do sistema?";
            this.msgSairSistemaLbl.Click += new System.EventHandler(this.label1_Click);
            this.msgSairSistemaLbl.Resize += new System.EventHandler(this.msgSairSistemaLbl_Resize);
            // 
            // SimSairSistemaBtn
            // 
            this.SimSairSistemaBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.SimSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimSairSistemaBtn.Location = new System.Drawing.Point(72, 101);
            this.SimSairSistemaBtn.Name = "SimSairSistemaBtn";
            this.SimSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.SimSairSistemaBtn.TabIndex = 33;
            this.SimSairSistemaBtn.Text = "Sim";
            this.SimSairSistemaBtn.UseVisualStyleBackColor = false;
            this.SimSairSistemaBtn.Click += new System.EventHandler(this.SimSairSistemaBtn_Click);
            // 
            // NaoSairSistemaBtn
            // 
            this.NaoSairSistemaBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.NaoSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaoSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaoSairSistemaBtn.Location = new System.Drawing.Point(153, 101);
            this.NaoSairSistemaBtn.Name = "NaoSairSistemaBtn";
            this.NaoSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.NaoSairSistemaBtn.TabIndex = 34;
            this.NaoSairSistemaBtn.Text = "Não";
            this.NaoSairSistemaBtn.UseVisualStyleBackColor = false;
            this.NaoSairSistemaBtn.Click += new System.EventHandler(this.NaoSairSistemaBtn_Click);
            // 
            // SairSistemaPnl
            // 
            this.SairSistemaPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SairSistemaPnl.Controls.Add(this.MsgFecharPnl);
            this.SairSistemaPnl.Controls.Add(this.msgSairSistemaLbl);
            this.SairSistemaPnl.Controls.Add(this.NaoSairSistemaBtn);
            this.SairSistemaPnl.Controls.Add(this.SimSairSistemaBtn);
            this.SairSistemaPnl.Location = new System.Drawing.Point(0, 0);
            this.SairSistemaPnl.Name = "SairSistemaPnl";
            this.SairSistemaPnl.Size = new System.Drawing.Size(298, 134);
            this.SairSistemaPnl.TabIndex = 35;
            this.SairSistemaPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.SairSistemaPnl_Paint);
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(296, 20);
            this.MsgFecharPnl.TabIndex = 35;
            // 
            // Fecharbtn
            // 
            this.Fecharbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecharbtn.BackColor = System.Drawing.Color.Crimson;
            this.Fecharbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fecharbtn.BackgroundImage")));
            this.Fecharbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fecharbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fecharbtn.FlatAppearance.BorderSize = 0;
            this.Fecharbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fecharbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fecharbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fecharbtn.Location = new System.Drawing.Point(274, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click_1);
            // 
            // FrmSairSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(298, 134);
            this.Controls.Add(this.SairSistemaPnl);
            this.Name = "FrmSairSistema";
            this.SairSistemaPnl.ResumeLayout(false);
            this.SairSistemaPnl.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SairSistemaPnl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        public System.Windows.Forms.Label msgSairSistemaLbl;
        public System.Windows.Forms.Button SimSairSistemaBtn;
        public System.Windows.Forms.Button NaoSairSistemaBtn;
    }
}
