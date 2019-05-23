namespace PimFrota.Formularios.TelaHome
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.EstoqueLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ViagemLbl = new MaterialSkin.Controls.MaterialLabel();
            this.AvisoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.Cadastroslbl = new MaterialSkin.Controls.MaterialLabel();
            this.EstoqueBtn = new System.Windows.Forms.Button();
            this.ViagemBtn = new System.Windows.Forms.Button();
            this.AvisoBtn = new System.Windows.Forms.Button();
            this.FinanceiroBtn = new System.Windows.Forms.Button();
            this.CadastroBtn = new System.Windows.Forms.Button();
            this.FinanceiroLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // usuarioLogadoLbl
            // 
            this.usuarioLogadoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.usuarioLogadoLbl.Size = new System.Drawing.Size(61, 19);
            this.usuarioLogadoLbl.Click += new System.EventHandler(this.usuarioLogadoLbl_Click);
            // 
            // EstoqueLbl
            // 
            this.EstoqueLbl.AutoSize = true;
            this.EstoqueLbl.Depth = 0;
            this.EstoqueLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.EstoqueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EstoqueLbl.Location = new System.Drawing.Point(656, 263);
            this.EstoqueLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.EstoqueLbl.Name = "EstoqueLbl";
            this.EstoqueLbl.Size = new System.Drawing.Size(65, 19);
            this.EstoqueLbl.TabIndex = 23;
            this.EstoqueLbl.Text = "Estoque";
            // 
            // ViagemLbl
            // 
            this.ViagemLbl.AutoSize = true;
            this.ViagemLbl.Depth = 0;
            this.ViagemLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.ViagemLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViagemLbl.Location = new System.Drawing.Point(516, 263);
            this.ViagemLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViagemLbl.Name = "ViagemLbl";
            this.ViagemLbl.Size = new System.Drawing.Size(63, 19);
            this.ViagemLbl.TabIndex = 22;
            this.ViagemLbl.Text = "Viagens";
            // 
            // AvisoLbl
            // 
            this.AvisoLbl.AutoSize = true;
            this.AvisoLbl.Depth = 0;
            this.AvisoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.AvisoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AvisoLbl.Location = new System.Drawing.Point(370, 263);
            this.AvisoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AvisoLbl.Name = "AvisoLbl";
            this.AvisoLbl.Size = new System.Drawing.Size(55, 19);
            this.AvisoLbl.TabIndex = 21;
            this.AvisoLbl.Text = "Avisos";
            // 
            // Cadastroslbl
            // 
            this.Cadastroslbl.AutoSize = true;
            this.Cadastroslbl.Depth = 0;
            this.Cadastroslbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.Cadastroslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cadastroslbl.Location = new System.Drawing.Point(75, 263);
            this.Cadastroslbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cadastroslbl.Name = "Cadastroslbl";
            this.Cadastroslbl.Size = new System.Drawing.Size(78, 19);
            this.Cadastroslbl.TabIndex = 19;
            this.Cadastroslbl.Text = "Cadastros";
            // 
            // EstoqueBtn
            // 
            this.EstoqueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstoqueBtn.AutoSize = true;
            this.EstoqueBtn.BackColor = System.Drawing.Color.Transparent;
            this.EstoqueBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EstoqueBtn.BackgroundImage")));
            this.EstoqueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EstoqueBtn.FlatAppearance.BorderSize = 0;
            this.EstoqueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstoqueBtn.Location = new System.Drawing.Point(647, 170);
            this.EstoqueBtn.Name = "EstoqueBtn";
            this.EstoqueBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EstoqueBtn.Size = new System.Drawing.Size(81, 102);
            this.EstoqueBtn.TabIndex = 18;
            this.EstoqueBtn.UseVisualStyleBackColor = false;
            this.EstoqueBtn.Click += new System.EventHandler(this.EstoqueBtn_Click);
            // 
            // ViagemBtn
            // 
            this.ViagemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViagemBtn.AutoSize = true;
            this.ViagemBtn.BackColor = System.Drawing.Color.Transparent;
            this.ViagemBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViagemBtn.BackgroundImage")));
            this.ViagemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViagemBtn.FlatAppearance.BorderSize = 0;
            this.ViagemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViagemBtn.Location = new System.Drawing.Point(504, 170);
            this.ViagemBtn.Name = "ViagemBtn";
            this.ViagemBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViagemBtn.Size = new System.Drawing.Size(79, 101);
            this.ViagemBtn.TabIndex = 17;
            this.ViagemBtn.UseVisualStyleBackColor = false;
            this.ViagemBtn.Click += new System.EventHandler(this.ViagemBtn_Click);
            // 
            // AvisoBtn
            // 
            this.AvisoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvisoBtn.AutoSize = true;
            this.AvisoBtn.BackColor = System.Drawing.Color.Transparent;
            this.AvisoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AvisoBtn.BackgroundImage")));
            this.AvisoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvisoBtn.FlatAppearance.BorderSize = 0;
            this.AvisoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvisoBtn.Location = new System.Drawing.Point(357, 168);
            this.AvisoBtn.Name = "AvisoBtn";
            this.AvisoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AvisoBtn.Size = new System.Drawing.Size(77, 102);
            this.AvisoBtn.TabIndex = 16;
            this.AvisoBtn.UseVisualStyleBackColor = false;
            this.AvisoBtn.Click += new System.EventHandler(this.AvisoBtn_Click);
            // 
            // FinanceiroBtn
            // 
            this.FinanceiroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinanceiroBtn.AutoSize = true;
            this.FinanceiroBtn.BackColor = System.Drawing.Color.Transparent;
            this.FinanceiroBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinanceiroBtn.BackgroundImage")));
            this.FinanceiroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FinanceiroBtn.FlatAppearance.BorderSize = 0;
            this.FinanceiroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinanceiroBtn.Location = new System.Drawing.Point(209, 171);
            this.FinanceiroBtn.Name = "FinanceiroBtn";
            this.FinanceiroBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinanceiroBtn.Size = new System.Drawing.Size(76, 101);
            this.FinanceiroBtn.TabIndex = 15;
            this.FinanceiroBtn.UseVisualStyleBackColor = false;
            this.FinanceiroBtn.Click += new System.EventHandler(this.FinanceiroBtn_Click);
            // 
            // CadastroBtn
            // 
            this.CadastroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CadastroBtn.AutoSize = true;
            this.CadastroBtn.BackColor = System.Drawing.Color.Transparent;
            this.CadastroBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CadastroBtn.BackgroundImage")));
            this.CadastroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CadastroBtn.FlatAppearance.BorderSize = 0;
            this.CadastroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastroBtn.Location = new System.Drawing.Point(72, 170);
            this.CadastroBtn.Name = "CadastroBtn";
            this.CadastroBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CadastroBtn.Size = new System.Drawing.Size(81, 101);
            this.CadastroBtn.TabIndex = 14;
            this.CadastroBtn.UseVisualStyleBackColor = false;
            this.CadastroBtn.Click += new System.EventHandler(this.CadastroBtn_Click);
            // 
            // FinanceiroLbl
            // 
            this.FinanceiroLbl.AutoSize = true;
            this.FinanceiroLbl.Depth = 0;
            this.FinanceiroLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.FinanceiroLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinanceiroLbl.Location = new System.Drawing.Point(207, 263);
            this.FinanceiroLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.FinanceiroLbl.Name = "FinanceiroLbl";
            this.FinanceiroLbl.Size = new System.Drawing.Size(79, 19);
            this.FinanceiroLbl.TabIndex = 24;
            this.FinanceiroLbl.Text = "Financeiro";
            this.FinanceiroLbl.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinanceiroLbl);
            this.Controls.Add(this.EstoqueLbl);
            this.Controls.Add(this.ViagemLbl);
            this.Controls.Add(this.AvisoLbl);
            this.Controls.Add(this.Cadastroslbl);
            this.Controls.Add(this.EstoqueBtn);
            this.Controls.Add(this.ViagemBtn);
            this.Controls.Add(this.AvisoBtn);
            this.Controls.Add(this.FinanceiroBtn);
            this.Controls.Add(this.CadastroBtn);
            this.Name = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Controls.SetChildIndex(this.usuarioLogadoLbl, 0);
            this.Controls.SetChildIndex(this.CadastroBtn, 0);
            this.Controls.SetChildIndex(this.FinanceiroBtn, 0);
            this.Controls.SetChildIndex(this.AvisoBtn, 0);
            this.Controls.SetChildIndex(this.ViagemBtn, 0);
            this.Controls.SetChildIndex(this.EstoqueBtn, 0);
            this.Controls.SetChildIndex(this.Cadastroslbl, 0);
            this.Controls.SetChildIndex(this.AvisoLbl, 0);
            this.Controls.SetChildIndex(this.ViagemLbl, 0);
            this.Controls.SetChildIndex(this.EstoqueLbl, 0);
            this.Controls.SetChildIndex(this.FinanceiroLbl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel EstoqueLbl;
        private MaterialSkin.Controls.MaterialLabel ViagemLbl;
        private MaterialSkin.Controls.MaterialLabel AvisoLbl;
        private MaterialSkin.Controls.MaterialLabel Cadastroslbl;
        private System.Windows.Forms.Button EstoqueBtn;
        private System.Windows.Forms.Button ViagemBtn;
        private System.Windows.Forms.Button AvisoBtn;
        private System.Windows.Forms.Button FinanceiroBtn;
        private System.Windows.Forms.Button CadastroBtn;
        private MaterialSkin.Controls.MaterialLabel FinanceiroLbl;
    }
}
