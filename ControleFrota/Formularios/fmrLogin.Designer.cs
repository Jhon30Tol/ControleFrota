namespace ControleFrota
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Entrarbtn = new System.Windows.Forms.Button();
            this.Senhatxb = new System.Windows.Forms.TextBox();
            this.Senhalbl = new System.Windows.Forms.Label();
            this.Usuariotxb = new System.Windows.Forms.TextBox();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entrarbtn
            // 
            this.Entrarbtn.BackColor = System.Drawing.Color.LightSalmon;
            this.Entrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrarbtn.Location = new System.Drawing.Point(197, 266);
            this.Entrarbtn.Name = "Entrarbtn";
            this.Entrarbtn.Size = new System.Drawing.Size(120, 23);
            this.Entrarbtn.TabIndex = 4;
            this.Entrarbtn.Text = "Entrar";
            this.Entrarbtn.UseVisualStyleBackColor = false;
            this.Entrarbtn.Click += new System.EventHandler(this.Entrarbtn_Click);
            // 
            // Senhatxb
            // 
            this.Senhatxb.BackColor = System.Drawing.SystemColors.Window;
            this.Senhatxb.Location = new System.Drawing.Point(163, 203);
            this.Senhatxb.Name = "Senhatxb";
            this.Senhatxb.Size = new System.Drawing.Size(184, 20);
            this.Senhatxb.TabIndex = 3;
            this.Senhatxb.TextChanged += new System.EventHandler(this.Senhatxb_TextChanged);
            // 
            // Senhalbl
            // 
            this.Senhalbl.AutoSize = true;
            this.Senhalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senhalbl.Location = new System.Drawing.Point(159, 180);
            this.Senhalbl.Name = "Senhalbl";
            this.Senhalbl.Size = new System.Drawing.Size(61, 20);
            this.Senhalbl.TabIndex = 2;
            this.Senhalbl.Text = "Senha";
            this.Senhalbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Usuariotxb
            // 
            this.Usuariotxb.Location = new System.Drawing.Point(163, 147);
            this.Usuariotxb.Name = "Usuariotxb";
            this.Usuariotxb.Size = new System.Drawing.Size(184, 20);
            this.Usuariotxb.TabIndex = 1;
            this.Usuariotxb.TextChanged += new System.EventHandler(this.Usuariotxb_TextChanged);
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolbl.Location = new System.Drawing.Point(159, 124);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(71, 20);
            this.Usuariolbl.TabIndex = 0;
            this.Usuariolbl.Text = "Usuário";
            this.Usuariolbl.Click += new System.EventHandler(this.Usuariolbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seja Bem-Vindo ao Sistema SisLog!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(523, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrarbtn);
            this.Controls.Add(this.Senhalbl);
            this.Controls.Add(this.Senhatxb);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.Usuariotxb);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Senhalbl;
        private System.Windows.Forms.TextBox Usuariotxb;
        private System.Windows.Forms.Label Usuariolbl;
        private System.Windows.Forms.Button Entrarbtn;
        private System.Windows.Forms.TextBox Senhatxb;
        private System.Windows.Forms.Label label1;
    }
}

