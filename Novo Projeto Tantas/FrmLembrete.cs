using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;

namespace Novo_Projeto_Tantas
{
    public partial class FrmLembrete : Form
    {
        public FrmLembrete()
        {
            InitializeComponent();
        }
        public string data = "";

        ClientesBO ClienteMetodo = new ClientesBO();
        ClientesVO cliVO =  new ClientesVO();
        public Boolean CriaLista = false;
        public List<string> listaCompromissos = new List<string>();
        public List<string> listadeExclusaodeCompromissos = new List<string>();

        private void FrmLembrete_Load(object sender, EventArgs e)
        {
         
            chbDesabilitar.Visible = true;
            //txtHora.Text = DateTime.Now.ToShortTimeString();
            lblCliente.Visible = false; txtCliente.Visible = false;
            lblLembretePessoal.Visible = true; rbSim.Visible = true; rbNao.Visible = true;

            lblId.Visible = false;
            lblIdLembrete.Visible = false;
            lblCliente.Visible = false;
            ConsultaRazao();
            string RazaoSocial = txtCliente.Text;
            int idCliente = Convert.ToInt32(lblId.Text);
            data = dateTimePicker1.Text;
            string busca = "MouseClick";
            if (cliVO.ControleAvisos == "1") VerificaCompromissosPessoal(data,busca);
            VerificaCompromissos(RazaoSocial, idCliente, data, busca);
          
        }
        public void carrega_info(ClientesVO cli)
        {
            if (cli.ControleAvisos == "1")
            {
                lblId.Text = "0";
                cliVO.ControleAvisos = cli.ControleAvisos;
            }
            else lblId.Text = cli.codigo.ToString();
            dateTimePicker1.Text = cli.DataCompromisso.ToString();
           
        }
        private void VerificaCompromissos(string RazaoSocial, int idCli, string data, string busca)
        {
            ClientesVO cli = null;
            LinkedList<ClientesVO> ListaCompromissos = new LinkedList<ClientesVO>();

            //Verifica se foi solicitado um usuario pelo seu código
            ListaCompromissos = ClienteMetodo.pesquisaListaCompromissoa(RazaoSocial, idCli, data, busca);

            if (cli != null)
            {
                ListaCompromissos.AddLast(cli);
            }
            else
            {
                foreach (ClientesVO lista in ListaCompromissos)
                {
                    txtNota.Text += lista.lembrete.ToString() + Environment.NewLine;
                    lblIdLembrete.Text = lista.IdLembrete.ToString();
                    listaCompromissos.Add(lista.IdLembrete.ToString());
                    if (lista.Flag == 0)
                    {
                        lblLembrete.Visible = true;                      
                        lblLembrete.ForeColor = Color.Red;
                        chbDesabilitar.Visible = false;
                        lblLembrete.Text = "Lembrete Desabilitado";
                        
                    }
                }
                if (lblId.Text == "0") rbSim.Checked = true;
                busca = ""; listaCompromissos.Clear();
            }
        }
        private void VerificaCompromissosPessoal( string data, string busca)
        {
            
            ClientesVO cli = null;
            LinkedList<ClientesVO> ListaCompromissos = new LinkedList<ClientesVO>();

            //Verifica se foi solicitado um usuario pelo seu código
            ListaCompromissos = ClienteMetodo.pesquisaListaCompromissoPessoal(data,busca);

            if (cli != null)
            {
                ListaCompromissos.AddLast(cli);
            }
            else
            {
                foreach (ClientesVO lista in ListaCompromissos)
                {
                    txtNota.Text += lista.lembrete.ToString() + Environment.NewLine;
                    lblIdLembrete.Text = lista.IdLembrete.ToString();
                    listaCompromissos.Add(lista.IdLembrete.ToString());
                    if (lista.Flag == 0)
                    {
                        lblLembrete.Visible = true;
                        lblLembrete.ForeColor = Color.Red;
                        chbDesabilitar.Visible = false;
                        lblLembrete.Text = "Lembrete Desabilitado";

                    }
                }
                if (lblId.Text == "0") rbSim.Checked = true;
                busca = ""; listaCompromissos.Clear();
            }
        }
      
