namespace PimFrota.Formularios.TelaCadastros.CadastroServico
{
    partial class FrmPesquisarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarServico));
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.ServicoPesquisarLtvw = new System.Windows.Forms.ListView();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.NomeServicoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(223, 41);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 24;
            this.PesquisarLbl.Text = "Pesquisar";
            this.PesquisarLbl.Click += new System.EventHandler(this.PesquisarLbl_Click);
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(174, 37);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 20;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // ServicoPesquisarLtvw
            // 
            this.ServicoPesquisarLtvw.GridLines = true;
            this.ServicoPesquisarLtvw.Location = new System.Drawing.Point(19, 75);
            this.ServicoPesquisarLtvw.Name = "ServicoPesquisarLtvw";
            this.ServicoPesquisarLtvw.Size = new System.Drawing.Size(323, 141);
            this.ServicoPesquisarLtvw.TabIndex = 19;
            this.ServicoPesquisarLtvw.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(17, 40);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 18;
            // 
            // NomeServicoLbl
            // 
            this.NomeServicoLbl.AutoSize = true;
            this.NomeServicoLbl.Depth = 0;
            this.NomeServicoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.NomeServicoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NomeServicoLbl.Location = new System.Drawing.Point(15, 9);
            this.NomeServicoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomeServicoLbl.Name = "NomeServicoLbl";
            this.NomeServicoLbl.Size = new System.Drawing.Size(104, 19);
            this.NomeServicoLbl.TabIndex = 25;
            this.NomeServicoLbl.Text = "Nome Serviço";
            // 
            // FrmPesquisarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.NomeServicoLbl);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.ServicoPesquisarLtvw);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.ListView ServicoPesquisarLtvw;
        private System.Windows.Forms.TextBox PesquisarTbx;
        private MaterialSkin.Controls.MaterialLabel NomeServicoLbl;
    }
}
