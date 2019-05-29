namespace PimFrota.Formularios.Base
{
    partial class FrmBaseEstoque
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
            MaterialSkin.Controls.MaterialFlatButton ServicoBtn;
            MaterialSkin.Controls.MaterialFlatButton ProdutoBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseEstoque));
            this.BaseEstoquePnl = new System.Windows.Forms.FlowLayoutPanel();
            this.BaseCadastroMenuPnl = new System.Windows.Forms.Panel();
            this.ServicoPctBx = new System.Windows.Forms.PictureBox();
            this.ProdutoPctBx = new System.Windows.Forms.PictureBox();
            this.BaseCadastroMenuFecharPnl = new System.Windows.Forms.Panel();
            this.EstoquePnl = new System.Windows.Forms.FlowLayoutPanel();
            this.EstoqueLbl = new System.Windows.Forms.Label();
            this.Fecharbtn = new System.Windows.Forms.Button();
            ServicoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            ProdutoBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.BaseCadastroMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoPctBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoPctBx)).BeginInit();
            this.BaseCadastroMenuFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServicoBtn
            // 
            ServicoBtn.AutoSize = true;
            ServicoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ServicoBtn.BackColor = System.Drawing.Color.Ivory;
            ServicoBtn.Depth = 0;
            ServicoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            ServicoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ServicoBtn.ForeColor = System.Drawing.Color.White;
            ServicoBtn.Location = new System.Drawing.Point(62, 77);
            ServicoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ServicoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ServicoBtn.Name = "ServicoBtn";
            ServicoBtn.Primary = false;
            ServicoBtn.Size = new System.Drawing.Size(68, 36);
            ServicoBtn.TabIndex = 38;
            ServicoBtn.Text = "Serviço";
            ServicoBtn.UseVisualStyleBackColor = false;
            ServicoBtn.Click += new System.EventHandler(this.ServicoBtn_Click_1);
            // 
            // ProdutoBtn
            // 
            ProdutoBtn.AutoSize = true;
            ProdutoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ProdutoBtn.BackColor = System.Drawing.Color.Ivory;
            ProdutoBtn.Depth = 0;
            ProdutoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            ProdutoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ProdutoBtn.ForeColor = System.Drawing.Color.White;
            ProdutoBtn.Location = new System.Drawing.Point(62, 21);
            ProdutoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            ProdutoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ProdutoBtn.Name = "ProdutoBtn";
            ProdutoBtn.Primary = false;
            ProdutoBtn.Size = new System.Drawing.Size(75, 36);
            ProdutoBtn.TabIndex = 36;
            ProdutoBtn.Text = "Produto";
            ProdutoBtn.UseVisualStyleBackColor = false;
            ProdutoBtn.Click += new System.EventHandler(this.ProdutoBtn_Click);
            // 
            // BaseEstoquePnl
            // 
            this.BaseEstoquePnl.Location = new System.Drawing.Point(201, 44);
            this.BaseEstoquePnl.Name = "BaseEstoquePnl";
            this.BaseEstoquePnl.Size = new System.Drawing.Size(597, 500);
            this.BaseEstoquePnl.TabIndex = 31;
            this.BaseEstoquePnl.Paint += new System.Windows.Forms.PaintEventHandler(this.BaseEstoquePnl_Paint);
            // 
            // BaseCadastroMenuPnl
            // 
            this.BaseCadastroMenuPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseCadastroMenuPnl.Controls.Add(ServicoBtn);
            this.BaseCadastroMenuPnl.Controls.Add(this.ServicoPctBx);
            this.BaseCadastroMenuPnl.Controls.Add(ProdutoBtn);
            this.BaseCadastroMenuPnl.Controls.Add(this.ProdutoPctBx);
            this.BaseCadastroMenuPnl.Location = new System.Drawing.Point(0, 44);
            this.BaseCadastroMenuPnl.Name = "BaseCadastroMenuPnl";
            this.BaseCadastroMenuPnl.Size = new System.Drawing.Size(200, 561);
            this.BaseCadastroMenuPnl.TabIndex = 30;
            // 
            // ServicoPctBx
            // 
            this.ServicoPctBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ServicoPctBx.BackgroundImage")));
            this.ServicoPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ServicoPctBx.Location = new System.Drawing.Point(10, 70);
            this.ServicoPctBx.Name = "ServicoPctBx";
            this.ServicoPctBx.Size = new System.Drawing.Size(47, 49);
            this.ServicoPctBx.TabIndex = 37;
            this.ServicoPctBx.TabStop = false;
            // 
            // ProdutoPctBx
            // 
            this.ProdutoPctBx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProdutoPctBx.BackgroundImage")));
            this.ProdutoPctBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProdutoPctBx.Location = new System.Drawing.Point(10, 15);
            this.ProdutoPctBx.Name = "ProdutoPctBx";
            this.ProdutoPctBx.Size = new System.Drawing.Size(47, 49);
            this.ProdutoPctBx.TabIndex = 35;
            this.ProdutoPctBx.TabStop = false;
            // 
            // BaseCadastroMenuFecharPnl
            // 
            this.BaseCadastroMenuFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BaseCadastroMenuFecharPnl.Controls.Add(this.EstoquePnl);
            this.BaseCadastroMenuFecharPnl.Controls.Add(this.EstoqueLbl);
            this.BaseCadastroMenuFecharPnl.Controls.Add(this.Fecharbtn);
            this.BaseCadastroMenuFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaseCadastroMenuFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.BaseCadastroMenuFecharPnl.Name = "BaseCadastroMenuFecharPnl";
            this.BaseCadastroMenuFecharPnl.Size = new System.Drawing.Size(800, 48);
            this.BaseCadastroMenuFecharPnl.TabIndex = 29;
            // 
            // EstoquePnl
            // 
            this.EstoquePnl.Location = new System.Drawing.Point(202, 48);
            this.EstoquePnl.Name = "EstoquePnl";
            this.EstoquePnl.Size = new System.Drawing.Size(597, 500);
            this.EstoquePnl.TabIndex = 28;
            // 
            // EstoqueLbl
            // 
            this.EstoqueLbl.AutoSize = true;
            this.EstoqueLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstoqueLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EstoqueLbl.Location = new System.Drawing.Point(5, 7);
            this.EstoqueLbl.Name = "EstoqueLbl";
            this.EstoqueLbl.Size = new System.Drawing.Size(122, 25);
            this.EstoqueLbl.TabIndex = 30;
            this.EstoqueLbl.Text = "ESTOQUE";
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
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click_1);
            // 
            // FrmBaseEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BaseEstoquePnl);
            this.Controls.Add(this.BaseCadastroMenuPnl);
            this.Controls.Add(this.BaseCadastroMenuFecharPnl);
            this.Name = "FrmBaseEstoque";
            this.BaseCadastroMenuPnl.ResumeLayout(false);
            this.BaseCadastroMenuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicoPctBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoPctBx)).EndInit();
            this.BaseCadastroMenuFecharPnl.ResumeLayout(false);
            this.BaseCadastroMenuFecharPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BaseEstoquePnl;
        private System.Windows.Forms.Panel BaseCadastroMenuPnl;
        private System.Windows.Forms.PictureBox ServicoPctBx;
        private System.Windows.Forms.PictureBox ProdutoPctBx;
        private System.Windows.Forms.Panel BaseCadastroMenuFecharPnl;
        private System.Windows.Forms.FlowLayoutPanel EstoquePnl;
        private System.Windows.Forms.Label EstoqueLbl;
        private System.Windows.Forms.Button Fecharbtn;
    }
}
