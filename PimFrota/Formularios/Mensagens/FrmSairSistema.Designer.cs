namespace PimFrota.Formularios.Mensagens
{
    partial class FrmSairSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSairSistema));
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SimSairSistemaBtn = new System.Windows.Forms.Button();
            this.NaoSairSistemaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MsgFecharPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.Yellow;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(298, 20);
            this.MsgFecharPnl.TabIndex = 31;
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
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Deseja mesmo sair do sistema?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SimSairSistemaBtn
            // 
            this.SimSairSistemaBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.SimSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimSairSistemaBtn.Location = new System.Drawing.Point(72, 74);
            this.SimSairSistemaBtn.Name = "SimSairSistemaBtn";
            this.SimSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.SimSairSistemaBtn.TabIndex = 33;
            this.SimSairSistemaBtn.Text = "Sim";
            this.SimSairSistemaBtn.UseVisualStyleBackColor = false;
            this.SimSairSistemaBtn.Click += new System.EventHandler(this.SimSairSistemaBtn_Click);
            // 
            // NaoSairSistemaBtn
            // 
            this.NaoSairSistemaBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.NaoSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaoSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaoSairSistemaBtn.Location = new System.Drawing.Point(153, 74);
            this.NaoSairSistemaBtn.Name = "NaoSairSistemaBtn";
            this.NaoSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.NaoSairSistemaBtn.TabIndex = 34;
            this.NaoSairSistemaBtn.Text = "Não";
            this.NaoSairSistemaBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NaoSairSistemaBtn);
            this.panel1.Controls.Add(this.SimSairSistemaBtn);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 116);
            this.panel1.TabIndex = 35;
            // 
            // FrmSairSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(298, 134);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgFecharPnl);
            this.Name = "FrmSairSistema";
            this.MsgFecharPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SimSairSistemaBtn;
        private System.Windows.Forms.Button NaoSairSistemaBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
