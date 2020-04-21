namespace Novo_Projeto_Tantas
{
    partial class FrmCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.AgendaCompromissos = new System.Windows.Forms.MonthCalendar();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txtWebSite = new System.Windows.Forms.TextBox();
            this.lknWebSite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_de = new System.Windows.Forms.Label();
            this.dTP_De = new System.Windows.Forms.DateTimePicker();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lbl_proposta = new System.Windows.Forms.Label();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txt_Razao = new System.Windows.Forms.TextBox();
            this.mtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dt_Ate = new System.Windows.Forms.DateTimePicker();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lbl_avisos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLemPessoais = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lvDados = new System.Windows.Forms.ListBox();
            this.dvDados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbExcluir = new System.Windows.Forms.PictureBox();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbSalvar = new System.Windows.Forms.PictureBox();
            this.ptbAdicionarGrid = new System.Windows.Forms.PictureBox();
            this.ptbLimpar = new System.Windows.Forms.PictureBox();
            this.ptbBuscar = new System.Windows.Forms.PictureBox();
            this.Lbl_Excluir_Historico = new System.Windows.Forms.Label();
            this.lbl_Id_ExcliurHistorico = new System.Windows.Forms.Label();
            this.tantasDataSet = new Novo_Projeto_Tantas.tantasDataSet();
            this.tantasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionarGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(144, 23);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(268, 26);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(66, 19);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(48, 17);
            this.rbData.TabIndex = 1;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            this.rbData.Click += new System.EventHandler(this.rbData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 40);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(7, 20);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            this.rbNome.Click += new System.EventHandler(this.rbNome_Click);
            // 
            // AgendaCompromissos
            // 
            this.AgendaCompromissos.Location = new System.Drawing.Point(692, 13);
            this.AgendaCompromissos.Name = "AgendaCompromissos";
            this.AgendaCompromissos.TabIndex = 51;
            this.AgendaCompromissos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgendaCompromissos_MouseDown);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(10, 155);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id.TabIndex = 50;
            // 
            // txtWebSite
            // 
            this.txtWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebSite.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtWebSite.Location = new System.Drawing.Point(457, 10);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(223, 26);
            this.txtWebSite.TabIndex = 1;
            this.txtWebSite.DoubleClick += new System.EventHandler(this.txtWebSite_DoubleClick);
            this.txtWebSite.MouseHover += new System.EventHandler(this.txtWebSite_MouseHover);
            // 
            // lknWebSite
            // 
            this.lknWebSite.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lknWebSite.AutoSize = true;
            this.lknWebSite.Location = new System.Drawing.Point(498, 10);
            this.lknWebSite.Name = "lknWebSite";
            this.lknWebSite.Size = new System.Drawing.Size(0, 13);
            this.lknWebSite.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Site :";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(278, 27);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(29, 13);
            this.lbl_A.TabIndex = 72;
            this.lbl_A.Text = " Até:";
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Location = new System.Drawing.Point(144, 27);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(24, 13);
            this.lbl_de.TabIndex = 71;
            this.lbl_de.Text = "De:";
            // 
            // dTP_De
            // 
            this.dTP_De.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_De.Location = new System.Drawing.Point(174, 23);
            this.dTP_De.Name = "dTP_De";
            this.dTP_De.Size = new System.Drawing.Size(98, 20);
            this.dTP_De.TabIndex = 3;
            this.dTP_De.Value = new System.DateTime(2014, 3, 23, 0, 0, 0, 0);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(481, 42);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(199, 26);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(430, 55);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(46, 13);
            this.lblObs.TabIndex = 45;
            this.lblObs.Text = "Cidade :";
            this.lblObs.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // lbl_proposta
            // 
            this.lbl_proposta.AutoSize = true;
            this.lbl_proposta.Location = new System.Drawing.Point(17, 136);
            this.lbl_proposta.Name = "lbl_proposta";
            this.lbl_proposta.Size = new System.Drawing.Size(55, 13);
            this.lbl_proposta.TabIndex = 44;
            this.lbl_proposta.Text = "Proposta :";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(99, 136);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(590, 57);
            this.txtHistorico.TabIndex = 9;
            this.txtHistorico.Click += new System.EventHandler(this.txtHistorico_Click);
            // 
            // txt_Razao
            // 
            this.txt_Razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Razao.Location = new System.Drawing.Point(99, 10);
            this.txt_Razao.Name = "txt_Razao";
            this.txt_Razao.Size = new System.Drawing.Size(325, 26);
            this.txt_Razao.TabIndex = 0;
            this.txt_Razao.Click += new System.EventHandler(this.txt_Razao_Click);
            // 
            // mtTelefone
            // 
            this.mtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtTelefone.Location = new System.Drawing.Point(99, 106);
            this.mtTelefone.Mask = "(99) 0000-00000";
            this.mtTelefone.Name = "mtTelefone";
            this.mtTelefone.Size = new System.Drawing.Size(126, 26);
            this.mtTelefone.TabIndex = 8;
            // 
            // dt_Ate
            // 
            this.dt_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ate.Location = new System.Drawing.Point(313, 23);
            this.dt_Ate.Name = "dt_Ate";
            this.dt_Ate.Size = new System.Drawing.Size(97, 20);
            this.dt_Ate.TabIndex = 73;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(17, 114);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 38;
            this.lblTelefone.Text = "Telefone :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtEmail.Location = new System.Drawing.Point(371, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.DoubleClick += new System.EventHandler(this.txtEmail_DoubleClick);
            this.txtEmail.MouseHover += new System.EventHandler(this.txtEmail_MouseHover);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(315, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Contato :";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(371, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(53, 26);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(315, 55);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 30;
            this.lblNumero.Text = "Número :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(99, 42);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(210, 26);
            this.txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(17, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(59, 13);
            this.lblEndereco.TabIndex = 28;
            this.lblEndereco.Text = "Endereço :";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(17, 23);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(76, 13);
            this.lblRazaoSocial.TabIndex = 27;
            this.lblRazaoSocial.Text = "Razão Social :";
            // 
            // lbl_avisos
            // 
            this.lbl_avisos.AutoSize = true;
            this.lbl_avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avisos.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisos.Location = new System.Drawing.Point(752, 38);
            this.lbl_avisos.Name = "lbl_avisos";
            this.lbl_avisos.Size = new System.Drawing.Size(144, 16);
            this.lbl_avisos.TabIndex = 74;
            this.lbl_avisos.Text = "Avisos Importatntes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblLemPessoais);
            this.groupBox2.Controls.Add(this.AgendaCompromissos);
            this.groupBox2.Controls.Add(this.lbl_Id);
            this.groupBox2.Controls.Add(this.txtWebSite);
            this.groupBox2.Controls.Add(this.lknWebSite);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblObs);
            this.groupBox2.Controls.Add(this.lbl_proposta);
            this.groupBox2.Controls.Add(this.txtHistorico);
            this.groupBox2.Controls.Add(this.txt_Razao);
            this.groupBox2.Controls.Add(this.mtTelefone);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtContato);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.lblRazaoSocial);
            this.groupBox2.Location = new System.Drawing.Point(15, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(931, 200);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cliente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.lupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(895, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLemPessoais
            // 
            this.lblLemPessoais.AutoSize = true;
            this.lblLemPessoais.Location = new System.Drawing.Point(788, 181);
            this.lblLemPessoais.Name = "lblLemPessoais";
            this.lblLemPessoais.Size = new System.Drawing.Size(101, 13);
            this.lblLemPessoais.TabIndex = 53;
            this.lblLemPessoais.Text = "Lembretes Pessoais";
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(99, 74);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(210, 26);
            this.txtContato.TabIndex = 6;
            // 
            // lvDados
            // 
            this.lvDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDados.FormattingEnabled = true;
            this.lvDados.ItemHeight = 20;
            this.lvDados.Location = new System.Drawing.Point(15, 256);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(171, 304);
            this.lvDados.TabIndex = 68;
            this.lvDados.Click += new System.EventHandler(this.lvDados_Click);
            this.lvDados.SelectedIndexChanged += new System.EventHandler(this.lvDados_SelectedIndexChanged);
            this.lvDados.CursorChanged += new System.EventHandler(this.lvDados_CursorChanged);
            this.lvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDados_KeyDown);
            this.lvDados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvDados_KeyUp);
            this.lvDados.Move += new System.EventHandler(this.lvDados_Move);
            // 
            // dvDados
            // 
            this.dvDados.AllowUserToAddRows = false;
            this.dvDados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dvDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dvDados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvDados.Location = new System.Drawing.Point(192, 256);
            this.dvDados.Name = "dvDados";
            this.dvDados.Size = new System.Drawing.Size(754, 306);
            this.dvDados.TabIndex = 79;
            this.dvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDados_CellClick);
            this.dvDados.Click += new System.EventHandler(this.dvDados_Click_1);
            this.dvDados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dvDados_KeyPress);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 18.80342F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.FillWeight = 181.1966F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Histórico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 630;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "idHistorico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // ptbExcluir
            // 
            this.ptbExcluir.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Lixeiras_1414_36__128x128;
            this.ptbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbExcluir.Location = new System.Drawing.Point(15, 568);
            this.ptbExcluir.Name = "ptbExcluir";
            this.ptbExcluir.Size = new System.Drawing.Size(29, 28);
            this.ptbExcluir.TabIndex = 80;
            this.ptbExcluir.TabStop = false;
            this.ptbExcluir.Click += new System.EventHandler(this.ptbExcluir_Click);
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(919, 568);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(27, 28);
            this.ptbCancelar.TabIndex = 78;
            this.ptbCancelar.TabStop = false;
            this.ptbCancelar.Click += new System.EventHandler(this.ptbCancelar_Click);
            // 
            // ptbSalvar
            // 
            this.ptbSalvar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.ok;
            this.ptbSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbSalvar.Location = new System.Drawing.Point(884, 568);
            this.ptbSalvar.Name = "ptbSalvar";
            this.ptbSalvar.Size = new System.Drawing.Size(29, 28);
            this.ptbSalvar.TabIndex = 77;
            this.ptbSalvar.TabStop = false;
            this.ptbSalvar.Click += new System.EventHandler(this.ptbSalvar_Click);
            // 
            // ptbAdicionarGrid
            // 
            this.ptbAdicionarGrid.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources._6141_32x32;
            this.ptbAdicionarGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbAdicionarGrid.Location = new System.Drawing.Point(952, 246);
            this.ptbAdicionarGrid.Name = "ptbAdicionarGrid";
            this.ptbAdicionarGrid.Size = new System.Drawing.Size(24, 26);
            this.ptbAdicionarGrid.TabIndex = 76;
            this.ptbAdicionarGrid.TabStop = false;
            this.ptbAdicionarGrid.Click += new System.EventHandler(this.ptbAdicionarGrid_Click);
            // 
            // ptbLimpar
            // 
            this.ptbLimpar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources._6141_32x32;
            this.ptbLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLimpar.Location = new System.Drawing.Point(448, 20);
            this.ptbLimpar.Name = "ptbLimpar";
            this.ptbLimpar.Size = new System.Drawing.Size(31, 24);
            this.ptbLimpar.TabIndex = 75;
            this.ptbLimpar.TabStop = false;
            this.ptbLimpar.Click += new System.EventHandler(this.ptbLimpar_Click);
            // 
            // ptbBuscar
            // 
            this.ptbBuscar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.lupa;
            this.ptbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbBuscar.Location = new System.Drawing.Point(416, 23);
            this.ptbBuscar.Name = "ptbBuscar";
            this.ptbBuscar.Size = new System.Drawing.Size(34, 21);
            this.ptbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBuscar.TabIndex = 69;
            this.ptbBuscar.TabStop = false;
            this.ptbBuscar.Click += new System.EventHandler(this.ptbBuscar_Click);
            // 
            // Lbl_Excluir_Historico
            // 
            this.Lbl_Excluir_Historico.AutoSize = true;
            this.Lbl_Excluir_Historico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Excluir_Historico.Location = new System.Drawing.Point(192, 569);
            this.Lbl_Excluir_Historico.Name = "Lbl_Excluir_Historico";
            this.Lbl_Excluir_Historico.Size = new System.Drawing.Size(82, 13);
            this.Lbl_Excluir_Historico.TabIndex = 81;
            this.Lbl_Excluir_Historico.Text = "Excluir Histórico";
            this.Lbl_Excluir_Historico.Click += new System.EventHandler(this.Lbl_Excluir_Historico_Click);
            // 
            // lbl_Id_ExcliurHistorico
            // 
            this.lbl_Id_ExcliurHistorico.AutoSize = true;
            this.lbl_Id_ExcliurHistorico.Location = new System.Drawing.Point(192, 586);
            this.lbl_Id_ExcliurHistorico.Name = "lbl_Id_ExcliurHistorico";
            this.lbl_Id_ExcliurHistorico.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_ExcliurHistorico.TabIndex = 82;
            // 
            // tantasDataSet
            // 
            this.tantasDataSet.DataSetName = "tantasDataSet";
            this.tantasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tantasDataSetBindingSource
            // 
            this.tantasDataSetBindingSource.DataSource = this.tantasDataSet;
            this.tantasDataSetBindingSource.Position = 0;
            // 
            // FrmCadastro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 608);
            this.Controls.Add(this.lbl_Id_ExcliurHistorico);
            this.Controls.Add(this.Lbl_Excluir_Historico);
            this.Controls.Add(this.ptbExcluir);
            this.Controls.Add(this.dvDados);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbSalvar);
            this.Controls.Add(this.ptbAdicionarGrid);
            this.Controls.Add(this.ptbLimpar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.lbl_de);
            this.Controls.Add(this.dTP_De);
            this.Controls.Add(this.dt_Ate);
            this.Controls.Add(this.ptbBuscar);
            this.Controls.Add(this.lbl_avisos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvDados);
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.Click += new System.EventHandler(this.FrmCadastro_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastro_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCadastro_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmCadastro_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdicionarGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.MonthCalendar AgendaCompromissos;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txtWebSite;
        private System.Windows.Forms.LinkLabel lknWebSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_de;
        private System.Windows.Forms.DateTimePicker dTP_De;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lbl_proposta;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txt_Razao;
        private System.Windows.Forms.MaskedTextBox mtTelefone;
        private System.Windows.Forms.DateTimePicker dt_Ate;
        private System.Windows.Forms.PictureBox ptbBuscar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lbl_avisos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.ListBox lvDados;
        private System.Windows.Forms.PictureBox ptbLimpar;
        private System.Windows.Forms.PictureBox ptbAdicionarGrid;
        private System.Windows.Forms.PictureBox ptbSalvar;
        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.Label lblLemPessoais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tantasDataSetBindingSource;
        private tantasDataSet tantasDataSet;
        private System.Windows.Forms.DataGridView dvDados;
        private System.Windows.Forms.PictureBox ptbExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label Lbl_Excluir_Historico;
        private System.Windows.Forms.Label lbl_Id_ExcliurHistorico;

    }
}