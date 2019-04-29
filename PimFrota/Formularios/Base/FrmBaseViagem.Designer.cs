namespace PimFrota.Formularios.Base
{
    partial class FrmBaseViagem 
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
            MaterialSkin.Controls.MaterialFlatButton RetornoViagemBtn;
            MaterialSkin.Controls.MaterialFlatButton SaidaViagemBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseViagem));
            this.BaseVendaMenuFecharPnl = new System.Windows.Forms.Panel();
            this.ViagemLbl = new System.Windows.Forms.Label();
            this.BaseViagemPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.BaseViagemMenuPnl = new System.Windows.Forms.Panel();
            this.MotoristaPctBx = new System.Windows.Forms.PictureBox();
            this.usuarioPctbx = new System.Windows.Forms.PictureBox();
            this.BaseIniViagemPnl = new System.Windows.Forms.FlowLayoutPanel();
            RetornoViagemBtn = new MaterialSkin.Controls.MaterialFlatButton();
            SaidaViagemBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.BaseVendaMenuFecharPnl.SuspendLayout();
            this.BaseViagemMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotoristaPctBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // RetornoViagemBtn
            // 
            RetornoViagemBtn.AutoSize = true;
            RetornoViagemBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            RetornoViagemBtn.BackColor = System.Drawing.Color.Ivory;
            RetornoViagemBtn.Depth = 0;
            RetornoViagemBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            RetornoViagemBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RetornoViagemBtn.ForeColor = System.Drawing.Color.White;
            RetornoViagemBtn.Location = new System.Drawing.Point(57, 83);
            RetornoViagemBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            RetornoViagemBtn.MouseState = MaterialSkin.MouseState.HOVER;
            RetornoViagemBtn.Name = "RetornoViagemBtn";
            RetornoViagemBtn.Primary = false;
            RetornoViagemBtn.Size = new System.Drawing.Size(74, 36);
            RetornoViagemBtn.TabIndex = 27;
            RetornoViagemBtn.Text = "Retorno";
            RetornoViagemBtn.UseVisualStyleBackColor = false;
            RetornoViagemBtn.Click += new System.EventHandler(this.RetornoViagemBtn_Click);
            // 
            // SaidaViagemBtn
            // 
            SaidaViagemBtn.AutoSize = true;
            SaidaViagemBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SaidaViagemBtn.BackColor = System.Drawing.Color.Ivory;
            SaidaViagemBtn.Depth = 0;
            SaidaViagemBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            SaidaViagemBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SaidaViagemBtn.ForeColor = System.Drawing.Color.White;
            SaidaViagemBtn.Location = new System.Drawing.Point(57, 28);
            SaidaViagemBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            SaidaViagemBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SaidaViagemBtn.Name = "SaidaViagemBtn";
            SaidaViagemBtn.Primary = false;
            SaidaViagemBtn.Size = new System.Drawing.Size(51, 36);
            SaidaViagemBtn.TabIndex = 26;
            SaidaViagemBtn.Text = "Saída";
            SaidaViagemBtn.UseVisualStyleBackColor = false;
            SaidaViagemBtn.Click += new System.EventHandler(this.SaidaViagemBtn_Click);
            // 
            // BaseVendaMenuFecharPnl
            // 
            this.BaseVendaMenuFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseVendaMenuFecharPnl.Controls.Add(this.ViagemLbl);
            this.BaseVendaMenuFecharPnl.Controls.Add(this.BaseViagemPnl);
            this.BaseVendaMenuFecharPnl.Controls.Add(this.MinimizeBtn);
            this.BaseVendaMenuFecharPnl.Controls.Add(this.Fecharbtn);
            this.BaseVendaMenuFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseVendaMenuFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.BaseVendaMenuFecharPnl.Name = "BaseVendaMenuFecharPnl";
            this.BaseVendaMenuFecharPnl.Size = new System.Drawing.Size(800, 48);
            this.BaseVendaMenuFecharPnl.TabIndex = 24;
            // 
            // ViagemLbl
            // 
            this.ViagemLbl.AutoSize = true;
            this.ViagemLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViagemLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViagemLbl.Location = new System.Drawing.Point(3, 7);
            this.ViagemLbl.Name = "ViagemLbl";
            this.ViagemLbl.Size = new System.Drawing.Size(106, 25);
            this.ViagemLbl.TabIndex = 29;
            this.ViagemLbl.Text = "VIAGEM";
            // 
            // BaseViagemPnl
            // 
            this.BaseViagemPnl.Location = new System.Drawing.Point(200, 48);
            this.BaseViagemPnl.Name = "BaseViagemPnl";
            this.BaseViagemPnl.Size = new System.Drawing.Size(597, 500);
            this.BaseViagemPnl.TabIndex = 28;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.MinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.BackgroundImage")));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(717, 9);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 28);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
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
            this.Fecharbtn.Location = new System.Drawing.Point(764, 11);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(25, 25);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // BaseViagemMenuPnl
            // 
            this.BaseViagemMenuPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseViagemMenuPnl.Controls.Add(RetornoViagemBtn);
            this.BaseViagemMenuPnl.Controls.Add(this.MotoristaPctBx);
            this.BaseViagemMenuPnl.Controls.Add(SaidaViagemBtn);
            this.BaseViagemMenuPnl.Controls.Add(this.usuarioPctbx);
            this.BaseViagemMenuPnl.Location = new System.Drawing.Point(0, 48);
            this.BaseViagemMenuPnl.Name = "BaseViagemMenuPnl";
            this.BaseViagemMenuPnl.Size = new System.Drawing.Size(200, 550);
            this.BaseViagemMenuPnl.TabIndex = 26;
            // 
            // MotoristaPctBx
            // 
            this.MotoristaPctBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MotoristaPctBx.BackgroundImage")));
            this.MotoristaPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MotoristaPctBx.Location = new System.Drawing.Point(3, 70);
            this.MotoristaPctBx.Name = "MotoristaPctBx";
            this.MotoristaPctBx.Size = new System.Drawing.Size(47, 49);
            this.MotoristaPctBx.TabIndex = 28;
            this.MotoristaPctBx.TabStop = false;
            // 
            // usuarioPctbx
            // 
            this.usuarioPctbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuarioPctbx.BackgroundImage")));
            this.usuarioPctbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usuarioPctbx.Location = new System.Drawing.Point(3, 15);
            this.usuarioPctbx.Name = "usuarioPctbx";
            this.usuarioPctbx.Size = new System.Drawing.Size(47, 49);
            this.usuarioPctbx.TabIndex = 26;
            this.usuarioPctbx.TabStop = false;
            // 
            // BaseIniViagemPnl
            // 
            this.BaseIniViagemPnl.Location = new System.Drawing.Point(200, 48);
            this.BaseIniViagemPnl.Name = "BaseIniViagemPnl";
            this.BaseIniViagemPnl.Size = new System.Drawing.Size(597, 500);
            this.BaseIniViagemPnl.TabIndex = 28;
            // 
            // FrmBaseViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BaseIniViagemPnl);
            this.Controls.Add(this.BaseViagemMenuPnl);
            this.Controls.Add(this.BaseVendaMenuFecharPnl);
            this.Name = "FrmBaseViagem";
            this.BaseVendaMenuFecharPnl.ResumeLayout(false);
            this.BaseVendaMenuFecharPnl.PerformLayout();
            this.BaseViagemMenuPnl.ResumeLayout(false);
            this.BaseViagemMenuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotoristaPctBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPctbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BaseVendaMenuFecharPnl;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.Panel BaseViagemMenuPnl;
        private System.Windows.Forms.PictureBox MotoristaPctBx;
        private System.Windows.Forms.PictureBox usuarioPctbx;
        private System.Windows.Forms.FlowLayoutPanel BaseViagemPnl;
        private System.Windows.Forms.Label ViagemLbl;
        private System.Windows.Forms.FlowLayoutPanel BaseIniViagemPnl;
    }
}
