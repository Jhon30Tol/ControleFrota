namespace PimFrota.Formularios.Mensagens
{
    partial class FrmMensagemCampoObrigatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMensagemCampoObrigatorio));
            this.MensagemOkBtn = new System.Windows.Forms.Button();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.MsgCampoObrigatorioLbl = new MaterialSkin.Controls.MaterialLabel();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MensagemOkBtn
            // 
            this.MensagemOkBtn.BackColor = System.Drawing.Color.Yellow;
            this.MensagemOkBtn.FlatAppearance.BorderSize = 0;
            this.MensagemOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MensagemOkBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemOkBtn.Location = new System.Drawing.Point(111, 81);
            this.MensagemOkBtn.Name = "MensagemOkBtn";
            this.MensagemOkBtn.Size = new System.Drawing.Size(75, 23);
            this.MensagemOkBtn.TabIndex = 28;
            this.MensagemOkBtn.Text = "OK";
            this.MensagemOkBtn.UseVisualStyleBackColor = false;
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.Yellow;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(298, 20);
            this.MsgFecharPnl.TabIndex = 27;
            // 
            // Fecharbtn
            // 
            this.Fecharbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecharbtn.BackColor = System.Drawing.Color.Crimson;
            this.Fecharbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fecharbtn.BackgroundImage")));
            this.Fecharbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fecharbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fecharbtn.FlatAppearance.BorderSize = 0;
            this.Fecharbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fecharbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fecharbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fecharbtn.Location = new System.Drawing.Point(276, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            // 
            // MsgCampoObrigatorioLbl
            // 
            this.MsgCampoObrigatorioLbl.AutoSize = true;
            this.MsgCampoObrigatorioLbl.Depth = 0;
            this.MsgCampoObrigatorioLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgCampoObrigatorioLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MsgCampoObrigatorioLbl.Location = new System.Drawing.Point(8, 47);
            this.MsgCampoObrigatorioLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MsgCampoObrigatorioLbl.Name = "MsgCampoObrigatorioLbl";
            this.MsgCampoObrigatorioLbl.Size = new System.Drawing.Size(287, 18);
            this.MsgCampoObrigatorioLbl.TabIndex = 26;
            this.MsgCampoObrigatorioLbl.Text = "Preencha os campos Obrigatórios.";
            // 
            // FrmMensagemCampoObrigatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(298, 116);
            this.Controls.Add(this.MensagemOkBtn);
            this.Controls.Add(this.MsgFecharPnl);
            this.Controls.Add(this.MsgCampoObrigatorioLbl);
            this.Name = "FrmMensagemCampoObrigatorio";
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MensagemOkBtn;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        private MaterialSkin.Controls.MaterialLabel MsgCampoObrigatorioLbl;
    }
}
