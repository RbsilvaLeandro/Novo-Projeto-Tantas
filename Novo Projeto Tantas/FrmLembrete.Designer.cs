namespace Novo_Projeto_Tantas
{
    partial class FrmLembrete
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
            this.gbLembrete = new System.Windows.Forms.GroupBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lbl_dataCompromisso = new System.Windows.Forms.Label();
            this.chbDesabilitar = new System.Windows.Forms.CheckBox();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbSalvar = new System.Windows.Forms.PictureBox();
            this.lblIdLembrete = new System.Windows.Forms.Label();
            this.ptbGrid = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblLembrete = new System.Windows.Forms.Label();
            this.lblLembretePessoal = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.gbLembrete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLembrete
            // 
            this.gbLembrete.Controls.Add(this.txtNota);
            this.gbLembrete.Location = new System.Drawing.Point(15, 52);
            this.gbLembrete.Name = "gbLembrete";
            this.gbLembrete.Size = new System.Drawing.Size(273, 116);
            this.gbLembrete.TabIndex = 71;
            this.gbLembrete.TabStop = false;
            this.gbLembrete.Enter += new System.EventHandler(this.gbLembrete_Enter_1);
            // 
            // txtNota
            // 
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(7, 19);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNota.Size = new System.Drawing.Size(259, 88);
            this.txtNota.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 197);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 70;
            this.lblId.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(54, 26);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(227, 26);
            this.txtCliente.TabIndex = 69;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 68;
            this.lblCliente.Text = "Cliente :";
            // 
            // lbl_dataCompromisso
            // 
            this.lbl_dataCompromisso.AutoSize = true;
            this.lbl_dataCompromisso.Location = new System.Drawing.Point(12, 9);
            this.lbl_dataCompromisso.Name = "lbl_dataCompromisso";
            this.lbl_dataCompromisso.Size = new System.Drawing.Size(36, 13);
            this.lbl_dataCompromisso.TabIndex = 66;
            this.lbl_dataCompromisso.Text = "Data :";
            // 
            // chbDesabilitar
            // 
            this.chbDesabilitar.AutoSize = true;
            this.chbDesabilitar.Location = new System.Drawing.Point(15, 191);
            this.chbDesabilitar.Name = "chbDesabilitar";
            this.chbDesabilitar.Size = new System.Drawing.Size(122, 17);
            this.chbDesabilitar.TabIndex = 76;
            this.chbDesabilitar.Text = "Desabilitar Lembrete";
            this.chbDesabilitar.UseVisualStyleBackColor = true;
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(256, 190);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(25, 28);
            this.ptbCancelar.TabIndex = 73;
            this.ptbCancelar.TabStop = false;
            this.ptbCancelar.ClientSizeChanged += new System.EventHandler(this.ptbCancelar_ClientSizeChanged);
            this.ptbCancelar.Click += new System.EventHandler(this.ptbCancelar_Click);
            // 
            // ptbSalvar
            // 
            this.ptbSalvar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.ok;
            this.ptbSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbSalvar.Location = new System.Drawing.Point(227, 190);
            this.ptbSalvar.Name = "ptbSalvar";
            this.ptbSalvar.Size = new System.Drawing.Size(25, 28);
            this.ptbSalvar.TabIndex = 72;
            this.ptbSalvar.TabStop = false;
            this.ptbSalvar.Click += new System.EventHandler(this.ptbSalvar_Click);
            // 
            // lblIdLembrete
            // 
            this.lblIdLembrete.AutoSize = true;
            this.lblIdLembrete.Location = new System.Drawing.Point(22, 176);
            this.lblIdLembrete.Name = "lblIdLembrete";
            this.lblIdLembrete.Size = new System.Drawing.Size(0, 13);
            this.lblIdLembrete.TabIndex = 75;
            // 
            // ptbGrid
            // 
            this.ptbGrid.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources._6141_32x32;
            this.ptbGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbGrid.Location = new System.Drawing.Point(139, 3);
            this.ptbGrid.Name = "ptbGrid";
            this.ptbGrid.Size = new System.Drawing.Size(23, 20);
            this.ptbGrid.TabIndex = 74;
            this.ptbGrid.TabStop = false;
            this.ptbGrid.Click += new System.EventHandler(this.ptbGrid_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 67;
            this.dateTimePicker1.Value = new System.DateTime(2014, 4, 4, 0, 0, 0, 0);
            // 
            // lblLembrete
            // 
            this.lblLembrete.AutoSize = true;
            this.lblLembrete.Location = new System.Drawing.Point(24, 196);
            this.lblLembrete.Name = "lblLembrete";
            this.lblLembrete.Size = new System.Drawing.Size(0, 13);
            this.lblLembrete.TabIndex = 77;
            // 
            // lblLembretePessoal
            // 
            this.lblLembretePessoal.AutoSize = true;
            this.lblLembretePessoal.Location = new System.Drawing.Point(12, 33);
            this.lblLembretePessoal.Name = "lblLembretePessoal";
            this.lblLembretePessoal.Size = new System.Drawing.Size(100, 13);
            this.lblLembretePessoal.TabIndex = 78;
            this.lblLembretePessoal.Text = "Lembrete Pessoal ?";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(118, 29);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 79;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(166, 29);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 80;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(22, 171);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(47, 13);
            this.lblHorario.TabIndex = 82;
            this.lblHorario.Text = "Horário :";
            // 
            // dtHora
            // 
            this.dtHora.Checked = false;
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtHora.Location = new System.Drawing.Point(67, 166);
            this.dtHora.Name = "dtHora";
            this.dtHora.ShowUpDown = true;
            this.dtHora.Size = new System.Drawing.Size(70, 20);
            this.dtHora.TabIndex = 84;
            this.dtHora.Value = new System.DateTime(2014, 4, 6, 11, 31, 0, 0);
            this.dtHora.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // FrmLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 242);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.lblLembretePessoal);
            this.Controls.Add(this.lblLembrete);
            this.Controls.Add(this.gbLembrete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lbl_dataCompromisso);
            this.Controls.Add(this.chbDesabilitar);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbSalvar);
            this.Controls.Add(this.lblIdLembrete);
            this.Controls.Add(this.ptbGrid);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FrmLembrete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLembrete_Load);
            this.gbLembrete.ResumeLayout(false);
            this.gbLembrete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLembrete;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lbl_dataCompromisso;
        private System.Windows.Forms.CheckBox chbDesabilitar;
        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.PictureBox ptbSalvar;
        private System.Windows.Forms.Label lblIdLembrete;
        private System.Windows.Forms.PictureBox ptbGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblLembrete;
        private System.Windows.Forms.Label lblLembretePessoal;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DateTimePicker dtHora;
    }
}