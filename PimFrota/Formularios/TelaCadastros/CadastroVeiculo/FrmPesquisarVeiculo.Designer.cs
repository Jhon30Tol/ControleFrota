namespace PimFrota.Formularios.TelaCadastros.CadastroVeiculo
{
    partial class FrmPesquisarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarVeiculo));
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.AnoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.MarcaCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.CodigoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.VeiculoPesquisarLtvw = new System.Windows.Forms.ListView();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.PlacaCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(228, 13);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 16;
            this.PesquisarLbl.Text = "Pesquisar";
            this.PesquisarLbl.Click += new System.EventHandler(this.PesquisarLbl_Click);
            // 
            // AnoCkbx
            // 
            this.AnoCkbx.AutoSize = true;
            this.AnoCkbx.Depth = 0;
            this.AnoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.AnoCkbx.Location = new System.Drawing.Point(125, 37);
            this.AnoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.AnoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AnoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnoCkbx.Name = "AnoCkbx";
            this.AnoCkbx.Ripple = true;
            this.AnoCkbx.Size = new System.Drawing.Size(55, 30);
            this.AnoCkbx.TabIndex = 15;
            this.AnoCkbx.Text = "Ano";
            this.AnoCkbx.UseVisualStyleBackColor = true;
            // 
            // MarcaCkbx
            // 
            this.MarcaCkbx.AutoSize = true;
            this.MarcaCkbx.Depth = 0;
            this.MarcaCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.MarcaCkbx.Location = new System.Drawing.Point(19, 67);
            this.MarcaCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.MarcaCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MarcaCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.MarcaCkbx.Name = "MarcaCkbx";
            this.MarcaCkbx.Ripple = true;
            this.MarcaCkbx.Size = new System.Drawing.Size(69, 30);
            this.MarcaCkbx.TabIndex = 14;
            this.MarcaCkbx.Text = "Marca";
            this.MarcaCkbx.UseVisualStyleBackColor = true;
            // 
            // CodigoCkbx
            // 
            this.CodigoCkbx.AutoSize = true;
            this.CodigoCkbx.Depth = 0;
            this.CodigoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.CodigoCkbx.Location = new System.Drawing.Point(19, 37);
            this.CodigoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.CodigoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CodigoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.CodigoCkbx.Name = "CodigoCkbx";
            this.CodigoCkbx.Ripple = true;
            this.CodigoCkbx.Size = new System.Drawing.Size(74, 30);
            this.CodigoCkbx.TabIndex = 13;
            this.CodigoCkbx.Text = "Código";
            this.CodigoCkbx.UseVisualStyleBackColor = true;
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(179, 9);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 12;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // VeiculoPesquisarLtvw
            // 
            this.VeiculoPesquisarLtvw.GridLines = true;
            this.VeiculoPesquisarLtvw.Location = new System.Drawing.Point(19, 110);
            this.VeiculoPesquisarLtvw.Name = "VeiculoPesquisarLtvw";
            this.VeiculoPesquisarLtvw.Size = new System.Drawing.Size(323, 97);
            this.VeiculoPesquisarLtvw.TabIndex = 11;
            this.VeiculoPesquisarLtvw.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(22, 12);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 10;
            // 
            // PlacaCkbx
            // 
            this.PlacaCkbx.AutoSize = true;
            this.PlacaCkbx.Depth = 0;
            this.PlacaCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.PlacaCkbx.Location = new System.Drawing.Point(125, 67);
            this.PlacaCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.PlacaCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PlacaCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlacaCkbx.Name = "PlacaCkbx";
            this.PlacaCkbx.Ripple = true;
            this.PlacaCkbx.Size = new System.Drawing.Size(64, 30);
            this.PlacaCkbx.TabIndex = 17;
            this.PlacaCkbx.Text = "Placa";
            this.PlacaCkbx.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.PlacaCkbx);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.AnoCkbx);
            this.Controls.Add(this.MarcaCkbx);
            this.Controls.Add(this.CodigoCkbx);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.VeiculoPesquisarLtvw);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private MaterialSkin.Controls.MaterialCheckBox AnoCkbx;
        private MaterialSkin.Controls.MaterialCheckBox MarcaCkbx;
        private MaterialSkin.Controls.MaterialCheckBox CodigoCkbx;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.ListView VeiculoPesquisarLtvw;
        private System.Windows.Forms.TextBox PesquisarTbx;
        private MaterialSkin.Controls.MaterialCheckBox PlacaCkbx;
    }
}
