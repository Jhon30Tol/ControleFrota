namespace PimFrota.Formularios.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogoLoginImg = new System.Windows.Forms.PictureBox();
            this.BemVindoLbl = new System.Windows.Forms.Label();
            this.Entrarbtn = new System.Windows.Forms.Button();
            this.Senhalbl = new System.Windows.Forms.Label();
            this.Senhatxb = new System.Windows.Forms.TextBox();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.Usuariotxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLoginImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoLoginImg
            // 
            this.LogoLoginImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoLoginImg.BackgroundImage")));
            this.LogoLoginImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoLoginImg.Location = new System.Drawing.Point(9, 59);
            this.LogoLoginImg.Margin = new System.Windows.Forms.Padding(4);
            this.LogoLoginImg.Name = "LogoLoginImg";
            this.LogoLoginImg.Size = new System.Drawing.Size(155, 82);
            this.LogoLoginImg.TabIndex = 13;
            this.LogoLoginImg.TabStop = false;
            // 
            // BemVindoLbl
            // 
            this.BemVindoLbl.AutoSize = true;
            this.BemVindoLbl.BackColor = System.Drawing.Color.Transparent;
            this.BemVindoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoLbl.Location = new System.Drawing.Point(9, 14);
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
            this.Entrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Entrarbtn.Location = new System.Drawing.Point(189, 163);
            this.Entrarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Size = new System.Drawing.Size(160, 33);
            this.Entrarbtn.TabIndex = 11;
            this.Entrarbtn.Text = "Entrar";
            this.Entrarbtn.UseVisualStyleBackColor = false;
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            // 
            // Senhalbl
            // 
            this.Senhalbl.AutoSize = true;
            this.Senhalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senhalbl.Location = new System.Drawing.Point(184, 88);
            this.Senhalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senhalbl.Name = "Senhalbl";
            this.Senhalbl.Size = new System.Drawing.Size(61, 20);
            this.Senhalbl.TabIndex = 9;
            this.Senhalbl.Text = "Senha";
            // 
            // Senhatxb
            // 
            this.Senhatxb.BackColor = System.Drawing.SystemColors.Window;
            this.Senhatxb.Location = new System.Drawing.Point(189, 117);
            this.Senhatxb.Margin = new System.Windows.Forms.Padding(4);
            this.Senhatxb.Name = "Senhatxb";
            this.Senhatxb.PasswordChar = '*';
            this.Senhatxb.Size = new System.Drawing.Size(171, 20);
            this.Senhatxb.TabIndex = 10;
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolbl.Location = new System.Drawing.Point(184, 19);
            this.Usuariolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(71, 20);
            this.Usuariolbl.TabIndex = 7;
            this.Usuariolbl.Text = "Usuário";
            // 
            // Usuariotxb
            // 
            this.Usuariotxb.Location = new System.Drawing.Point(189, 48);
            this.Usuariotxb.Margin = new System.Windows.Forms.Padding(4);
            this.Usuariotxb.Name = "Usuariotxb";
            this.Usuariotxb.Size = new System.Drawing.Size(171, 20);
            this.Usuariotxb.TabIndex = 8;
            this.Usuariotxb.Validating += new System.ComponentModel.CancelEventHandler(this.Usuariotxb_Validating);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(365, 206);
            this.Controls.Add(this.LogoLoginImg);
            this.Controls.Add(this.BemVindoLbl);
            this.Controls.Add(this.Entrarbtn);
            this.Controls.Add(this.Senhalbl);
            this.Controls.Add(this.Senhatxb);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.Usuariotxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LogoLoginImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoLoginImg;
        private System.Windows.Forms.Label BemVindoLbl;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.Label Senhalbl;
        private System.Windows.Forms.Label Usuariolbl;
        public System.Windows.Forms.TextBox Senhatxb;
        public System.Windows.Forms.TextBox Usuariotxb;
    }
}