        private void VerificaCompromissosExc(int idCliente, string dataexc)
        {
            ClientesVO cli = new ClientesVO();

            LinkedList<ClientesVO> ListaCompromissosExc = new LinkedList<ClientesVO>();
            ListaCompromissosExc = null;

            //Verifica se foi solicitado um usuario pelo seu código
            ListaCompromissosExc = ClienteMetodo.pesquisaListaCompromissoExc(idCliente, dataexc);

            if (cli == null)
            {
                ListaCompromissosExc.AddLast(cli);
            }
            else
            {
                if (ListaCompromissosExc.Count > 1)
                {
                    FrmExclusaoLembrete exc = new FrmExclusaoLembrete();

                    foreach (ClientesVO lista in ListaCompromissosExc)
                    {
                        cli.IdLembrete = lista.IdLembrete;
                        cli.lembrete = lista.lembrete;
                        cli.NovoContato = lista.NovoContato;
                        cli.codigo = Convert.ToInt32(lblId.Text);
                        exc.carregaGrid(cli);
                    }
                    exc.Show();
                }
                else ClienteMetodo.ExcluirLembrete(ListaCompromissosExc.First.Value.IdLembrete);
                txtNota.Text = "";
            }
        }
        private void ConsultaRazao()
        {
            if (lblId.Text != "0")
            {
                ClientesVO cli = null;
                int codCliente = Convert.ToInt32(lblId.Text);
                //Verifica se foi solicitado um usuario pelo seu código
                cli = ClienteMetodo.PesquisaRazao(codCliente);

                if (cli == null)
                {
                    cli.Razao = null;
                }

                else
                {
                    txtCliente.Text = cli.Razao;
                }
            }
        }
        private void IncluirLembrete()
        {
            string HorarioCompromisso = dtHora.Text;

            int rot = 0, idCliente = 0;
            DateTime dataCompromisso = Convert.ToDateTime(dateTimePicker1.Value.Date.ToShortDateString());
            if (rbSim.Checked == true) idCliente = 0;
            else idCliente = Convert.ToInt32(lblId.Text);
            string lembrete = txtNota.Text;
            rot = ClienteMetodo.InserirLembrete(dataCompromisso, idCliente, lembrete, listaCompromissos, CriaLista,HorarioCompromisso);
            listaCompromissos.Clear();            
        }
        private void Alterar_Lembrete()
        {
            string horario = dtHora.Text;

            int flag = 0;
            string lembrete = txtNota.Text;
            int idLembreteAlterar = Convert.ToInt32(lblIdLembrete.Text);
            if (chbDesabilitar.Checked == true) flag = 0;
            else flag = 0;

            int rot = 0;
            rot = ClienteMetodo.AlterarLembrete(idLembreteAlterar, lembrete, flag, horario);
        }
        private void ExcluirLembrete()
        {
            ClientesVO cli = new ClientesVO();
            string dataExc = dateTimePicker1.Text; int idCliente = Convert.ToInt32(lblId.Text);
            VerificaCompromissosExc(idCliente, dataExc);
        }
        private void gbLembrete_Enter(object sender, EventArgs e)
        {

        }

        private void ptbCancelar_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            ExcluirLembrete();
        }
       
        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            if (chbDesabilitar.Checked == false)
            {
                if (rbSim.Checked == false && rbNao.Checked == false)
                {
                    MessageBox.Show("Informe o tipo de lembrete?");
                    return;
                }            
            }
            IncluirLembrete();

            string razao = txtCliente.Text, busca = "MouseClick";
            int idClienteCompromisso = Convert.ToInt32(lblId.Text);
            ClientesVO cli = new ClientesVO();
            cli.DataCompromisso = dateTimePicker1.Text;
            cli.codigo = Convert.ToInt32(lblId.Text);
            FrmLembrete lembrete = new FrmLembrete();
            txtNota.Text = "";
            VerificaCompromissos(razao, cli.codigo, cli.DataCompromisso, busca);           

        }

        private void ptbGrid_Click(object sender, EventArgs e)
        {
            CriaLista = true;
            
            if (!String.IsNullOrEmpty(txtNota.Text))
            {
                if (lblIdLembrete.Text == "")
                {
                    string horario = dtHora.Text;

                    listaCompromissos.Add(data);
                    listaCompromissos.Add(txtNota.Text);
                    listaCompromissos.Add(horario);
                }
                lblIdLembrete.Text = "";
            }
            txtNota.Text = "";
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        
        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            lblCliente.Visible = true; txtCliente.Visible = true;
            rbNao.Visible = false; rbSim.Visible = false;
            lblLembretePessoal.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbLembrete_Enter_1(object sender, EventArgs e)
        {

        }

       

    }
}
