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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MsgFecharPnl = new System.Windows.Forms.Panel();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MsgFecharPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BemVindoLbl
            // 
            this.BemVindoLbl.AutoSize = true;
            this.BemVindoLbl.BackColor = System.Drawing.Color.Transparent;
            this.BemVindoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoLbl.Location = new System.Drawing.Point(8, 49);
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
            this.Entrarbtn.Location = new System.Drawing.Point(188, 198);
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
            this.Senhalbl.Location = new System.Drawing.Point(183, 123);
            this.Senhalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senhalbl.Name = "Senhalbl";
            this.Senhalbl.Size = new System.Drawing.Size(61, 20);
            this.Senhalbl.TabIndex = 9;
            this.Senhalbl.Text = "Senha";
            // 
            // Senhatxb
            // 
            this.Senhatxb.BackColor = System.Drawing.SystemColors.Window;
            this.Senhatxb.Location = new System.Drawing.Point(188, 152);
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
            this.Usuariolbl.Location = new System.Drawing.Point(183, 54);
            this.Usuariolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(71, 20);
            this.Usuariolbl.TabIndex = 7;
            this.Usuariolbl.Text = "Usuário";
            // 
            // Usuariotxb
            // 
            this.Usuariotxb.Location = new System.Drawing.Point(188, 83);
            this.Usuariotxb.Margin = new System.Windows.Forms.Padding(4);
            this.Usuariotxb.Name = "Usuariotxb";
            this.Usuariotxb.Size = new System.Drawing.Size(171, 20);
            this.Usuariotxb.TabIndex = 8;
            this.Usuariotxb.Validating += new System.ComponentModel.CancelEventHandler(this.Usuariotxb_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Entrarbtn);
            this.panel1.Controls.Add(this.Usuariotxb);
            this.panel1.Controls.Add(this.BemVindoLbl);
            this.panel1.Controls.Add(this.Usuariolbl);
            this.panel1.Controls.Add(this.Senhatxb);
            this.panel1.Controls.Add(this.Senhalbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 246);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 82);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MsgFecharPnl
            // 
            this.MsgFecharPnl.BackColor = System.Drawing.Color.YellowGreen;
            this.MsgFecharPnl.Controls.Add(this.Fecharbtn);
            this.MsgFecharPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgFecharPnl.Location = new System.Drawing.Point(0, 0);
            this.MsgFecharPnl.Name = "MsgFecharPnl";
            this.MsgFecharPnl.Size = new System.Drawing.Size(365, 32);
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
            this.Fecharbtn.Size = new System.Drawing.Size(31, 26);
            this.Fecharbtn.TabIndex = 0;
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(365, 246);
            this.Controls.Add(this.MsgFecharPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MsgFecharPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BemVindoLbl;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.Label Senhalbl;
        private System.Windows.Forms.Label Usuariolbl;
        public System.Windows.Forms.TextBox Senhatxb;
        public System.Windows.Forms.TextBox Usuariotxb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MsgFecharPnl;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}