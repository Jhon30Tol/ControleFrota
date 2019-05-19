namespace PimFrota.Formularios.Mensagens
{
    partial class FrmMensagemCampoObrigatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensagemCampoObrigatorio));
            this.MensagemOkBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.MensagemCampoObrigatorioLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MensagemOkBtn
            // 
            this.MensagemOkBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.MensagemOkBtn.FlatAppearance.BorderSize = 0;
            this.MensagemOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MensagemOkBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemOkBtn.Location = new System.Drawing.Point(149, 80);
            this.MensagemOkBtn.Name = "MensagemOkBtn";
            this.MensagemOkBtn.Size = new System.Drawing.Size(75, 23);
            this.MensagemOkBtn.TabIndex = 28;
            this.MensagemOkBtn.Text = "OK";
            this.MensagemOkBtn.UseVisualStyleBackColor = false;
            this.MensagemOkBtn.Click += new System.EventHandler(this.MensagemOkBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MsgFecharPnl);
            this.panel1.Controls.Add(this.MensagemCampoObrigatorioLbl);
            this.panel1.Controls.Add(this.MensagemOkBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 115);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(382, 20);
            this.MsgFecharPnl.TabIndex = 31;
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
            this.Fecharbtn.Location = new System.Drawing.Point(360, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // MensagemCampoObrigatorioLbl
            // 
            this.MensagemCampoObrigatorioLbl.AutoSize = true;
            this.MensagemCampoObrigatorioLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemCampoObrigatorioLbl.Location = new System.Drawing.Point(55, 47);
            this.MensagemCampoObrigatorioLbl.Name = "MensagemCampoObrigatorioLbl";
            this.MensagemCampoObrigatorioLbl.Size = new System.Drawing.Size(257, 16);
            this.MensagemCampoObrigatorioLbl.TabIndex = 30;
            this.MensagemCampoObrigatorioLbl.Text = "Preencha os campos Obrigatórios.";
            this.MensagemCampoObrigatorioLbl.Resize += new System.EventHandler(this.MensagemCampoObrigatorioLbl_Resize);
            // 
            // FrmMensagemCampoObrigatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(387, 117);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMensagemCampoObrigatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MensagemOkBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label MensagemCampoObrigatorioLbl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
    }
}
