namespace PimFrota.Formularios.TelaCadastros.CadastroSeguro
{
    partial class FrmPesquisarSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarSeguro));
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.SeguroPesquisarLtvw = new System.Windows.Forms.ListView();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.CorretorCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.AsseguradoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(220, 19);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 29;
            this.PesquisarLbl.Text = "Pesquisar";
            this.PesquisarLbl.Click += new System.EventHandler(this.PesquisarLbl_Click);
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(171, 15);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 28;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // SeguroPesquisarLtvw
            // 
            this.SeguroPesquisarLtvw.GridLines = true;
            this.SeguroPesquisarLtvw.Location = new System.Drawing.Point(14, 89);
            this.SeguroPesquisarLtvw.Name = "SeguroPesquisarLtvw";
            this.SeguroPesquisarLtvw.Size = new System.Drawing.Size(323, 127);
            this.SeguroPesquisarLtvw.TabIndex = 27;
            this.SeguroPesquisarLtvw.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(14, 18);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 26;
            // 
            // CorretorCkbx
            // 
            this.CorretorCkbx.AutoSize = true;
            this.CorretorCkbx.Depth = 0;
            this.CorretorCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.CorretorCkbx.Location = new System.Drawing.Point(157, 47);
            this.CorretorCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.CorretorCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CorretorCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.CorretorCkbx.Name = "CorretorCkbx";
            this.CorretorCkbx.Ripple = true;
            this.CorretorCkbx.Size = new System.Drawing.Size(81, 30);
            this.CorretorCkbx.TabIndex = 31;
            this.CorretorCkbx.Text = "Corretor";
            this.CorretorCkbx.UseVisualStyleBackColor = true;
            // 
            // AsseguradoCkbx
            // 
            this.AsseguradoCkbx.AutoSize = true;
            this.AsseguradoCkbx.Depth = 0;
            this.AsseguradoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.AsseguradoCkbx.Location = new System.Drawing.Point(14, 47);
            this.AsseguradoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.AsseguradoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AsseguradoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AsseguradoCkbx.Name = "AsseguradoCkbx";
            this.AsseguradoCkbx.Ripple = true;
            this.AsseguradoCkbx.Size = new System.Drawing.Size(104, 30);
            this.AsseguradoCkbx.TabIndex = 30;
            this.AsseguradoCkbx.Text = "Assegurado";
            this.AsseguradoCkbx.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisarSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.CorretorCkbx);
            this.Controls.Add(this.AsseguradoCkbx);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.SeguroPesquisarLtvw);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisarSeguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.ListView SeguroPesquisarLtvw;
        private System.Windows.Forms.TextBox PesquisarTbx;
        private MaterialSkin.Controls.MaterialCheckBox CorretorCkbx;
        private MaterialSkin.Controls.MaterialCheckBox AsseguradoCkbx;
    }
}
