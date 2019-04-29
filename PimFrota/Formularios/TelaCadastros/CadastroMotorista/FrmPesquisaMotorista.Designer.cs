namespace PimFrota.Formularios.TelaCadastros.CadastroMotorista
{
    partial class FrmPesquisaMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaMotorista));
            this.CpfCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.NomeCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.MotoristaPesquisarLtvw = new System.Windows.Forms.ListView();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CpfCkbx
            // 
            this.CpfCkbx.AutoSize = true;
            this.CpfCkbx.Depth = 0;
            this.CpfCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.CpfCkbx.Location = new System.Drawing.Point(138, 46);
            this.CpfCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.CpfCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CpfCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.CpfCkbx.Name = "CpfCkbx";
            this.CpfCkbx.Ripple = true;
            this.CpfCkbx.Size = new System.Drawing.Size(55, 30);
            this.CpfCkbx.TabIndex = 44;
            this.CpfCkbx.Text = "CPF";
            this.CpfCkbx.UseVisualStyleBackColor = true;
            // 
            // NomeCkbx
            // 
            this.NomeCkbx.AutoSize = true;
            this.NomeCkbx.Depth = 0;
            this.NomeCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.NomeCkbx.Location = new System.Drawing.Point(16, 46);
            this.NomeCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.NomeCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NomeCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomeCkbx.Name = "NomeCkbx";
            this.NomeCkbx.Ripple = true;
            this.NomeCkbx.Size = new System.Drawing.Size(67, 30);
            this.NomeCkbx.TabIndex = 43;
            this.NomeCkbx.Text = "Nome";
            this.NomeCkbx.UseVisualStyleBackColor = true;
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
            this.PesquisarLbl.TabIndex = 42;
            this.PesquisarLbl.Text = "Pesquisar";
            this.PesquisarLbl.Click += new System.EventHandler(this.PesquisarLbl_Click);
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
            this.PesquisarBtn.TabIndex = 41;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // MotoristaPesquisarLtvw
            // 
            this.MotoristaPesquisarLtvw.GridLines = true;
            this.MotoristaPesquisarLtvw.Location = new System.Drawing.Point(16, 88);
            this.MotoristaPesquisarLtvw.Name = "MotoristaPesquisarLtvw";
            this.MotoristaPesquisarLtvw.Size = new System.Drawing.Size(323, 127);
            this.MotoristaPesquisarLtvw.TabIndex = 40;
            this.MotoristaPesquisarLtvw.UseCompatibleStateImageBehavior = false;
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(16, 17);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 39;
            // 
            // FrmPesquisaMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(355, 228);
            this.Controls.Add(this.CpfCkbx);
            this.Controls.Add(this.NomeCkbx);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.MotoristaPesquisarLtvw);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisaMotorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox CpfCkbx;
        private MaterialSkin.Controls.MaterialCheckBox NomeCkbx;
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.ListView MotoristaPesquisarLtvw;
        private System.Windows.Forms.TextBox PesquisarTbx;
    }
}
