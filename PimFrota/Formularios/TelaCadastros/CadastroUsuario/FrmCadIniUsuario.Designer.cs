namespace PimFrota.Formularios.TelaCadastros.CadastroUsuario
{
    partial class FrmCadIniUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadIniUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BotaoCadastroPnl = new System.Windows.Forms.Panel();
            this.CancelarUsuBtn = new System.Windows.Forms.Button();
            this.EditarUsuBtn = new System.Windows.Forms.Button();
            this.IncluirUsuBtn = new System.Windows.Forms.Button();
            this.GravarUsuBtn = new System.Windows.Forms.Button();
            this.PesquisarUsuBtn = new System.Windows.Forms.Button();
            this.ExcluirUsuBtn = new System.Windows.Forms.Button();
            this.CadUsuIniPnl = new System.Windows.Forms.Panel();
            this.usuarioPesquisaPnl = new System.Windows.Forms.Panel();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syslogDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syslogDataSet = new PimFrota.syslogDataSet();
            this.PesquisarLbl = new MaterialSkin.Controls.MaterialLabel();
            this.TodosCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.AtivoCkbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.PesquisarTbx = new System.Windows.Forms.TextBox();
            this.usuarioPnl = new System.Windows.Forms.Panel();
            this.AtivoCbx = new System.Windows.Forms.ComboBox();
            this.AtvoLbl = new System.Windows.Forms.Label();
            this.SenhaUsuarioTbx = new System.Windows.Forms.TextBox();
            this.NomeUsuarioTbx = new System.Windows.Forms.TextBox();
            this.CodUsuarioTbx = new System.Windows.Forms.TextBox();
            this.SenhaUsuarioLbl = new System.Windows.Forms.Label();
            this.Codusuariobl = new System.Windows.Forms.Label();
            this.NomeUsuarioLbl = new System.Windows.Forms.Label();
            this.usuarioLbl = new System.Windows.Forms.Label();
            this.linhaUsuarioLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BotaoCadastroPnl.SuspendLayout();
            this.CadUsuIniPnl.SuspendLayout();
            this.usuarioPesquisaPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSet)).BeginInit();
            this.usuarioPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoCadastroPnl
            // 
            this.BotaoCadastroPnl.Controls.Add(this.CancelarUsuBtn);
            this.BotaoCadastroPnl.Controls.Add(this.EditarUsuBtn);
            this.BotaoCadastroPnl.Controls.Add(this.IncluirUsuBtn);
            this.BotaoCadastroPnl.Controls.Add(this.GravarUsuBtn);
            this.BotaoCadastroPnl.Controls.Add(this.PesquisarUsuBtn);
            this.BotaoCadastroPnl.Controls.Add(this.ExcluirUsuBtn);
            this.BotaoCadastroPnl.Location = new System.Drawing.Point(1, 2);
            this.BotaoCadastroPnl.Name = "BotaoCadastroPnl";
            this.BotaoCadastroPnl.Size = new System.Drawing.Size(258, 47);
            this.BotaoCadastroPnl.TabIndex = 22;
            // 
            // CancelarUsuBtn
            // 
            this.CancelarUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarUsuBtn.AutoSize = true;
            this.CancelarUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelarUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelarUsuBtn.BackgroundImage")));
            this.CancelarUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelarUsuBtn.FlatAppearance.BorderSize = 0;
            this.CancelarUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarUsuBtn.Location = new System.Drawing.Point(142, 3);
            this.CancelarUsuBtn.Name = "CancelarUsuBtn";
            this.CancelarUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelarUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.CancelarUsuBtn.TabIndex = 18;
            this.toolTip1.SetToolTip(this.CancelarUsuBtn, "Sair");
            this.CancelarUsuBtn.UseVisualStyleBackColor = false;
            this.CancelarUsuBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // EditarUsuBtn
            // 
            this.EditarUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditarUsuBtn.AutoSize = true;
            this.EditarUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditarUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditarUsuBtn.BackgroundImage")));
            this.EditarUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditarUsuBtn.FlatAppearance.BorderSize = 0;
            this.EditarUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarUsuBtn.Location = new System.Drawing.Point(103, 3);
            this.EditarUsuBtn.Name = "EditarUsuBtn";
            this.EditarUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditarUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.EditarUsuBtn.TabIndex = 20;
            this.toolTip1.SetToolTip(this.EditarUsuBtn, "Editar");
            this.EditarUsuBtn.UseVisualStyleBackColor = false;
            this.EditarUsuBtn.Click += new System.EventHandler(this.EditarUsuBtn_Click);
            // 
            // IncluirUsuBtn
            // 
            this.IncluirUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncluirUsuBtn.AutoSize = true;
            this.IncluirUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncluirUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncluirUsuBtn.BackgroundImage")));
            this.IncluirUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IncluirUsuBtn.FlatAppearance.BorderSize = 0;
            this.IncluirUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncluirUsuBtn.Location = new System.Drawing.Point(15, 3);
            this.IncluirUsuBtn.Name = "IncluirUsuBtn";
            this.IncluirUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncluirUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.IncluirUsuBtn.TabIndex = 15;
            this.toolTip1.SetToolTip(this.IncluirUsuBtn, "Incluir Novo Registro");
            this.IncluirUsuBtn.UseVisualStyleBackColor = false;
            this.IncluirUsuBtn.Click += new System.EventHandler(this.IncluirBtn_Click);
            // 
            // GravarUsuBtn
            // 
            this.GravarUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GravarUsuBtn.AutoSize = true;
            this.GravarUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.GravarUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GravarUsuBtn.BackgroundImage")));
            this.GravarUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GravarUsuBtn.FlatAppearance.BorderSize = 0;
            this.GravarUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GravarUsuBtn.Location = new System.Drawing.Point(61, 3);
            this.GravarUsuBtn.Name = "GravarUsuBtn";
            this.GravarUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GravarUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.GravarUsuBtn.TabIndex = 19;
            this.toolTip1.SetToolTip(this.GravarUsuBtn, "Salvar Dados");
            this.GravarUsuBtn.UseVisualStyleBackColor = false;
            this.GravarUsuBtn.Click += new System.EventHandler(this.GravarUsuBtn_Click);
            // 
            // PesquisarUsuBtn
            // 
            this.PesquisarUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PesquisarUsuBtn.AutoSize = true;
            this.PesquisarUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.PesquisarUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarUsuBtn.BackgroundImage")));
            this.PesquisarUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarUsuBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarUsuBtn.Location = new System.Drawing.Point(222, 3);
            this.PesquisarUsuBtn.Name = "PesquisarUsuBtn";
            this.PesquisarUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PesquisarUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.PesquisarUsuBtn.TabIndex = 16;
            this.toolTip1.SetToolTip(this.PesquisarUsuBtn, "Pesquisar");
            this.PesquisarUsuBtn.UseVisualStyleBackColor = false;
            this.PesquisarUsuBtn.Click += new System.EventHandler(this.PesquisarUsuBtn_Click);
            // 
            // ExcluirUsuBtn
            // 
            this.ExcluirUsuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcluirUsuBtn.AutoSize = true;
            this.ExcluirUsuBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExcluirUsuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcluirUsuBtn.BackgroundImage")));
            this.ExcluirUsuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcluirUsuBtn.FlatAppearance.BorderSize = 0;
            this.ExcluirUsuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirUsuBtn.Location = new System.Drawing.Point(181, 3);
            this.ExcluirUsuBtn.Name = "ExcluirUsuBtn";
            this.ExcluirUsuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExcluirUsuBtn.Size = new System.Drawing.Size(26, 44);
            this.ExcluirUsuBtn.TabIndex = 17;
            this.toolTip1.SetToolTip(this.ExcluirUsuBtn, "Excluir");
            this.ExcluirUsuBtn.UseVisualStyleBackColor = false;
            this.ExcluirUsuBtn.Click += new System.EventHandler(this.ExcluirUsuBtn_Click);
            // 
            // CadUsuIniPnl
            // 
            this.CadUsuIniPnl.Controls.Add(this.usuarioPesquisaPnl);
            this.CadUsuIniPnl.Controls.Add(this.usuarioPnl);
            this.CadUsuIniPnl.Location = new System.Drawing.Point(2, 69);
            this.CadUsuIniPnl.Name = "CadUsuIniPnl";
            this.CadUsuIniPnl.Size = new System.Drawing.Size(594, 414);
            this.CadUsuIniPnl.TabIndex = 23;
            this.CadUsuIniPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.CadUsuIniPnl_Paint);
            // 
            // usuarioPesquisaPnl
            // 
            this.usuarioPesquisaPnl.AutoSize = true;
            this.usuarioPesquisaPnl.Controls.Add(this.dataGridViewUsuario);
            this.usuarioPesquisaPnl.Controls.Add(this.PesquisarLbl);
            this.usuarioPesquisaPnl.Controls.Add(this.TodosCkbx);
            this.usuarioPesquisaPnl.Controls.Add(this.AtivoCkbx);
            this.usuarioPesquisaPnl.Controls.Add(this.PesquisarBtn);
            this.usuarioPesquisaPnl.Controls.Add(this.PesquisarTbx);
            this.usuarioPesquisaPnl.Location = new System.Drawing.Point(3, 3);
            this.usuarioPesquisaPnl.Name = "usuarioPesquisaPnl";
            this.usuarioPesquisaPnl.Size = new System.Drawing.Size(543, 399);
            this.usuarioPesquisaPnl.TabIndex = 1;
            this.usuarioPesquisaPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.usuarioPesquisaPnl_Paint);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuario.AutoGenerateColumns = false;
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.Column2,
            this.Column3});
            this.dataGridViewUsuario.DataSource = this.syslogDataSetBindingSource;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(6, 69);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(531, 325);
            this.dataGridViewUsuario.TabIndex = 17;
            this.dataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick_2);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ativo";
            this.Column1.HeaderText = "Ativo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id usuario";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Senha";
            this.Column3.HeaderText = "Senha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // syslogDataSetBindingSource
            // 
            this.syslogDataSetBindingSource.DataSource = this.syslogDataSet;
            this.syslogDataSetBindingSource.Position = 0;
            // 
            // syslogDataSet
            // 
            this.syslogDataSet.DataSetName = "C";
            this.syslogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PesquisarLbl
            // 
            this.PesquisarLbl.AutoSize = true;
            this.PesquisarLbl.Depth = 0;
            this.PesquisarLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.PesquisarLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PesquisarLbl.Location = new System.Drawing.Point(215, 12);
            this.PesquisarLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.PesquisarLbl.Name = "PesquisarLbl";
            this.PesquisarLbl.Size = new System.Drawing.Size(76, 19);
            this.PesquisarLbl.TabIndex = 15;
            this.PesquisarLbl.Text = "Pesquisar";
            // 
            // TodosCkbx
            // 
            this.TodosCkbx.AutoSize = true;
            this.TodosCkbx.Depth = 0;
            this.TodosCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.TodosCkbx.Location = new System.Drawing.Point(112, 36);
            this.TodosCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.TodosCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TodosCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.TodosCkbx.Name = "TodosCkbx";
            this.TodosCkbx.Ripple = true;
            this.TodosCkbx.Size = new System.Drawing.Size(69, 30);
            this.TodosCkbx.TabIndex = 14;
            this.TodosCkbx.Text = "Todos";
            this.TodosCkbx.UseVisualStyleBackColor = true;
            this.TodosCkbx.CheckedChanged += new System.EventHandler(this.TodosCkbx_CheckedChanged);
            // 
            // AtivoCkbx
            // 
            this.AtivoCkbx.AutoSize = true;
            this.AtivoCkbx.Depth = 0;
            this.AtivoCkbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.AtivoCkbx.Location = new System.Drawing.Point(6, 36);
            this.AtivoCkbx.Margin = new System.Windows.Forms.Padding(0);
            this.AtivoCkbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AtivoCkbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.AtivoCkbx.Name = "AtivoCkbx";
            this.AtivoCkbx.Ripple = true;
            this.AtivoCkbx.Size = new System.Drawing.Size(62, 30);
            this.AtivoCkbx.TabIndex = 13;
            this.AtivoCkbx.Text = "Ativo";
            this.AtivoCkbx.UseVisualStyleBackColor = true;
            this.AtivoCkbx.CheckedChanged += new System.EventHandler(this.AtivoCkbx_CheckedChanged);
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.BackgroundImage")));
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarBtn.FlatAppearance.BorderSize = 0;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesquisarBtn.Location = new System.Drawing.Point(166, 8);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(43, 25);
            this.PesquisarBtn.TabIndex = 12;
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // PesquisarTbx
            // 
            this.PesquisarTbx.Location = new System.Drawing.Point(9, 11);
            this.PesquisarTbx.Name = "PesquisarTbx";
            this.PesquisarTbx.Size = new System.Drawing.Size(151, 20);
            this.PesquisarTbx.TabIndex = 11;
            // 
            // usuarioPnl
            // 
            this.usuarioPnl.Controls.Add(this.AtivoCbx);
            this.usuarioPnl.Controls.Add(this.AtvoLbl);
            this.usuarioPnl.Controls.Add(this.SenhaUsuarioTbx);
            this.usuarioPnl.Controls.Add(this.NomeUsuarioTbx);
            this.usuarioPnl.Controls.Add(this.CodUsuarioTbx);
            this.usuarioPnl.Controls.Add(this.SenhaUsuarioLbl);
            this.usuarioPnl.Controls.Add(this.Codusuariobl);
            this.usuarioPnl.Controls.Add(this.NomeUsuarioLbl);
            this.usuarioPnl.Location = new System.Drawing.Point(15, 17);
            this.usuarioPnl.Name = "usuarioPnl";
            this.usuarioPnl.Size = new System.Drawing.Size(328, 171);
            this.usuarioPnl.TabIndex = 0;
            // 
            // AtivoCbx
            // 
            this.AtivoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AtivoCbx.FormattingEnabled = true;
            this.AtivoCbx.Items.AddRange(new object[] {
            "S",
            "N"});
            this.AtivoCbx.Location = new System.Drawing.Point(88, 47);
            this.AtivoCbx.Name = "AtivoCbx";
            this.AtivoCbx.Size = new System.Drawing.Size(76, 21);
            this.AtivoCbx.TabIndex = 116;
            // 
            // AtvoLbl
            // 
            this.AtvoLbl.AutoSize = true;
            this.AtvoLbl.BackColor = System.Drawing.Color.Transparent;
            this.AtvoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtvoLbl.Location = new System.Drawing.Point(23, 51);
            this.AtvoLbl.Name = "AtvoLbl";
            this.AtvoLbl.Size = new System.Drawing.Size(49, 17);
            this.AtvoLbl.TabIndex = 115;
            this.AtvoLbl.Text = "Ativo:";
            // 
            // SenhaUsuarioTbx
            // 
            this.SenhaUsuarioTbx.Location = new System.Drawing.Point(88, 123);
            this.SenhaUsuarioTbx.Name = "SenhaUsuarioTbx";
            this.SenhaUsuarioTbx.PasswordChar = '*';
            this.SenhaUsuarioTbx.Size = new System.Drawing.Size(189, 20);
            this.SenhaUsuarioTbx.TabIndex = 114;
            // 
            // NomeUsuarioTbx
            // 
            this.NomeUsuarioTbx.Location = new System.Drawing.Point(88, 88);
            this.NomeUsuarioTbx.Name = "NomeUsuarioTbx";
            this.NomeUsuarioTbx.Size = new System.Drawing.Size(189, 20);
            this.NomeUsuarioTbx.TabIndex = 113;
            this.NomeUsuarioTbx.Validating += new System.ComponentModel.CancelEventHandler(this.NomeUsuarioTbx_Validating);
            // 
            // CodUsuarioTbx
            // 
            this.CodUsuarioTbx.Enabled = false;
            this.CodUsuarioTbx.Location = new System.Drawing.Point(88, 11);
            this.CodUsuarioTbx.Name = "CodUsuarioTbx";
            this.CodUsuarioTbx.Size = new System.Drawing.Size(76, 20);
            this.CodUsuarioTbx.TabIndex = 112;
            this.CodUsuarioTbx.Text = "Automatico";
            // 
            // SenhaUsuarioLbl
            // 
            this.SenhaUsuarioLbl.AutoSize = true;
            this.SenhaUsuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.SenhaUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaUsuarioLbl.Location = new System.Drawing.Point(18, 126);
            this.SenhaUsuarioLbl.Name = "SenhaUsuarioLbl";
            this.SenhaUsuarioLbl.Size = new System.Drawing.Size(59, 17);
            this.SenhaUsuarioLbl.TabIndex = 111;
            this.SenhaUsuarioLbl.Text = "Senha:";
            // 
            // Codusuariobl
            // 
            this.Codusuariobl.AutoSize = true;
            this.Codusuariobl.BackColor = System.Drawing.Color.Transparent;
            this.Codusuariobl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codusuariobl.Location = new System.Drawing.Point(18, 14);
            this.Codusuariobl.Name = "Codusuariobl";
            this.Codusuariobl.Size = new System.Drawing.Size(63, 17);
            this.Codusuariobl.TabIndex = 110;
            this.Codusuariobl.Text = "Código:";
            // 
            // NomeUsuarioLbl
            // 
            this.NomeUsuarioLbl.AutoSize = true;
            this.NomeUsuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeUsuarioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUsuarioLbl.Location = new System.Drawing.Point(18, 91);
            this.NomeUsuarioLbl.Name = "NomeUsuarioLbl";
            this.NomeUsuarioLbl.Size = new System.Drawing.Size(54, 17);
            this.NomeUsuarioLbl.TabIndex = 109;
            this.NomeUsuarioLbl.Text = "Nome:";
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.AutoSize = true;
            this.usuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLbl.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.usuarioLbl.Location = new System.Drawing.Point(461, 14);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(126, 31);
            this.usuarioLbl.TabIndex = 27;
            this.usuarioLbl.Text = "Usuário";
            // 
            // linhaUsuarioLbl
            // 
            this.linhaUsuarioLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linhaUsuarioLbl.Location = new System.Drawing.Point(1, 52);
            this.linhaUsuarioLbl.Name = "linhaUsuarioLbl";
            this.linhaUsuarioLbl.Size = new System.Drawing.Size(598, 10);
            this.linhaUsuarioLbl.TabIndex = 28;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.YellowGreen;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup_1);
            // 
            // FrmCadIniUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 495);
            this.Controls.Add(this.linhaUsuarioLbl);
            this.Controls.Add(this.usuarioLbl);
            this.Controls.Add(this.CadUsuIniPnl);
            this.Controls.Add(this.BotaoCadastroPnl);
            this.Name = "FrmCadIniUsuario";
            this.Load += new System.EventHandler(this.FrmCadIniUsuario_Load);
            this.BotaoCadastroPnl.ResumeLayout(false);
            this.BotaoCadastroPnl.PerformLayout();
            this.CadUsuIniPnl.ResumeLayout(false);
            this.CadUsuIniPnl.PerformLayout();
            this.usuarioPesquisaPnl.ResumeLayout(false);
            this.usuarioPesquisaPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syslogDataSet)).EndInit();
            this.usuarioPnl.ResumeLayout(false);
            this.usuarioPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BotaoCadastroPnl;
        private System.Windows.Forms.Button IncluirUsuBtn;
        private System.Windows.Forms.Button GravarUsuBtn;
        private System.Windows.Forms.Button PesquisarUsuBtn;
        private System.Windows.Forms.Button ExcluirUsuBtn;
        private System.Windows.Forms.Panel CadUsuIniPnl;
        public System.Windows.Forms.Button CancelarUsuBtn;
        public System.Windows.Forms.Button EditarUsuBtn;
        private System.Windows.Forms.Panel usuarioPnl;
        public System.Windows.Forms.ComboBox AtivoCbx;
        private System.Windows.Forms.Label AtvoLbl;
        public System.Windows.Forms.TextBox SenhaUsuarioTbx;
        public System.Windows.Forms.TextBox NomeUsuarioTbx;
        private System.Windows.Forms.Label SenhaUsuarioLbl;
        private System.Windows.Forms.Label Codusuariobl;
        private System.Windows.Forms.Label NomeUsuarioLbl;
        private System.Windows.Forms.Panel usuarioPesquisaPnl;
        private MaterialSkin.Controls.MaterialLabel PesquisarLbl;
        private MaterialSkin.Controls.MaterialCheckBox TodosCkbx;
        private MaterialSkin.Controls.MaterialCheckBox AtivoCkbx;
        private System.Windows.Forms.Button PesquisarBtn;
        public System.Windows.Forms.TextBox PesquisarTbx;
        public System.Windows.Forms.TextBox CodUsuarioTbx;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Label usuarioLbl;
        private System.Windows.Forms.Label linhaUsuarioLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource syslogDataSetBindingSource;
        private syslogDataSet syslogDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
