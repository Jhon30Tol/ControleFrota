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
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.MensagemErroLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErroPctbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErroPctbx
            // 
            this.ErroPctbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ErroPctbx.BackgroundImage")));
            this.ErroPctbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ErroPctbx.Location = new System.Drawing.Point(119, 77);
            this.ErroPctbx.Name = "ErroPctbx";
            this.ErroPctbx.Size = new System.Drawing.Size(63, 27);
            this.ErroPctbx.TabIndex = 31;
            this.ErroPctbx.TabStop = false;
            this.ErroPctbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MensagemErroLbl);
            this.panel1.Controls.Add(this.MsgFecharPnl);
            this.panel1.Controls.Add(this.ErroPctbx);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 117);
            this.panel1.TabIndex = 32;
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.Yellow;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(318, 20);
            this.MsgFecharPnl.TabIndex = 32;
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
            this.Fecharbtn.Location = new System.Drawing.Point(296, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            // 
            // MensagemErroLbl
            // 
            this.MensagemErroLbl.AutoSize = true;
            this.MensagemErroLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemErroLbl.Location = new System.Drawing.Point(63, 48);
            this.MensagemErroLbl.Name = "MensagemErroLbl";
            this.MensagemErroLbl.Size = new System.Drawing.Size(183, 16);
            this.MensagemErroLbl.TabIndex = 33;
            this.MensagemErroLbl.Text = "Operação não efetuada.";
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
        private System.Windows.Forms.Label MensagemErroLbl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
    }
}
