using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Projeto_Tantas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        UsuarioBO usuarioLogado = new UsuarioBO();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 50;
            txtSenha.MaxLength = 50;          
            verificaFlag();
        }

        private void ptbOk_Click(object sender, EventArgs e)
        {
            verficaAcesso();
        }
        private void verficaAcesso()
        {
            usuarioLogado.usu_login = txtUsuario.Text;
            usuarioLogado.senhaUsuario = txtSenha.Text;
            int FlagSenha = 0;
            if (ckbLembrarsenha.Checked == true) FlagSenha = 1;

            if (usuarioLogado.conectar(FlagSenha) == true)
            {
                usuarioLogado.usu_login = txtUsuario.Text;
                FrmMenu menu = new FrmMenu();
                menu.usuarioLogado = this.usuarioLogado;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                txtSenha.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }
        private void verificaFlag()
        {
            UsuarioVO usuSenha = new UsuarioVO();
            usuSenha = usuarioLogado.verificaFlag();

            if (usuSenha != null)
            {
                txtUsuario.Text = usuSenha.usu_login;
                txtSenha.Text = usuSenha.senhaUsuario;
                ckbLembrarsenha.Checked = true;
            }
            else ckbLembrarsenha.Checked = false;
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            verificaFlag();
        }

        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lnkesqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueciMinhaSenha senha = new FrmEsqueciMinhaSenha();
            senha.Show();
        }

    }
}
