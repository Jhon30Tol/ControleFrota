namespace PimFrota.Formularios.TelaCadastros.CadastroCidade
{
    partial class FrmPesquisaCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaCidade));
            this.EstadoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.CidadeCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.CidadePesquisarLtvw = new System.Windows.Forms.ListView();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EstadoCkbx
            // 
            this.EstadoCkbx.AutoSize = true;
            this.EstadoCkbx.Depth = 0;
            this.EstadoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.EstadoCkbx.Location = new System.Drawing.Point(138, 46);
            this.EstadoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.EstadoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EstadoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.EstadoCkbx.Name = "EstadoCkbx";
            this.EstadoCkbx.Ripple = true;
            this.EstadoCkbx.Size = new System.Drawing.Size(72, 30);
            this.EstadoCkbx.TabIndex = 56;
            this.EstadoCkbx.Text = "Estado";
            this.EstadoCkbx.UseVisualStyleBackColor = true;
            // 
            // CidadeCkbx
            // 
            this.CidadeCkbx.AutoSize = true;
            this.CidadeCkbx.Depth = 0;
            this.CidadeCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.CidadeCkbx.Location = new System.Drawing.Point(16, 46);
            this.CidadeCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.CidadeCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CidadeCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.CidadeCkbx.Name = "CidadeCkbx";
            this.CidadeCkbx.Ripple = true;
            this.CidadeCkbx.Size = new System.Drawing.Size(73, 30);
            this.CidadeCkbx.TabIndex = 55;
            this.CidadeCkbx.Text = "Cidade";
            this.CidadeCkbx.UseVisualStyleBackColor = true;
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(222, 18);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 54;
            this.PesquisarLbl.Text = "Pesquisar";
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(173, 14);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 53;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            // 
            // CidadePesquisarLtvw
            // 
            this.CidadePesquisarLtvw.GridLines = true;
            this.CidadePesquisarLtvw.Location = new System.Drawing.Point(16, 88);
            this.CidadePesquisarLtvw.Name = "CidadePesquisarLtvw";
            this.CidadePesquisarLtvw.Size = new System.Drawing.Size(323, 127);
            this.CidadePesquisarLtvw.TabIndex = 52;
            this.CidadePesquisarLtvw.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(16, 17);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 51;
            // 
            // FrmPesquisaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.EstadoCkbx);
            this.Controls.Add(this.CidadeCkbx);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.CidadePesquisarLtvw);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisaCidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox EstadoCkbx;
        private MaterialSkin.Controls.MaterialCheckBox CidadeCkbx;
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.ListView CidadePesquisarLtvw;
        private System.Windows.Forms.TextBox PesquisarTbx;
    }
}
