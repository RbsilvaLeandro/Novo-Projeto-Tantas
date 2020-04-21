namespace Novo_Projeto_Tantas
{
    partial class Frm_ExcluirHistorico
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
            this.GridHist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ptbExcluir = new System.Windows.Forms.PictureBox();
            this.ptbCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridHist
            // 
            this.GridHist.AllowUserToAddRows = false;
            this.GridHist.AllowUserToDeleteRows = false;
            this.GridHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Razao,
            this.Data,
            this.Historico,
            this.excluir});
            this.GridHist.Location = new System.Drawing.Point(12, 12);
            this.GridHist.Name = "GridHist";
            this.GridHist.Size = new System.Drawing.Size(890, 253);
            this.GridHist.TabIndex = 0;
            this.GridHist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHist_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // Razao
            // 
            this.Razao.HeaderText = "Razão Social";
            this.Razao.Name = "Razao";
            this.Razao.Width = 150;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Historico
            // 
            this.Historico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Historico.HeaderText = "Histórico";
            this.Historico.Name = "Historico";
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.Width = 50;
            // 
            // ptbExcluir
            // 
            this.ptbExcluir.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Lixeiras_1414_36__128x128;
            this.ptbExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbExcluir.Location = new System.Drawing.Point(850, 271);
            this.ptbExcluir.Name = "ptbExcluir";
            this.ptbExcluir.Size = new System.Drawing.Size(29, 28);
            this.ptbExcluir.TabIndex = 81;
            this.ptbExcluir.TabStop = false;
            this.ptbExcluir.Click += new System.EventHandler(this.ptbExcluir_Click_1);
            // 
            // ptbCancelar
            // 
            this.ptbCancelar.BackgroundImage = global::Novo_Projeto_Tantas.Properties.Resources.Cancelar;
            this.ptbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbCancelar.Location = new System.Drawing.Point(875, 271);
            this.ptbCancelar.Name = "ptbCancelar";
            this.ptbCancelar.Size = new System.Drawing.Size(27, 28);
            this.ptbCancelar.TabIndex = 82;
            this.ptbCancelar.TabStop = false;
            this.ptbCancelar.Click += new System.EventHandler(this.ptbCancelar_Click);
            // 
            // Frm_ExcluirHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 320);
            this.Controls.Add(this.ptbCancelar);
            this.Controls.Add(this.ptbExcluir);
            this.Controls.Add(this.GridHist);
            this.Name = "Frm_ExcluirHistorico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de histórico";
            this.Load += new System.EventHandler(this.Frm_ExcluirHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridHist;
        private System.Windows.Forms.PictureBox ptbExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Historico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluir;
        private System.Windows.Forms.PictureBox ptbCancelar;
    }
}