namespace Novo_Projeto_Tantas
{
    partial class FrmEsqueciMinhaSenha
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
            this.lblEmailEsqueciMinhaSenha = new System.Windows.Forms.Label();
            this.txt_emailEsqueciSenha = new System.Windows.Forms.TextBox();
            this.ptbErro = new System.Windows.Forms.PictureBox();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbSalvar = new System.Windows.Forms.PictureBox();
            this.lbl_MSGERRO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmailEsqueciMinhaSenha
            // 
            this.lblEmailEsqueciMinhaSenha.AutoSize = true;
            this.lblEmailEsqueciMinhaSenha.Location = new System.Drawing.Point(12, 18);
            this.lblEmailEsqueciMinhaSenha.Name = "lblEmailEsqueciMinhaSenha";
            this.lblEmailEsqueciMinhaSenha.Size = new System.Drawing.Size(38, 13);
            this.lblEmailEsqueciMinhaSenha.TabIndex = 81;
            this.lblEmailEsqueciMinhaSenha.Text = "Email :";
            // 
            // txt_emailEsqueciSenha
            // 
            this.txt_emailEsqueciSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emailEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailEsqueciSenha.Location = new System.Drawing.Point(47, 12);
            this.txt_emailEsqueciSenha.Name = "txt_emailEsqueciSenha";
            this.txt_emailEsqueciSenha.Size = new System.Drawing.Size(232, 26);
            this.txt_emailEsqueciSenha.TabIndex = 82;
            // 
            // ptbErro
            // 
            this.ptbErro.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.icoAlertaVermelho;
            this.ptbErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbErro.Location = new System.Drawing.Point(285, 12);
            this.ptbErro.Name = "ptbErro";
            this.ptbErro.Size = new System.Drawing.Size(27, 20);
            this.ptbErro.TabIndex = 83;
            this.ptbErro.TabStop = false;
            this.ptbErro.Visible = false;
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(252, 44);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(27, 28);
            this.ptbCancelar.TabIndex = 80;
            this.ptbCancelar.TabStop = false;
            this.ptbCancelar.Click += new System.EventHandler(this.ptbCancelar_Click);
            // 
            // ptbSalvar
            // 
            this.ptbSalvar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.ok;
            this.ptbSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbSalvar.Location = new System.Drawing.Point(226, 44);
            this.ptbSalvar.Name = "ptbSalvar";
            this.ptbSalvar.Size = new System.Drawing.Size(27, 28);
            this.ptbSalvar.TabIndex = 79;
            this.ptbSalvar.TabStop = false;
            this.ptbSalvar.Click += new System.EventHandler(this.ptbSalvar_Click);
            // 
            // lbl_MSGERRO
            // 
            this.lbl_MSGERRO.AutoSize = true;
            this.lbl_MSGERRO.Location = new System.Drawing.Point(15, 38);
            this.lbl_MSGERRO.Name = "lbl_MSGERRO";
            this.lbl_MSGERRO.Size = new System.Drawing.Size(0, 13);
            this.lbl_MSGERRO.TabIndex = 84;
            // 
            // FrmEsqueciMinhaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 76);
            this.Controls.Add(this.lbl_MSGERRO);
            this.Controls.Add(this.ptbErro);
            this.Controls.Add(this.txt_emailEsqueciSenha);
            this.Controls.Add(this.lblEmailEsqueciMinhaSenha);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbSalvar);
            this.Name = "FrmEsqueciMinhaSenha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEsqueciMinhaSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.PictureBox ptbSalvar;
        private System.Windows.Forms.Label lblEmailEsqueciMinhaSenha;
        private System.Windows.Forms.TextBox txt_emailEsqueciSenha;
        private System.Windows.Forms.PictureBox ptbErro;
        private System.Windows.Forms.Label lbl_MSGERRO;
    }
}