namespace PimFrota.Formularios.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BemVindoLbl = new System.Windows.Forms.Label();
            this.Entrarbtn = new System.Windows.Forms.Button();
            this.Senhalbl = new System.Windows.Forms.Label();
            this.Senhatxb = new System.Windows.Forms.TextBox();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.Usuariotxb = new System.Windows.Forms.TextBox();
            this.LoginPnl = new System.Windows.Forms.Panel();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPnl.SuspendLayout();
            this.MsgFecharPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BemVindoLbl
            // 
            this.BemVindoLbl.AutoSize = true;
            this.BemVindoLbl.BackColor = System.Drawing.Color.Transparent;
            this.BemVindoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoLbl.Location = new System.Drawing.Point(7, 49);
            this.BemVindoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BemVindoLbl.Name = "BemVindoLbl";
            this.BemVindoLbl.Size = new System.Drawing.Size(93, 20);
            this.BemVindoLbl.TabIndex = 12;
            this.BemVindoLbl.Text = "Bem-vindo";
            // 
            // Entrarbtn
            // 
            this.Entrarbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Entrarbtn.FlatAppearance.BorderSize = 0;
            this.Entrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Entrarbtn.Location = new System.Drawing.Point(187, 198);
            this.Entrarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Size = new System.Drawing.Size(160, 33);
            this.Entrarbtn.TabIndex = 11;
            this.Entrarbtn.Text = "Entrar";
            this.Entrarbtn.UseVisualStyleBackColor = false;
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            this.Entrarbtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entrarbtn_Click);
            this.Entrarbtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Entrarbtn_Click);
            // 
            // Senhalbl
            // 
            this.Senhalbl.AutoSize = true;
            this.Senhalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senhalbl.Location = new System.Drawing.Point(182, 123);
            this.Senhalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senhalbl.Name = "Senhalbl";
            this.Senhalbl.Size = new System.Drawing.Size(61, 20);
            this.Senhalbl.TabIndex = 9;
            this.Senhalbl.Text = "Senha";
            // 
            // Senhatxb
            // 
            this.Senhatxb.BackColor = System.Drawing.SystemColors.Window;
            this.Senhatxb.Location = new System.Drawing.Point(187, 152);
            this.Senhatxb.Margin = new System.Windows.Forms.Padding(4);
            this.Senhatxb.Name = "Senhatxb";
            this.Senhatxb.PasswordChar = '*';
            this.Senhatxb.Size = new System.Drawing.Size(171, 20);
            this.Senhatxb.TabIndex = 10;
            this.Senhatxb.TextChanged += new System.EventHandler(this.Senhatxb_KeyDown);
            this.Senhatxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Senhatxb_KeyUp);
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolbl.Location = new System.Drawing.Point(182, 54);
            this.Usuariolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(71, 20);
            this.Usuariolbl.TabIndex = 7;
            this.Usuariolbl.Text = "Usuário";
            // 
            // Usuariotxb
            // 
            this.Usuariotxb.Location = new System.Drawing.Point(187, 83);
            this.Usuariotxb.Margin = new System.Windows.Forms.Padding(4);
            this.Usuariotxb.Name = "Usuariotxb";
            this.Usuariotxb.Size = new System.Drawing.Size(171, 20);
            this.Usuariotxb.TabIndex = 8;
            this.Usuariotxb.Validating += new System.ComponentModel.CancelEventHandler(this.Usuariotxb_Validating);
            // 
            // LoginPnl
            // 
            this.LoginPnl.Controls.Add(this.pictureBox1);
            this.LoginPnl.Controls.Add(this.MsgFecharPnl);
            this.LoginPnl.Controls.Add(this.Entrarbtn);
            this.LoginPnl.Controls.Add(this.Usuariotxb);
            this.LoginPnl.Controls.Add(this.BemVindoLbl);
            this.LoginPnl.Controls.Add(this.Usuariolbl);
            this.LoginPnl.Controls.Add(this.Senhatxb);
            this.LoginPnl.Controls.Add(this.Senhalbl);
            this.LoginPnl.Location = new System.Drawing.Point(0, 0);
            this.LoginPnl.Name = "LoginPnl";
            this.LoginPnl.Size = new System.Drawing.Size(365, 256);
            this.LoginPnl.TabIndex = 14;
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(365, 30);
            this.MsgFecharPnl.TabIndex = 27;
            // 
            // Fecharbtn
            // 
            this.Fecharbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecharbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.Fecharbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fecharbtn.BackgroundImage")));
            this.Fecharbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fecharbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fecharbtn.FlatAppearance.BorderSize = 0;
            this.Fecharbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fecharbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fecharbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fecharbtn.Location = new System.Drawing.Point(331, 3);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(31, 24);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 82);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.LoginPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyUp);
            this.LoginPnl.ResumeLayout(false);
            this.LoginPnl.PerformLayout();
            this.MsgFecharPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BemVindoLbl;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.Label Senhalbl;
        private System.Windows.Forms.Label Usuariolbl;
        public System.Windows.Forms.TextBox Senhatxb;
        public System.Windows.Forms.TextBox Usuariotxb;
        private System.Windows.Forms.Panel LoginPnl;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}