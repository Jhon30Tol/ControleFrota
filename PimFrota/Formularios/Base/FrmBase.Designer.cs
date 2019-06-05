namespace PimFrota.Formularios.Base
{
    partial class FrmBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Fecharbtn = new System.Windows.Forms.Button();
            this.BarraBasePnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.versaoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.usuarioLogadoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BarraBasePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.MinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.BackgroundImage")));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(721, 4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 28);
            this.MinimizeBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.MinimizeBtn, "Minimizar");
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
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
            this.Fecharbtn.Location = new System.Drawing.Point(768, 6);
            this.Fecharbtn.Name = "Fecharbtn";
            this.Fecharbtn.Size = new System.Drawing.Size(25, 25);
            this.Fecharbtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Fecharbtn, "Fechar");
            this.Fecharbtn.UseVisualStyleBackColor = false;
            this.Fecharbtn.Click += new System.EventHandler(this.Fecharbtn_Click);
            // 
            // BarraBasePnl
            // 
            this.BarraBasePnl.BackColor = System.Drawing.Color.YellowGreen;
            this.BarraBasePnl.Controls.Add(this.MinimizeBtn);
            this.BarraBasePnl.Controls.Add(this.Fecharbtn);
            this.BarraBasePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraBasePnl.Location = new System.Drawing.Point(0, 0);
            this.BarraBasePnl.Name = "BarraBasePnl";
            this.BarraBasePnl.Size = new System.Drawing.Size(800, 39);
            this.BarraBasePnl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(693, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // versaoLbl
            // 
            this.versaoLbl.AutoSize = true;
            this.versaoLbl.Depth = 0;
            this.versaoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.versaoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versaoLbl.Location = new System.Drawing.Point(3, 431);
            this.versaoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.versaoLbl.Name = "versaoLbl";
            this.versaoLbl.Size = new System.Drawing.Size(81, 19);
            this.versaoLbl.TabIndex = 3;
            this.versaoLbl.Text = "Versão 1.0";
            this.versaoLbl.Click += new System.EventHandler(this.versaoLbl_Click);
            // 
            // usuarioLogadoLbl
            // 
            this.usuarioLogadoLbl.AutoSize = true;
            this.usuarioLogadoLbl.Depth = 0;
            this.usuarioLogadoLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.usuarioLogadoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usuarioLogadoLbl.Location = new System.Drawing.Point(197, 431);
            this.usuarioLogadoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.usuarioLogadoLbl.Name = "usuarioLogadoLbl";
            this.usuarioLogadoLbl.Size = new System.Drawing.Size(61, 19);
            this.usuarioLogadoLbl.TabIndex = 4;
            this.usuarioLogadoLbl.Text = "Usuario";
            this.usuarioLogadoLbl.Click += new System.EventHandler(this.usuarioLogadoLbl_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(122, 431);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Usuario: ";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.usuarioLogadoLbl);
            this.Controls.Add(this.versaoLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarraBasePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.BarraBasePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Fecharbtn;
        private System.Windows.Forms.Panel BarraBasePnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialLabel versaoLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel usuarioLogadoLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}