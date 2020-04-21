namespace Novo_Projeto_Tantas
{
    partial class FrmExclusaoLembrete
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
            this.GridLembretes = new System.Windows.Forms.DataGridView();
            this.idLembrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lembrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmaexclusao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblExclusaoLembrete = new System.Windows.Forms.Label();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            this.ptbSalvar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridLembretes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLembretes
            // 
            this.GridLembretes.AllowUserToAddRows = false;
            this.GridLembretes.AllowUserToDeleteRows = false;
            this.GridLembretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLembretes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLembrete,
            this.data,
            this.lembrete,
            this.confirmaexclusao});
            this.GridLembretes.Location = new System.Drawing.Point(16, 33);
            this.GridLembretes.Name = "GridLembretes";
            this.GridLembretes.Size = new System.Drawing.Size(554, 150);
            this.GridLembretes.TabIndex = 0;
            this.GridLembretes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLembretes_CellClick);
            // 
            // idLembrete
            // 
            this.idLembrete.HeaderText = "ID";
            this.idLembrete.Name = "idLembrete";
            this.idLembrete.Width = 50;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 70;
            // 
            // lembrete
            // 
            this.lembrete.HeaderText = "Lembrete";
            this.lembrete.Name = "lembrete";
            this.lembrete.Width = 340;
            // 
            // confirmaexclusao
            // 
            this.confirmaexclusao.HeaderText = "Excluir";
            this.confirmaexclusao.Name = "confirmaexclusao";
            this.confirmaexclusao.Width = 50;
            // 
            // lblExclusaoLembrete
            // 
            this.lblExclusaoLembrete.AutoSize = true;
            this.lblExclusaoLembrete.Location = new System.Drawing.Point(13, 14);
            this.lblExclusaoLembrete.Name = "lblExclusaoLembrete";
            this.lblExclusaoLembrete.Size = new System.Drawing.Size(195, 13);
            this.lblExclusaoLembrete.TabIndex = 1;
            this.lblExclusaoLembrete.Text = "Selecione o lembrete que deseja Excluir";
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(543, 189);
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
            this.ptbSalvar.Location = new System.Drawing.Point(510, 189);
            this.ptbSalvar.Name = "ptbSalvar";
            this.ptbSalvar.Size = new System.Drawing.Size(27, 28);
            this.ptbSalvar.TabIndex = 79;
            this.ptbSalvar.TabStop = false;
            this.ptbSalvar.Click += new System.EventHandler(this.ptbSalvar_Click);
            // 
            // FrmExclusaoLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 235);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbSalvar);
            this.Controls.Add(this.lblExclusaoLembrete);
            this.Controls.Add(this.GridLembretes);
            this.Name = "FrmExclusaoLembrete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmExclusaoLembrete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLembretes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLembretes;
        private System.Windows.Forms.Label lblExclusaoLembrete;
        private System.Windows.Forms.PictureBox ptbCancelar;
        private System.Windows.Forms.PictureBox ptbSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLembrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn lembrete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmaexclusao;
    }
}