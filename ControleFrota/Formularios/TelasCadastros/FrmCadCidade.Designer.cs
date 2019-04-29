using ControleFrota.Formulários;

namespace ControleFrota.TelasCadastros
{
    partial class FrmCadCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCidade));
            this.EstadoTbx = new System.Windows.Forms.TextBox();
            this.CodIbgeTbx = new System.Windows.Forms.TextBox();
            this.NomeCidadeTbx = new System.Windows.Forms.TextBox();
            this.CodCidadeTbx = new System.Windows.Forms.TextBox();
            this.EstadoLbl = new System.Windows.Forms.Label();
            this.CodCidadelbl = new System.Windows.Forms.Label();
            this.IbgeCidadeLbl = new System.Windows.Forms.Label();
            this.NomeCidadeLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.GravarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.ExcluirBtn = new System.Windows.Forms.Button();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.IncluirBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadoTbx
            // 
            this.EstadoTbx.Location = new System.Drawing.Point(81, 146);
            this.EstadoTbx.Name = "EstadoTbx";
            this.EstadoTbx.Size = new System.Drawing.Size(315, 20);
            this.EstadoTbx.TabIndex = 91;
            // 
            // CodIbgeTbx
            // 
            this.CodIbgeTbx.Location = new System.Drawing.Point(508, 111);
            this.CodIbgeTbx.Name = "CodIbgeTbx";
            this.CodIbgeTbx.Size = new System.Drawing.Size(137, 20);
            this.CodIbgeTbx.TabIndex = 88;
            // 
            // NomeCidadeTbx
            // 
            this.NomeCidadeTbx.Location = new System.Drawing.Point(81, 111);
            this.NomeCidadeTbx.Name = "NomeCidadeTbx";
            this.NomeCidadeTbx.Size = new System.Drawing.Size(315, 20);
            this.NomeCidadeTbx.TabIndex = 87;
            // 
            // CodCidadeTbx
            // 
            this.CodCidadeTbx.Location = new System.Drawing.Point(81, 68);
            this.CodCidadeTbx.Name = "CodCidadeTbx";
            this.CodCidadeTbx.Size = new System.Drawing.Size(120, 20);
            this.CodCidadeTbx.TabIndex = 86;
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.AutoSize = true;
            this.EstadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.EstadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLbl.Location = new System.Drawing.Point(11, 149);
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(63, 17);
            this.EstadoLbl.TabIndex = 85;
            this.EstadoLbl.Text = "Estado:";
            // 
            // CodCidadelbl
            // 
            this.CodCidadelbl.AutoSize = true;
            this.CodCidadelbl.BackColor = System.Drawing.Color.Transparent;
            this.CodCidadelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodCidadelbl.Location = new System.Drawing.Point(11, 71);
            this.CodCidadelbl.Name = "CodCidadelbl";
            this.CodCidadelbl.Size = new System.Drawing.Size(63, 17);
            this.CodCidadelbl.TabIndex = 84;
            this.CodCidadelbl.Text = "Código:";
            // 
            // IbgeCidadeLbl
            // 
            this.IbgeCidadeLbl.AutoSize = true;
            this.IbgeCidadeLbl.BackColor = System.Drawing.Color.Transparent;
            this.IbgeCidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbgeCidadeLbl.Location = new System.Drawing.Point(422, 111);
            this.IbgeCidadeLbl.Name = "IbgeCidadeLbl";
            this.IbgeCidadeLbl.Size = new System.Drawing.Size(87, 17);
            this.IbgeCidadeLbl.TabIndex = 80;
            this.IbgeCidadeLbl.Text = "Cod. IBGE:";
            // 
            // NomeCidadeLbl
            // 
            this.NomeCidadeLbl.AutoSize = true;
            this.NomeCidadeLbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeCidadeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCidadeLbl.Location = new System.Drawing.Point(11, 114);
            this.NomeCidadeLbl.Name = "NomeCidadeLbl";
            this.NomeCidadeLbl.Size = new System.Drawing.Size(68, 17);
            this.NomeCidadeLbl.TabIndex = 78;
            this.NomeCidadeLbl.Text = " Cidade:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.EditarBtn);
            this.panel1.Controls.Add(this.GravarBtn);
            this.panel1.Controls.Add(this.CancelarBtn);
            this.panel1.Controls.Add(this.ExcluirBtn);
            this.panel1.Controls.Add(this.PesquisarBtn);
            this.panel1.Controls.Add(this.IncluirBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 48);
            this.panel1.TabIndex = 77;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarBtn.AutoSize = true;
            this.EditarBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditarBtn.BackgroundImage")));
            this.EditarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditarBtn.FlatAppearance.BorderSize = 0;
            this.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBtn.Location = new System.Drawing.Point(81, 3);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditarBtn.Size = new System.Drawing.Size(24, 42);
            this.EditarBtn.TabIndex = 14;
            this.EditarBtn.UseVisualStyleBackColor = false;
            // 
            // GravarBtn
            // 
            this.GravarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GravarBtn.AutoSize = true;
            this.GravarBtn.BackColor = System.Drawing.Color.Transparent;
            this.GravarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GravarBtn.BackgroundImage")));
            this.GravarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GravarBtn.FlatAppearance.BorderSize = 0;
            this.GravarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GravarBtn.Location = new System.Drawing.Point(51, 3);
            this.GravarBtn.Name = "GravarBtn";
            this.GravarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GravarBtn.Size = new System.Drawing.Size(24, 42);
            this.GravarBtn.TabIndex = 13;
            this.GravarBtn.UseVisualStyleBackColor = false;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarBtn.AutoSize = true;
            this.CancelarBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.BackgroundImage")));
            this.CancelarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelarBtn.FlatAppearance.BorderSize = 0;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBtn.Location = new System.Drawing.Point(111, 3);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelarBtn.Size = new System.Drawing.Size(24, 42);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.UseVisualStyleBackColor = false;
            // 
            // ExcluirBtn
            // 
            this.ExcluirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcluirBtn.AutoSize = true;
            this.ExcluirBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExcluirBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcluirBtn.BackgroundImage")));
            this.ExcluirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcluirBtn.FlatAppearance.BorderSize = 0;
            this.ExcluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirBtn.Location = new System.Drawing.Point(141, 3);
            this.ExcluirBtn.Name = "ExcluirBtn";
            this.ExcluirBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExcluirBtn.Size = new System.Drawing.Size(24, 42);
            this.ExcluirBtn.TabIndex = 11;
            this.ExcluirBtn.UseVisualStyleBackColor = false;
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PesquisarBtn.AutoSize = true;
            this.PesquisarBtn.BackColor = System.Drawing.Color.Transparent;
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(171, 3);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PesquisarBtn.Size = new System.Drawing.Size(24, 42);
            this.PesquisarBtn.TabIndex = 10;
            this.PesquisarBtn.UseVisualStyleBackColor = false;
            // 
            // IncluirBtn
            // 
            this.IncluirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirBtn.AutoSize = true;
            this.IncluirBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncluirBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncluirBtn.BackgroundImage")));
            this.IncluirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IncluirBtn.FlatAppearance.BorderSize = 0;
            this.IncluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirBtn.Location = new System.Drawing.Point(21, 3);
            this.IncluirBtn.Name = "IncluirBtn";
            this.IncluirBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncluirBtn.Size = new System.Drawing.Size(24, 42);
            this.IncluirBtn.TabIndex = 9;
            this.IncluirBtn.UseVisualStyleBackColor = false;
            // 
            // FrmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 204);
            this.Controls.Add(this.EstadoTbx);
            this.Controls.Add(this.CodIbgeTbx);
            this.Controls.Add(this.NomeCidadeTbx);
            this.Controls.Add(this.CodCidadeTbx);
            this.Controls.Add(this.EstadoLbl);
            this.Controls.Add(this.CodCidadelbl);
            this.Controls.Add(this.IbgeCidadeLbl);
            this.Controls.Add(this.NomeCidadeLbl);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCadCidade";
            this.Text = "Cadastro de Cidade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EstadoTbx;
        private System.Windows.Forms.TextBox CodIbgeTbx;
        private System.Windows.Forms.TextBox NomeCidadeTbx;
        private System.Windows.Forms.TextBox CodCidadeTbx;
        private System.Windows.Forms.Label EstadoLbl;
        private System.Windows.Forms.Label CodCidadelbl;
        private System.Windows.Forms.Label IbgeCidadeLbl;
        private System.Windows.Forms.Label NomeCidadeLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button GravarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button ExcluirBtn;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.Button IncluirBtn;
    }
}