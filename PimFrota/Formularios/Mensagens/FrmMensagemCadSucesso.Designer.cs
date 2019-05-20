namespace PimFrota.Formularios.Mensagens
{
    partial class FrmMensagemCadSucesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensagemCadSucesso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MensagemSucessoLbl = new System.Windows.Forms.Label();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.MensagemOkBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MensagemSucessoLbl);
            this.panel1.Controls.Add(this.MsgFecharPnl);
            this.panel1.Controls.Add(this.MensagemOkBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 111);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MensagemSucessoLbl
            // 
            this.MensagemSucessoLbl.AutoSize = true;
            this.MensagemSucessoLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemSucessoLbl.Location = new System.Drawing.Point(30, 40);
            this.MensagemSucessoLbl.Name = "MensagemSucessoLbl";
            this.MensagemSucessoLbl.Size = new System.Drawing.Size(248, 16);
            this.MensagemSucessoLbl.TabIndex = 27;
            this.MensagemSucessoLbl.Text = "Cadastro Efetuado com Sucesso!";
            this.MensagemSucessoLbl.Resize += new System.EventHandler(this.MensagemSucessoLbl_Resize);
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(316, 20);
            this.MsgFecharPnl.TabIndex = 26;
            // 
            // Fecharbtn
            // 
            this.Fecharbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecharbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.Fecharbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fecharbtn.BackgroundImage")));
            this.Fecharbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fecharbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fecharbtn.FlatAppearance.BorderSize = 0;
            this.Fecharbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fecharbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fecharbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fecharbtn.Location = new System.Drawing.Point(294, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            // 
            // MensagemOkBtn
            // 
            this.MensagemOkBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.MensagemOkBtn.FlatAppearance.BorderSize = 0;
            this.MensagemOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MensagemOkBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemOkBtn.Location = new System.Drawing.Point(118, 76);
            this.MensagemOkBtn.Name = "MensagemOkBtn";
            this.MensagemOkBtn.Size = new System.Drawing.Size(75, 23);
            this.MensagemOkBtn.TabIndex = 25;
            this.MensagemOkBtn.Text = "OK";
            this.MensagemOkBtn.UseVisualStyleBackColor = false;
            this.MensagemOkBtn.Click += new System.EventHandler(this.MensagemOkBtn_Click);
            // 
            // FrmMensagemCadSucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 113);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMensagemCadSucesso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MensagemOkBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        public System.Windows.Forms.Label MensagemSucessoLbl;
    }
}
