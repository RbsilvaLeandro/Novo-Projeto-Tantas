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

namespace Novo_Projeto_Tantas
{
    public partial class FrmEnviodeEmail : Form
    {
        ClientesBO cli;
        public List<string> listaanexos = new List<string>();
        public List<string> ListaCC = new List<string>();
        
        public FrmEnviodeEmail()
        {
            InitializeComponent();
        }
        public void carregaEmail(ClientesVO cli)
        {
            txtPara.Text = cli.Destinatario;
        }
        private void FrmEnviodeEmail_Load(object sender, EventArgs e)
        {
            txtPara.MaxLength = 50; txtAssunto.MaxLength = 50; txtCC.MaxLength = 1000; txtMensagem.MaxLength = 1000;
        }
        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");         

                if (expressaoRegex.IsMatch(texto_Validar))
                {                   
                    return true;
                }
                else
                {                  
                   return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            string Destinatario = txtPara.Text, CC = txtCC.Text, Assunto = txtAssunto.Text, Mensagem = txtMensagem.Text;
            
            if (!String.IsNullOrEmpty(txtCC.Text))
            { 
             
                string[] listaCopia = CC.Split(';');
                foreach (string copias in listaCopia)
                {
                    ListaCC.Add(copias);
                }
            }
            if(txtAssunto.Text == "")
            {
                MessageBox.Show("Informe o assunto do email");
                return;
            }
            if(txtMensagem.Text == "")
            {
                MessageBox.Show("Informe a mensagem");
                return;
            }
            if (txtPara.Text != "")
            {
               EnviaEmail email = new EnviaEmail();
               if (ValidaEnderecoEmail(txtPara.Text) == true)
               {
                   if (email.EnviarEmailCliente(Destinatario, ListaCC, Assunto, Mensagem,listaanexos) == true) ;
                   ListaCC.Clear();
                   listaanexos.Clear();
                   MessageBox.Show("Mensagem enviada com successo");
               }
               else
                   MessageBox.Show("Email informado inválido");
                   return;
            }
            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {            
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            listaanexos.Add(openFileDialog1.FileName);
        }
    }
}
