namespace PimFrota.Formularios.Mensagens
{
    partial class FrmMensagemErroCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensagemErroCadastro));
            this.ErroPctbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MEnsagemErroLbl = new System.Windows.Forms.Label();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErroPctbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErroPctbx
            // 
            this.ErroPctbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ErroPctbx.BackgroundImage")));
            this.ErroPctbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ErroPctbx.Location = new System.Drawing.Point(119, 74);
            this.ErroPctbx.Name = "ErroPctbx";
            this.ErroPctbx.Size = new System.Drawing.Size(64, 29);
            this.ErroPctbx.TabIndex = 31;
            this.ErroPctbx.TabStop = false;
            this.ErroPctbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MsgFecharPnl);
            this.panel1.Controls.Add(this.MEnsagemErroLbl);
            this.panel1.Controls.Add(this.ErroPctbx);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 120);
            this.panel1.TabIndex = 32;
            // 
            // MEnsagemErroLbl
            // 
            this.MEnsagemErroLbl.AutoSize = true;
            this.MEnsagemErroLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEnsagemErroLbl.Location = new System.Drawing.Point(128, 42);
            this.MEnsagemErroLbl.Name = "MEnsagemErroLbl";
            this.MEnsagemErroLbl.Size = new System.Drawing.Size(42, 18);
            this.MEnsagemErroLbl.TabIndex = 33;
            this.MEnsagemErroLbl.Text = "Erro";
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(319, 20);
            this.MsgFecharPnl.TabIndex = 34;
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
            this.Fecharbtn.Location = new System.Drawing.Point(297, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click_1);
            // 
            // FrmMensagemErroCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 117);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMensagemErroCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.ErroPctbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ErroPctbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MEnsagemErroLbl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
    }
}
