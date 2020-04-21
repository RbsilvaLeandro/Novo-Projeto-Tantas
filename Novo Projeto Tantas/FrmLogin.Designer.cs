namespace Novo_Projeto_Tantas
{
    partial class frmLogin
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbOk = new System.Windows.Forms.PictureBox();
            this.ptbLogin = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.ckbLembrarsenha = new System.Windows.Forms.CheckBox();
            this.lnkesqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtSenha);
            this.gbLogin.Controls.Add(this.lblSenha);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Location = new System.Drawing.Point(237, 76);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(277, 80);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(72, 44);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(186, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 46);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(72, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário :";
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(487, 162);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(27, 28);
            this.ptbCancelar.TabIndex = 5;
            this.ptbCancelar.TabStop = false;
            this.ptbCancelar.Click += new System.EventHandler(this.ptbCancelar_Click);
            // 
            // ptbOk
            // 
            this.ptbOk.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.ok;
            this.ptbOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbOk.Location = new System.Drawing.Point(456, 162);
            this.ptbOk.Name = "ptbOk";
            this.ptbOk.Size = new System.Drawing.Size(27, 28);
            this.ptbOk.TabIndex = 4;
            this.ptbOk.TabStop = false;
            this.ptbOk.Click += new System.EventHandler(this.ptbOk_Click);
            // 
            // ptbLogin
            // 
            this.ptbLogin.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Login;
            this.ptbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogin.Location = new System.Drawing.Point(12, 12);
            this.ptbLogin.Name = "ptbLogin";
            this.ptbLogin.Size = new System.Drawing.Size(219, 188);
            this.ptbLogin.TabIndex = 0;
            this.ptbLogin.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(336, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 33);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Tantas";
            // 
            // ckbLembrarsenha
            // 
            this.ckbLembrarsenha.AutoSize = true;
            this.ckbLembrarsenha.Location = new System.Drawing.Point(12, 206);
            this.ckbLembrarsenha.Name = "ckbLembrarsenha";
            this.ckbLembrarsenha.Size = new System.Drawing.Size(98, 17);
            this.ckbLembrarsenha.TabIndex = 3;
            this.ckbLembrarsenha.Text = "Lembrar Senha";
            this.ckbLembrarsenha.UseVisualStyleBackColor = true;
            // 
            // lnkesqueciMinhaSenha
            // 
            this.lnkesqueciMinhaSenha.AutoSize = true;
            this.lnkesqueciMinhaSenha.Location = new System.Drawing.Point(404, 210);
            this.lnkesqueciMinhaSenha.Name = "lnkesqueciMinhaSenha";
            this.lnkesqueciMinhaSenha.Size = new System.Drawing.Size(110, 13);
            this.lnkesqueciMinhaSenha.TabIndex = 4;
            this.lnkesqueciMinhaSenha.TabStop = true;
            this.lnkesqueciMinhaSenha.Text = "Esqueci minha Senha";
            this.lnkesqueciMinhaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkesqueciMinhaSenha_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(518, 232);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbOk);
            this.Controls.Add(this.lnkesqueciMinhaSenha);
            this.Controls.Add(this.ckbLembrarsenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.ptbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogin;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.PictureBox ptbOk;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox ckbLembrarsenha;
        private System.Windows.Forms.LinkLabel lnkesqueciMinhaSenha;
    }
}

