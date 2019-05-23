namespace PimFrota.Formularios.Mensagens
{
    partial class FrmMsgSimNao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsgSimNao));
            this.SairSistemaPnl = new System.Windows.Forms.Panel();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.msgSairSistemaLbl = new System.Windows.Forms.Label();
            this.NaoSairSistemaBtn = new System.Windows.Forms.Button();
            this.SimSairSistemaBtn = new System.Windows.Forms.Button();
            this.SairSistemaPnl.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SairSistemaPnl
            // 
            this.SairSistemaPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SairSistemaPnl.Controls.Add(this.MsgFecharPnl);
            this.SairSistemaPnl.Controls.Add(this.msgSairSistemaLbl);
            this.SairSistemaPnl.Controls.Add(this.NaoSairSistemaBtn);
            this.SairSistemaPnl.Controls.Add(this.SimSairSistemaBtn);
            this.SairSistemaPnl.Location = new System.Drawing.Point(0, 0);
            this.SairSistemaPnl.Name = "SairSistemaPnl";
            this.SairSistemaPnl.Size = new System.Drawing.Size(298, 134);
            this.SairSistemaPnl.TabIndex = 36;
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(296, 20);
            this.MsgFecharPnl.TabIndex = 35;
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
            this.Fecharbtn.Location = new System.Drawing.Point(274, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(19, 15);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            // 
            // msgSairSistemaLbl
            // 
            this.msgSairSistemaLbl.AutoSize = true;
            this.msgSairSistemaLbl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgSairSistemaLbl.Location = new System.Drawing.Point(58, 50);
            this.msgSairSistemaLbl.Name = "msgSairSistemaLbl";
            this.msgSairSistemaLbl.Size = new System.Drawing.Size(181, 16);
            this.msgSairSistemaLbl.TabIndex = 32;
            this.msgSairSistemaLbl.Text = "Deseja mesmo Excluir ?";
            this.msgSairSistemaLbl.Resize += new System.EventHandler(this.msgSairSistemaLbl_Resize);
            // 
            // NaoSairSistemaBtn
            // 
            this.NaoSairSistemaBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.NaoSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaoSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaoSairSistemaBtn.Location = new System.Drawing.Point(153, 101);
            this.NaoSairSistemaBtn.Name = "NaoSairSistemaBtn";
            this.NaoSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.NaoSairSistemaBtn.TabIndex = 34;
            this.NaoSairSistemaBtn.Text = "Não";
            this.NaoSairSistemaBtn.UseVisualStyleBackColor = false;
            this.NaoSairSistemaBtn.Click += new System.EventHandler(this.NaoSairSistemaBtn_Click);
            this.NaoSairSistemaBtn.Resize += new System.EventHandler(this.NaoSairSistemaBtn_Resize);
            // 
            // SimSairSistemaBtn
            // 
            this.SimSairSistemaBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.SimSairSistemaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimSairSistemaBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimSairSistemaBtn.Location = new System.Drawing.Point(72, 101);
            this.SimSairSistemaBtn.Name = "SimSairSistemaBtn";
            this.SimSairSistemaBtn.Size = new System.Drawing.Size(75, 23);
            this.SimSairSistemaBtn.TabIndex = 33;
            this.SimSairSistemaBtn.Text = "Sim";
            this.SimSairSistemaBtn.UseVisualStyleBackColor = false;
            this.SimSairSistemaBtn.Click += new System.EventHandler(this.SimSairSistemaBtn_Click);
            // 
            // FrmMsgSimNao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 134);
            this.Controls.Add(this.SairSistemaPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMsgSimNao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMsgSimNao";
            this.SairSistemaPnl.ResumeLayout(false);
            this.SairSistemaPnl.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SairSistemaPnl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        public System.Windows.Forms.Label msgSairSistemaLbl;
        public System.Windows.Forms.Button NaoSairSistemaBtn;
        public System.Windows.Forms.Button SimSairSistemaBtn;
    }
}