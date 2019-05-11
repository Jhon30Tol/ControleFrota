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
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.MsgErroLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ErroPctbx = new System.Windows.Forms.PictureBox();
            this.MsgFecharPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErroPctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.Yellow;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(298, 20);
            this.MsgFecharPnl.TabIndex = 30;
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
            this.Fecharbtn.Location = new System.Drawing.Point(276, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // MsgErroLbl
            // 
            this.MsgErroLbl.AutoSize = true;
            this.MsgErroLbl.Depth = 0;
            this.MsgErroLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.MsgErroLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MsgErroLbl.Location = new System.Drawing.Point(43, 37);
            this.MsgErroLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MsgErroLbl.Name = "MsgErroLbl";
            this.MsgErroLbl.Size = new System.Drawing.Size(166, 19);
            this.MsgErroLbl.TabIndex = 29;
            this.MsgErroLbl.Text = "Cadastro não efetuado.";
            // 
            // ErroPctbx
            // 
            this.ErroPctbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ErroPctbx.BackgroundImage")));
            this.ErroPctbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ErroPctbx.Location = new System.Drawing.Point(113, 70);
            this.ErroPctbx.Name = "ErroPctbx";
            this.ErroPctbx.Size = new System.Drawing.Size(79, 34);
            this.ErroPctbx.TabIndex = 31;
            this.ErroPctbx.TabStop = false;
            this.ErroPctbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMensagemErroCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(298, 116);
            this.Controls.Add(this.ErroPctbx);
            this.Controls.Add(this.MsgFecharPnl);
            this.Controls.Add(this.MsgErroLbl);
            this.Name = "FrmMensagemErroCadastro";
            this.MsgFecharPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErroPctbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        private MaterialSkin.Controls.MaterialLabel MsgErroLbl;
        private System.Windows.Forms.PictureBox ErroPctbx;
    }
}
