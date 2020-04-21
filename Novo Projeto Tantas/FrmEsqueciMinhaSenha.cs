using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Novo_Projeto_Tantas
{
    public partial class FrmEsqueciMinhaSenha : Form
    {
        public FrmEsqueciMinhaSenha()
        {
            InitializeComponent();
        }

        private void FrmEsqueciMinhaSenha_Load(object sender, EventArgs e)
        {
            txt_emailEsqueciSenha.MaxLength = 50;
        }
        UsuarioBO usuEmail = new UsuarioBO();
        // private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }
        private void EsqueciMinhaSenha()
        {
            string email = txt_emailEsqueciSenha.Text.Trim();
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(email))
            {
                lbl_MSGERRO.Text = "Email inválido";
                lbl_MSGERRO.ForeColor = System.Drawing.Color.Red;
                lbl_MSGERRO.Visible = true;
                ptbErro.Visible = true;
                return;
            }

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Informe o email");
                txt_emailEsqueciSenha.Focus();
                return;
            }
            if (IsConnected())
            {
                usuEmail.EsqueciminhaSenha(email);
            }
            else
            {
                MessageBox.Show("Este computador não está conectado a internet, habilite a conexão e tente novamente");
            }

            this.Close();
        }

        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            EsqueciMinhaSenha();
        }

    }
}
