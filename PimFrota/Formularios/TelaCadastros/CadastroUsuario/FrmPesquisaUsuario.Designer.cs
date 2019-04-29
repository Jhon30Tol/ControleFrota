namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    partial class FrmPesquisaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaUsuario));
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.AtivoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.TodosCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.syslogDataSet = new PimFrota.syslogDataSet();
            this.syslogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(12, 12);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 0;
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(169, 9);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 5;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // AtivoCkbx
            // 
            this.AtivoCkbx.AutoSize = true;
            this.AtivoCkbx.Depth = 0;
            this.AtivoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.AtivoCkbx.Location = new System.Drawing.Point(9, 37);
            this.AtivoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.AtivoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AtivoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AtivoCkbx.Name = "AtivoCkbx";
            this.AtivoCkbx.Ripple = true;
            this.AtivoCkbx.Size = new System.Drawing.Size(62, 30);
            this.AtivoCkbx.TabIndex = 6;
            this.AtivoCkbx.Text = "Ativo";
            this.AtivoCkbx.UseVisualStyleBackColor = true;
            this.AtivoCkbx.CheckedChanged += new System.EventHandler(this.AtivoCkbx_CheckedChanged);
            // 
            // TodosCkbx
            // 
            this.TodosCkbx.AutoSize = true;
            this.TodosCkbx.Depth = 0;
            this.TodosCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.TodosCkbx.Location = new System.Drawing.Point(115, 37);
            this.TodosCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.TodosCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TodosCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.TodosCkbx.Name = "TodosCkbx";
            this.TodosCkbx.Ripple = true;
            this.TodosCkbx.Size = new System.Drawing.Size(69, 30);
            this.TodosCkbx.TabIndex = 8;
            this.TodosCkbx.Text = "Todos";
            this.TodosCkbx.UseVisualStyleBackColor = true;
            this.TodosCkbx.CheckedChanged += new System.EventHandler(this.TodosCkbx_CheckedChanged);
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(218, 13);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 9;
            this.PesquisarLbl.Text = "Pesquisar";
            this.PesquisarLbl.Click += new System.EventHandler(this.PesquisarLbl_Click);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(22, 140);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(395, 240);
            this.dataGridViewUsuario.TabIndex = 10;
            this.dataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick);
            // 
            // syslogDataSet
            // 
            this.syslogDataSet.DataSetName = "syslogDataSet";
            this.syslogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // syslogDataSetBindingSource
            // 
            this.syslogDataSetBindingSource.DataSource = this.syslogDataSet;
            this.syslogDataSetBindingSource.Position = 0;
            // 
            // FrmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 467);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.PesquisarLbl);
            this.Controls.Add(this.TodosCkbx);
            this.Controls.Add(this.AtivoCkbx);
            this.Controls.Add(this.PesquisarBtn);
            this.Controls.Add(this.PesquisarTbx);
            this.Name = "FrmPesquisaUsuario";
            this.Load += new System.EventHandler(this.FrmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PesquisarBtn;
        private MaterialSkin.Controls.MaterialCheckBox AtivoCkbx;
        private MaterialSkin.Controls.MaterialCheckBox TodosCkbx;
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        public System.Windows.Forms.TextBox PesquisarTbx;
        private System.Windows.Forms.BindingSource syslogDataSetBindingSource;
        private syslogDataSet syslogDataSet;
    }
}
