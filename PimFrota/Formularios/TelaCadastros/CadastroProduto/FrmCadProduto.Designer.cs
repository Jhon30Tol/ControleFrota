namespace PimFrota.Formularios.TelaCadastros.CadastroProduto
{
    partial class FrmCadProduto
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
            this.CodProdutoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.CodProdutoTxb = new System.Windows.Forms.TextBox();
            this.TipProdutoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.TipoProdCbx = new System.Windows.Forms.ComboBox();
            this.NomeProdLbl = new MaterialSkin.Controls.MaterialLabel();
            this.MarcaProdLbl = new MaterialSkin.Controls.MaterialLabel();
            this.FabricanteProdLbl = new MaterialSkin.Controls.MaterialLabel();
            this.ValorProdLbl = new MaterialSkin.Controls.MaterialLabel();
            this.NomeProdutoTxb = new System.Windows.Forms.TextBox();
            this.MarcaProdTbx = new System.Windows.Forms.TextBox();
            this.FabricanteProdTbx = new System.Windows.Forms.TextBox();
            this.ValorProdTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodProdutoLbl
            // 
            this.CodProdutoLbl.AutoSize = true;
            this.CodProdutoLbl.Depth = 0;
            this.CodProdutoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.CodProdutoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodProdutoLbl.Location = new System.Drawing.Point(3, 9);
            this.CodProdutoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.CodProdutoLbl.Name = "CodProdutoLbl";
            this.CodProdutoLbl.Size = new System.Drawing.Size(62, 18);
            this.CodProdutoLbl.TabIndex = 0;
            this.CodProdutoLbl.Text = "Código";
            // 
            // CodProdutoTxb
            // 
            this.CodProdutoTxb.Location = new System.Drawing.Point(97, 10);
            this.CodProdutoTxb.Name = "CodProdutoTxb";
            this.CodProdutoTxb.Size = new System.Drawing.Size(100, 20);
            this.CodProdutoTxb.TabIndex = 1;
            this.CodProdutoTxb.TextChanged += new System.EventHandler(this.CodProdutoTxb_TextChanged);
            // 
            // TipProdutoLbl
            // 
            this.TipProdutoLbl.AutoSize = true;
            this.TipProdutoLbl.Depth = 0;
            this.TipProdutoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.TipProdutoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TipProdutoLbl.Location = new System.Drawing.Point(3, 36);
            this.TipProdutoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TipProdutoLbl.Name = "TipProdutoLbl";
            this.TipProdutoLbl.Size = new System.Drawing.Size(41, 18);
            this.TipProdutoLbl.TabIndex = 2;
            this.TipProdutoLbl.Text = "Tipo";
            // 
            // TipoProdCbx
            // 
            this.TipoProdCbx.FormattingEnabled = true;
            this.TipoProdCbx.Location = new System.Drawing.Point(97, 36);
            this.TipoProdCbx.Name = "TipoProdCbx";
            this.TipoProdCbx.Size = new System.Drawing.Size(121, 21);
            this.TipoProdCbx.TabIndex = 3;
            this.TipoProdCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NomeProdLbl
            // 
            this.NomeProdLbl.AutoSize = true;
            this.NomeProdLbl.Depth = 0;
            this.NomeProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.NomeProdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NomeProdLbl.Location = new System.Drawing.Point(2, 63);
            this.NomeProdLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomeProdLbl.Name = "NomeProdLbl";
            this.NomeProdLbl.Size = new System.Drawing.Size(53, 18);
            this.NomeProdLbl.TabIndex = 4;
            this.NomeProdLbl.Text = "Nome";
            // 
            // MarcaProdLbl
            // 
            this.MarcaProdLbl.AutoSize = true;
            this.MarcaProdLbl.Depth = 0;
            this.MarcaProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.MarcaProdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarcaProdLbl.Location = new System.Drawing.Point(2, 89);
            this.MarcaProdLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MarcaProdLbl.Name = "MarcaProdLbl";
            this.MarcaProdLbl.Size = new System.Drawing.Size(55, 18);
            this.MarcaProdLbl.TabIndex = 5;
            this.MarcaProdLbl.Text = "Marca";
            // 
            // FabricanteProdLbl
            // 
            this.FabricanteProdLbl.AutoSize = true;
            this.FabricanteProdLbl.Depth = 0;
            this.FabricanteProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.FabricanteProdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FabricanteProdLbl.Location = new System.Drawing.Point(2, 115);
            this.FabricanteProdLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.FabricanteProdLbl.Name = "FabricanteProdLbl";
            this.FabricanteProdLbl.Size = new System.Drawing.Size(87, 18);
            this.FabricanteProdLbl.TabIndex = 6;
            this.FabricanteProdLbl.Text = "Fabricante";
            // 
            // ValorProdLbl
            // 
            this.ValorProdLbl.AutoSize = true;
            this.ValorProdLbl.Depth = 0;
            this.ValorProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.ValorProdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValorProdLbl.Location = new System.Drawing.Point(2, 141);
            this.ValorProdLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ValorProdLbl.Name = "ValorProdLbl";
            this.ValorProdLbl.Size = new System.Drawing.Size(47, 18);
            this.ValorProdLbl.TabIndex = 7;
            this.ValorProdLbl.Text = "Valor";
            // 
            // NomeProdutoTxb
            // 
            this.NomeProdutoTxb.Location = new System.Drawing.Point(97, 63);
            this.NomeProdutoTxb.Name = "NomeProdutoTxb";
            this.NomeProdutoTxb.Size = new System.Drawing.Size(215, 20);
            this.NomeProdutoTxb.TabIndex = 8;
            this.NomeProdutoTxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MarcaProdTbx
            // 
            this.MarcaProdTbx.Location = new System.Drawing.Point(97, 89);
            this.MarcaProdTbx.Name = "MarcaProdTbx";
            this.MarcaProdTbx.Size = new System.Drawing.Size(215, 20);
            this.MarcaProdTbx.TabIndex = 9;
            this.MarcaProdTbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FabricanteProdTbx
            // 
            this.FabricanteProdTbx.Location = new System.Drawing.Point(97, 115);
            this.FabricanteProdTbx.Name = "FabricanteProdTbx";
            this.FabricanteProdTbx.Size = new System.Drawing.Size(215, 20);
            this.FabricanteProdTbx.TabIndex = 10;
            this.FabricanteProdTbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ValorProdTbx
            // 
            this.ValorProdTbx.Location = new System.Drawing.Point(97, 141);
            this.ValorProdTbx.Name = "ValorProdTbx";
            this.ValorProdTbx.Size = new System.Drawing.Size(100, 20);
            this.ValorProdTbx.TabIndex = 11;
            this.ValorProdTbx.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(353, 192);
            this.Controls.Add(this.ValorProdTbx);
            this.Controls.Add(this.FabricanteProdTbx);
            this.Controls.Add(this.MarcaProdTbx);
            this.Controls.Add(this.NomeProdutoTxb);
            this.Controls.Add(this.ValorProdLbl);
            this.Controls.Add(this.FabricanteProdLbl);
            this.Controls.Add(this.MarcaProdLbl);
            this.Controls.Add(this.NomeProdLbl);
            this.Controls.Add(this.TipoProdCbx);
            this.Controls.Add(this.TipProdutoLbl);
            this.Controls.Add(this.CodProdutoTxb);
            this.Controls.Add(this.CodProdutoLbl);
            this.Name = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel CodProdutoLbl;
        private System.Windows.Forms.TextBox CodProdutoTxb;
        private MaterialSkin.Controls.MaterialLabel TipProdutoLbl;
        private System.Windows.Forms.ComboBox TipoProdCbx;
        private MaterialSkin.Controls.MaterialLabel NomeProdLbl;
        private MaterialSkin.Controls.MaterialLabel MarcaProdLbl;
        private MaterialSkin.Controls.MaterialLabel FabricanteProdLbl;
        private MaterialSkin.Controls.MaterialLabel ValorProdLbl;
        private System.Windows.Forms.TextBox NomeProdutoTxb;
        private System.Windows.Forms.TextBox MarcaProdTbx;
        private System.Windows.Forms.TextBox FabricanteProdTbx;
        private System.Windows.Forms.TextBox ValorProdTbx;
    }
}
