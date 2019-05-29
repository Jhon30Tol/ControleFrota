namespace PimFrota.Formularios.Base
{
    partial class FrmBaseFinanceiro
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
            MaterialSkin.Controls.MaterialFlatButton NovaVendaBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseFinanceiro));
            this.BaseFinanceiroMenuPnl = new System.Windows.Forms.Panel();
            this.BaseFinanceiroPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.ProdutoPctBx = new System.Windows.Forms.PictureBox();
            this.BaseFinanceiroMenuFecharPnl = new System.Windows.Forms.Panel();
            this.EstoquePnl = new System.Windows.Forms.FlowLayoutPanel();
            this.FinanceiroLbl = new System.Windows.Forms.Label();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.BaseFinPnl = new System.Windows.Forms.FlowLayoutPanel();
            NovaVendaBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.BaseFinanceiroMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoPctBx)).BeginInit();
            this.BaseFinanceiroMenuFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NovaVendaBtn
            // 
            NovaVendaBtn.AutoSize = true;
            NovaVendaBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            NovaVendaBtn.BackColor = System.Drawing.Color.Ivory;
            NovaVendaBtn.Depth = 0;
            NovaVendaBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            NovaVendaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NovaVendaBtn.ForeColor = System.Drawing.Color.White;
            NovaVendaBtn.Location = new System.Drawing.Point(62, 26);
            NovaVendaBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            NovaVendaBtn.MouseState = MaterialSkin.MouseState.HOVER;
            NovaVendaBtn.Name = "NovaVendaBtn";
            NovaVendaBtn.Primary = false;
            NovaVendaBtn.Size = new System.Drawing.Size(97, 36);
            NovaVendaBtn.TabIndex = 36;
            NovaVendaBtn.Text = "Nova Venda";
            NovaVendaBtn.UseVisualStyleBackColor = false;
            NovaVendaBtn.Click += new System.EventHandler(this.NovaVendaBtn_Click);
            // 
            // BaseFinanceiroMenuPnl
            // 
            this.BaseFinanceiroMenuPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseFinanceiroMenuPnl.Controls.Add(this.BaseFinanceiroPnl);
            this.BaseFinanceiroMenuPnl.Controls.Add(NovaVendaBtn);
            this.BaseFinanceiroMenuPnl.Controls.Add(this.ProdutoPctBx);
            this.BaseFinanceiroMenuPnl.Location = new System.Drawing.Point(0, 48);
            this.BaseFinanceiroMenuPnl.Name = "BaseFinanceiroMenuPnl";
            this.BaseFinanceiroMenuPnl.Size = new System.Drawing.Size(200, 555);
            this.BaseFinanceiroMenuPnl.TabIndex = 32;
            // 
            // BaseFinanceiroPnl
            // 
            this.BaseFinanceiroPnl.Location = new System.Drawing.Point(202, 6);
            this.BaseFinanceiroPnl.Name = "BaseFinanceiroPnl";
            this.BaseFinanceiroPnl.Size = new System.Drawing.Size(597, 500);
            this.BaseFinanceiroPnl.TabIndex = 33;
            // 
            // ProdutoPctBx
            // 
            this.ProdutoPctBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProdutoPctBx.BackgroundImage")));
            this.ProdutoPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProdutoPctBx.Location = new System.Drawing.Point(10, 20);
            this.ProdutoPctBx.Name = "ProdutoPctBx";
            this.ProdutoPctBx.Size = new System.Drawing.Size(47, 49);
            this.ProdutoPctBx.TabIndex = 35;
            this.ProdutoPctBx.TabStop = false;
            // 
            // BaseFinanceiroMenuFecharPnl
            // 
            this.BaseFinanceiroMenuFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseFinanceiroMenuFecharPnl.Controls.Add(this.EstoquePnl);
            this.BaseFinanceiroMenuFecharPnl.Controls.Add(this.FinanceiroLbl);
            this.BaseFinanceiroMenuFecharPnl.Controls.Add(this.Fecharbtn);
            this.BaseFinanceiroMenuFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseFinanceiroMenuFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.BaseFinanceiroMenuFecharPnl.Name = "BaseFinanceiroMenuFecharPnl";
            this.BaseFinanceiroMenuFecharPnl.Size = new System.Drawing.Size(800, 48);
            this.BaseFinanceiroMenuFecharPnl.TabIndex = 31;
            // 
            // EstoquePnl
            // 
            this.EstoquePnl.Location = new System.Drawing.Point(202, 48);
            this.EstoquePnl.Name = "EstoquePnl";
            this.EstoquePnl.Size = new System.Drawing.Size(597, 500);
            this.EstoquePnl.TabIndex = 28;
            // 
            // FinanceiroLbl
            // 
            this.FinanceiroLbl.AutoSize = true;
            this.FinanceiroLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceiroLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinanceiroLbl.Location = new System.Drawing.Point(5, 7);
            this.FinanceiroLbl.Name = "FinanceiroLbl";
            this.FinanceiroLbl.Size = new System.Drawing.Size(163, 25);
            this.FinanceiroLbl.TabIndex = 30;
            this.FinanceiroLbl.Text = "FINANCEIRO";
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
            this.Fecharbtn.Location = new System.Drawing.Point(768, 11);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(25, 25);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // BaseFinPnl
            // 
            this.BaseFinPnl.Location = new System.Drawing.Point(202, 48);
            this.BaseFinPnl.Name = "BaseFinPnl";
            this.BaseFinPnl.Size = new System.Drawing.Size(597, 500);
            this.BaseFinPnl.TabIndex = 33;
            // 
            // FrmBaseFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BaseFinPnl);
            this.Controls.Add(this.BaseFinanceiroMenuPnl);
            this.Controls.Add(this.BaseFinanceiroMenuFecharPnl);
            this.Name = "FrmBaseFinanceiro";
            this.BaseFinanceiroMenuPnl.ResumeLayout(false);
            this.BaseFinanceiroMenuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoPctBx)).EndInit();
            this.BaseFinanceiroMenuFecharPnl.ResumeLayout(false);
            this.BaseFinanceiroMenuFecharPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BaseFinanceiroMenuPnl;
        private System.Windows.Forms.PictureBox ProdutoPctBx;
        private System.Windows.Forms.Panel BaseFinanceiroMenuFecharPnl;
        private System.Windows.Forms.FlowLayoutPanel EstoquePnl;
        private System.Windows.Forms.Label FinanceiroLbl;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.FlowLayoutPanel BaseFinanceiroPnl;
        private System.Windows.Forms.FlowLayoutPanel BaseFinPnl;
    }
}
