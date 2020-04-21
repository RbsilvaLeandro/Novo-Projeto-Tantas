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
using System.Net.Mail;



namespace Novo_Projeto_Tantas
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        public int Controle = 0, idCliente = 0;
        public List<string> avisos = new List<string>();
        public string dataCompromisso = "", compromisso = ""; int idClienteCompromisso = 0;
        public int controleAvisos = 0, edicaoGrid = 0;

        public UsuarioBO UsuLogado = new UsuarioBO();

        ClientesVO cli = new ClientesVO();
        string busca = "";

        ClientesBO cliente = new ClientesBO();

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtBusca.MaxLength = 50; txt_Razao.MaxLength = 100; txtEmail.MaxLength = 100; txtWebSite.MaxLength = 50; txtContato.MaxLength = 50;
            txtCidade.MaxLength = 1000; txtEndereco.MaxLength = 200; txtNumero.MaxLength = 10;

            ClientesVO cli = new ClientesVO();
            if (rbNome.Checked == true)
            {
                lbl_A.Visible = false;
                lbl_de.Visible = false;
                dt_Ate.Visible = false;
                dTP_De.Visible = false;
                txtBusca.Visible = true;
            }

            dTP_De.Text = DateTime.Now.AddMonths(-1).ToShortDateString();
            PesquisaCliente(cli);
            if (lvDados.Items.Count != 0) lvDados.SelectedIndex = 0;
            if (lvDados.SelectedItem != null)
            {
                lbl_Id.Visible = false;
                String razao = lvDados.SelectedItem.ToString();
                Controle = 1;
                pesquisarListaCliente(razao, Controle);
                lvDados.Focus();
                string data = "";
                idCliente = Convert.ToInt32(lbl_Id.Text);
                VerificaCompromissos(razao, idCliente, data, busca);
            }
            
            
        }
        #region Metodos
        private void pesquisarListaCliente(string Razao, int controle)
        {
            string nomeCli = "";
            ClientesVO cli = null; LinkedList<ClientesVO> listaClientes = new LinkedList<ClientesVO>();

            //Verifica se foi solicitado um usuario pelo seu código
            try
            {
                if (Controle != 0) nomeCli = Razao;
                else nomeCli = txtBusca.Text.Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente não encontrado!");
                txtBusca.Focus();
                return;
            }
            listaClientes = cliente.pesquisaListaClientes(nomeCli, controle);

            if (cli != null)
            {
                listaClientes.AddLast(cli);
            }
            if (listaClientes == null || listaClientes.Count() == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
            else
            {
                lbl_Id.Visible = false;
                dvDados.AutoGenerateColumns = false;
                dvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dvDados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                //altera a cor das linhas alternadas no grid
                dvDados.RowsDefaultCellStyle.BackColor = Color.White;
                dvDados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                foreach (ClientesVO lista in listaClientes)
                {
                    if (lista.data != "") dvDados.Rows.Add(lista.data.Substring(0, 10), lista.Historico, lista.IdHistorico);
                }
                string web = listaClientes.First.Value.webSite;

                txt_Razao.Text = listaClientes.First.Value.Razao; txtEndereco.Text = listaClientes.First.Value.Enderco;
                txtNumero.Text = listaClientes.First.Value.Numero; txtWebSite.Text = web;
                txtContato.Text = listaClientes.First.Value.Contato; txtEmail.Text = listaClientes.First.Value.Email;
                mtTelefone.Text = listaClientes.First.Value.Telefone; lbl_Id.Text = listaClientes.First.Value.codigo.ToString();
                txtCidade.Text = listaClientes.First.Value.Cidade;
            }
        }
        private void PesquisaCliente(ClientesVO cli)
        {
            //ClientesVO cli = null;
            LinkedList<ClientesVO> listaRazaoSocial = new LinkedList<ClientesVO>();
            if (rbNome.Checked == true) cli.ParametrodePesquisa = "1";//Busca por Nome
            else if (rbData.Checked == true)
            {
                cli.ParametrodePesquisa = "2";//Busca por data
                cli.inicio = Convert.ToDateTime(dTP_De.Text);
                cli.fim = Convert.ToDateTime(dt_Ate.Text);
            }
            lvDados.Items.Clear();
            //Verifica se foi solicitado um usuario pelo seu código
            listaRazaoSocial = cliente.pesquisaCliente(cli);

            if (cli != null)
            {
                cli.Razao = null;
                listaRazaoSocial.AddLast(cli);
            }
            if (listaRazaoSocial == null || listaRazaoSocial.Count() == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
            else
            {
                foreach (ClientesVO lista in listaRazaoSocial)
                {
                    if (lista.Razao != null)
                    {
                        if (!lvDados.Items.Contains(lista.Razao))
                        {
                            lvDados.Items.Add(lista.Razao);
                        }
                    }
                }
                if (cli.ParametrodePesquisa == "2" && lvDados.Items.Count > 0)
                {
                    lvDados.SelectedIndex = 0;
                }
                //if (listaRazaoSocial.First.Value.Razao != null) ;
            }
        }
        private void LimparDados()
        {
            txt_Razao.Text = ""; txtWebSite.Text = ""; txtContato.Text = ""; txtEmail.Text = ""; txtEndereco.Text = ""; txtHistorico.Text = "";
            txtNumero.Text = ""; txtCidade.Text = "";mtTelefone.Text = "";
            AgendaCompromissos.RemoveAllBoldedDates(); AgendaCompromissos.UpdateBoldedDates();
        }
        private void IncluirCliente()
        {
            try
            {
                lbl_Id.Visible = false;

                List<string> ListadvDados = new List<string>();
                int codCliente = 0, codCli = 0;
                string RazaoSocial = txt_Razao.Text, EnderecoCliente = txtEndereco.Text.Trim(), Numero = txtNumero.Text.Trim(), Telefone = mtTelefone.Text.Trim();
                string Website = txtWebSite.Text.Trim(), Contato = txtContato.Text.Trim(), Email = txtEmail.Text.Trim(); DateTime novoContato = AgendaCompromissos.SelectionStart; string Historico = "";
                if (lbl_Id.Text != "") codCli = int.Parse(lbl_Id.Text); string Cidade = txtCidade.Text;


                if (!String.IsNullOrEmpty(Website))
                {
                    Regex RgxUrl = new Regex("(([a-zA-Z][0-9a-zA-Z+\\-\\.]*:)?/{0,2}[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?(#[0-9a-zA-Z;/?:@&=+$\\.\\-_!~*'()%]+)?");
                    if (!RgxUrl.IsMatch(Website)) MessageBox.Show("Endereço Web inválido");
                }
                if (String.IsNullOrEmpty(RazaoSocial))
                {
                    MessageBox.Show("Informe a Razao Social");
                    txt_Razao.Focus();

                    return  ;
                }
                if (String.IsNullOrEmpty(EnderecoCliente))
                {
                    MessageBox.Show("Informe o endereço do cliente");
                    txtEndereco.Text.Trim();
                    return ;
                }
                if (String.IsNullOrEmpty(Contato))
                {
                    MessageBox.Show("Informe o Contato");
                    txtContato.Focus();
                    return ;
                }
                if (String.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Informe o Email");
                    txtEmail.Focus();
                    return ;
                }

                if (txtHistorico.Text != "" && edicaoGrid == 0)
                {
                    if (txtHistorico.Text != "") Historico = txtHistorico.Text;
                    cli =  cliente.InserirCliente(RazaoSocial, EnderecoCliente, Numero, Contato, Email, Website, Telefone, Historico, Cidade, codCli, novoContato, ListadvDados);
                }
                if (txtHistorico.Text != "" && edicaoGrid == 1)
                {
                    if (txtHistorico.Text != "") Historico = txtHistorico.Text;
                    cli = cliente.InserirCliente(RazaoSocial, EnderecoCliente, Numero, Contato, Email, Website, Telefone, Historico, Cidade, codCli, novoContato, ListadvDados);
                }
                if (txtHistorico.Text == "" && edicaoGrid == 0)
                {
                    cli = cliente.InserirCliente(RazaoSocial, EnderecoCliente, Numero, Contato, Email, Website, Telefone, Historico, Cidade, codCli, novoContato, ListadvDados);
                }

                else
                {
                    int teste = dvDados.RowCount;
                    if (txtHistorico.Text == "" && edicaoGrid == 1)
                    {
                        DataGridViewCell celula = null;
                        for (int i = 0; i < dvDados.RowCount; i++)
                        {
                            for (int x = 0; x < dvDados.ColumnCount; x++)
                            {
                                // obtém a célula na coluna x e linha i
                              
                                celula = dvDados[x, i];

                                    if (x == 1 && celula.Value == null)
                                    {
                                        celula.Value = "";
                                        MessageBox.Show("Existem ítens do histórico sem digitação");
                                        return;
                                    }
                               if(celula.Value != null)  ListadvDados.Add(celula.Value.ToString());
                                
                            }
                            cli = cliente.InserirCliente(RazaoSocial, EnderecoCliente, Numero, Contato, Email, Website, Telefone, Historico, Cidade, codCli, novoContato, ListadvDados);
                            ListadvDados.Clear();
                        }
                    }
                }
                if (codCliente == -1 || codCliente < 0)
                {
                    MessageBox.Show("Você possui colunas em branco");
                    return ;
                }
                else
                {
                    txt_Razao.Focus();
                }
            }
            catch
            {            
                MessageBox.Show("Houve um problema ao inserir o registro especificado");
                return ;
            }
        }
        private void VerificaCompromissoaPessoais()
        {
            string dataCompromissoPessoal = "";
            AgendaCompromissos.RemoveAllBoldedDates();

            ClientesVO cli = null;
            LinkedList<ClientesVO> ListaCompromissoPessoal = new LinkedList<ClientesVO>();
            try
            {
                if (busca != "") dataCompromissoPessoal = AgendaCompromissos.SelectionStart.ToShortDateString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Compromisso encontrado!");
                txtBusca.Focus();
                return;
            }
            ListaCompromissoPessoal = cliente.pesquisaListaCompromissoPessoal(dataCompromissoPessoal, busca);

            if (cli != null)
            {
                ListaCompromissoPessoal.AddLast(cli);
            }
            else
            {
                if (ListaCompromissoPessoal.Count == 0)
                {
                    AgendaCompromissos.RemoveAllBoldedDates();
                    AgendaCompromissos.UpdateBoldedDates();
                }
                foreach (ClientesVO lista in ListaCompromissoPessoal)
                {
                    AgendaCompromissos.AddBoldedDate(lista.NovoContato);
                    AgendaCompromissos.UpdateBoldedDates();
                }
            }

        }
        private void VerificaCompromissos(string RazaoSocial, int idCli, string data, string busca)
        {
            AgendaCompromissos.RemoveAllBoldedDates();
            string nomeCli = "";
            if (busca != "") data = AgendaCompromissos.SelectionStart.ToShortDateString();
            ClientesVO cli = null;
            LinkedList<ClientesVO> ListaCompromissos = new LinkedList<ClientesVO>();
            lbl_Id.Visible = false;
            //Verifica se foi solicitado um usuario pelo seu código
            try
            {
                nomeCli = RazaoSocial;
                idCliente = Convert.ToInt32(lbl_Id.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Compromisso encontrado!");
                txtBusca.Focus();
                return;
            }
            ListaCompromissos = cliente.pesquisaListaCompromissoa(nomeCli, idCliente, data, busca);

            if (cli != null)
            {
                ListaCompromissos.AddLast(cli);
            }
            else
            {
                if (ListaCompromissos.Count == 0)
                {
                    AgendaCompromissos.RemoveAllBoldedDates();
                    AgendaCompromissos.UpdateBoldedDates();
                }
                foreach (ClientesVO lista in ListaCompromissos)
                {
                    AgendaCompromissos.AddBoldedDate(lista.NovoContato);
                    AgendaCompromissos.UpdateBoldedDates();
                }
            }
        }
        private void pesquisaUltimoCliente()
        {
            cliente.PesquisaUltimoCliente();
        }
        private void DesativarCliente()
        {
            try
            {
                int idcliente = 0;
                lbl_Id.Visible = false;
                if(lbl_Id.Text !="")
                {
                    idcliente = Convert.ToInt32(lbl_Id.Text);
                    if (cliente.DesativarCliente(idcliente) == 0) ;
                    {
                        PesquisaCliente(cli);
                    }
                    dvDados.Rows.Clear();
                    if (lvDados.Items.Count > 0)
                    {
                        lvDados.SelectedIndex = 0;
                        string razao = lvDados.SelectedItem.ToString();
                        pesquisarListaCliente(razao, Controle);
                    }

                }               
                else
                {
                    MessageBox.Show("Nenhum registro selecionado");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Houve um problema ao inserir o registro especificado");
                return;
            }
        }
        private void ExcluirHistoricoIndividual(string idHist)
        {
            try
            {
                if (!string.IsNullOrEmpty(idHist))
                {
                    if (cliente.ExcluirHistoricoIndividual(idHist) != null) 
                    {
                        dvDados.Rows.Clear();
                        string razao = lvDados.SelectedItem.ToString();
                        pesquisarListaCliente(razao, Controle);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro selecionado");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Houve um problema ao inserir o registro especificado");
                return;
            }
        }


        #endregion
        #region Eventos
        private void lvDados_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = "";
            lbl_avisos.Text = "Avisos Importatntes";
            busca = "";
            controleAvisos = 0;
            lbl_Id.Visible = false;
            dvDados.Rows.Clear();
            ClientesVO cliVO = new ClientesVO();
            cliVO.Razao = lvDados.SelectedItem.ToString();
            Controle = 1;
            pesquisarListaCliente(cliVO.Razao, Controle);
            int id = Convert.ToInt32(lbl_Id.Text); string data = "";
            VerificaCompromissos(cliVO.Razao, id, data, busca);
        }
        private void ptbLimpar_Click(object sender, EventArgs e)
        {
            lvDados.ClearSelected();
            LimparDados();
        }
        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            String razao = "";
            dvDados.EndEdit();
       

            try
            {
                IncluirCliente();
                if(cli.TipoOperacao != null)
                {      
                    if (cli.TipoOperacao == "Inserir")
                    {
                        cli.Razao = null;
                        PesquisaCliente(cli);
                        razao = cliente.PesquisaUltimoCliente();
                        dvDados.Rows.Clear();
                        int contagemItems = lvDados.Items.Count;
                        if (lvDados.Items.Count != 0)
                        {
                            int contador = 0, index = 0;
                            foreach (var lc in lvDados.Items)
                            {
                                if (lc.Equals(razao))
                                {
                                    index = contador;
                                }
                                contador++;
                            }
                            lvDados.SelectedIndex = index;
                            razao = lvDados.SelectedItem.ToString();
                        }
                        Controle = 1;
                        pesquisarListaCliente(razao, Controle);
                        cli.TipoOperacao = "";
                    }
                    if (cli.TipoOperacao == "Alterar")
                    {
                        dvDados.Rows.Clear();
                        razao = lvDados.SelectedItem.ToString();
                        Controle = 1;
                        pesquisarListaCliente(razao, Controle);
                        cli.TipoOperacao = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Houve uma falha na listagem de clientes");
            }
        }
        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lvDados_Move(object sender, EventArgs e)
        {
            ClientesVO cliVO = new ClientesVO();
            cliVO.Razao = lvDados.SelectedItem.ToString();           
            Controle = 1;
            pesquisarListaCliente(cliVO.Razao, Controle);
        }
        private void lvDados_CursorChanged(object sender, EventArgs e)
        {
            txtHistorico.Text = "";
            ClientesVO cliVO = new ClientesVO();
            cliVO.Razao = lvDados.SelectedItem.ToString();
            cliVO.Razao = lvDados.SelectedItem.ToString();
            Controle = 1;
            pesquisarListaCliente(cliVO.Razao, Controle);
        }
        private void txtWebSite_MouseHover(object sender, EventArgs e)
        {
            txtWebSite.Cursor = Cursors.Hand;
        }
        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            ClientesVO cli = new ClientesVO();
            dvDados.Rows.Clear();
            PesquisaCliente(cli);
            if (lvDados.Items.Count > 0)
            {
                lvDados.SelectedIndex = 0;
                cli.Razao = lvDados.SelectedItem.ToString();
            }
            pesquisarListaCliente(cli.Razao, Controle);

        }
        private void rbNome_Click(object sender, EventArgs e)
        {
            lbl_de.Visible = false;
            lbl_A.Visible = false;
            dTP_De.Visible = false;
            dt_Ate.Visible = false;
            lbl_de.Enabled = false;
            lbl_A.Enabled = false;
            dTP_De.Enabled = false;
            dt_Ate.Enabled = false;
            txtBusca.Visible = true;
            txtBusca.Enabled = true;
        }
        private void rbData_Click(object sender, EventArgs e)
        {
            lbl_de.Visible = true;
            lbl_A.Visible = true;
            dTP_De.Visible = true;
            dt_Ate.Visible = true;
            lbl_de.Enabled = true;
            lbl_A.Enabled = true;
            dTP_De.Enabled = true;
            dt_Ate.Enabled = true;
            txtBusca.Enabled = false;
            txtBusca.Visible = false;
        }
        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                string razao = "";
                dvDados.Rows.Clear();
                ClientesVO cli = new ClientesVO();
                cli.inicio = Convert.ToDateTime(dTP_De.Text);
                cli.fim = Convert.ToDateTime(dt_Ate.Text);

                if (rbNome.Checked == true)
                {
                    cli.controle = 1;
                    cli.Razao = txtBusca.Text;
                    PesquisaCliente(cli);
                    pesquisarListaCliente(txtBusca.Text, cli.controle);
                }
                else if (rbData.Checked == true)
                {
                    cli.ParametrodePesquisa = "2";
                    if (DateTime.Compare(cli.inicio, cli.fim) > 0)
                    {
                        MessageBox.Show("A data incicial não pode ser maior que a data final");
                    }
                    else
                    {
                        PesquisaCliente(cli);
                        razao = lvDados.SelectedItem.ToString();
                        pesquisarListaCliente(razao, Controle);
                    }

                }
            }
        }
        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            ClientesVO cli = new ClientesVO();
            cli.BuscaTXT = 1;
            if (txtBusca.Text != "")
            {
                cli.Razao = txtBusca.Text;
                PesquisaCliente(cli);
            }
        }
        private void lvDados_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void FrmCadastro_Click(object sender, EventArgs e)
        {
            txtHistorico.Enabled = true;
        }
        private void txtWebSite_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (txtWebSite.Text != "") System.Diagnostics.Process.Start(txtWebSite.Text);
            }
            catch
            {
                MessageBox.Show("Endereço web não encontrado");
            }
        }
        private void dvDados_Click(object sender, EventArgs e)
        {
        }
        private void AgendaCompromissos_MouseDown(object sender, MouseEventArgs e)
        {
            if (controleAvisos == 0)
            {
                lbl_Id.Visible = false;
                MonthCalendar.HitTestInfo info = AgendaCompromissos.HitTest(e.Location);
                if (info.HitArea == MonthCalendar.HitArea.Date)
                {
                    if (AgendaCompromissos.BoldedDates.Contains(info.Time))
                        AgendaCompromissos.RemoveBoldedDate(info.Time);
                    else
                        AgendaCompromissos.AddBoldedDate(info.Time);
                    AgendaCompromissos.UpdateBoldedDates();
                }

                busca = "MouseClick";
                string razao = lvDados.SelectedItem.ToString();
                idClienteCompromisso = Convert.ToInt32(lbl_Id.Text);
                ClientesVO cli = new ClientesVO();
                cli.DataCompromisso = AgendaCompromissos.SelectionStart.ToShortDateString();
                cli.codigo = Convert.ToInt32(lbl_Id.Text);
                FrmLembrete lembrete = new FrmLembrete();
                VerificaCompromissos(razao, cli.codigo, cli.DataCompromisso, busca);
                lembrete.carrega_info(cli);
                lembrete.ShowDialog(); ;
                lembrete.Focus();
            }
            else
            {
                lbl_Id.Visible = true;
                MonthCalendar.HitTestInfo info = AgendaCompromissos.HitTest(e.Location);
                if (info.HitArea == MonthCalendar.HitArea.Date)
                {
                    if (AgendaCompromissos.BoldedDates.Contains(info.Time))
                        AgendaCompromissos.RemoveBoldedDate(info.Time);
                    else
                        AgendaCompromissos.AddBoldedDate(info.Time);
                    AgendaCompromissos.UpdateBoldedDates();
                }

                busca = "MouseClick";
                ClientesVO cli = new ClientesVO();
                cli.DataCompromisso = AgendaCompromissos.SelectionStart.ToShortDateString();
                FrmLembrete lembrete = new FrmLembrete();
                VerificaCompromissoaPessoais();
                cli.ControleAvisos = controleAvisos.ToString();
                lembrete.carrega_info(cli);
                lembrete.ShowDialog(); ;
                lembrete.Focus();
            }
        }
        private void ptbAdicionarGrid_Click(object sender, EventArgs e)
        {
            this.dvDados.Rows.Add(DateTime.Now.ToShortDateString());
        }
        private void lvDados_KeyUp(object sender, KeyEventArgs e)
        {
            txtHistorico.Text = "";
            dvDados.Rows.Clear();
            ClientesVO cliVO = new ClientesVO();
        
            cliVO.Razao = lvDados.SelectedItem.ToString();
            Controle = 1;
            pesquisarListaCliente(cliVO.Razao, Controle);
        }
        private void FrmCadastro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        private void txtEmail_DoubleClick(object sender, EventArgs e)
        {
            FrmEnviodeEmail email = new FrmEnviodeEmail();
            ClientesVO cli = new ClientesVO();
            cli.Destinatario = txtEmail.Text;
            email.carregaEmail(cli);
            email.Show();
        }
        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            txtEmail.Cursor = Cursors.Hand;
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblLembPessoal_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controleAvisos = 1;
            VerificaCompromissoaPessoais();
            lbl_avisos.Text = "Lembretes Pessoais";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void txt_Razao_Click(object sender, EventArgs e)
        {
            lbl_Id.Text = "";
        }
        private void txtHistorico_Click(object sender, EventArgs e)
        {
            edicaoGrid = 0;
        }
      
      
        #endregion

        private void dvDados_Click_1(object sender, EventArgs e)
        {
            edicaoGrid = 1;
            txtHistorico.Enabled = false;
            txtHistorico.Text = "";
    
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ptbExcluir_Click(object sender, EventArgs e)
        {
            DesativarCliente();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObs_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string idHist = ""; 

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0)
            {
                idHist = dvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
                ExcluirHistoricoIndividual(idHist);                
            }
        }

        private void FrmCadastro_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.Enter)
            {
                String razao = "";
                dvDados.EndEdit();
                try
                {
                    IncluirCliente();
                    if (cli.TipoOperacao != null)
                    {
                        if (cli.TipoOperacao == "Inserir")
                        {
                            cli.Razao = null;
                            PesquisaCliente(cli);
                            razao = cliente.PesquisaUltimoCliente();
                            dvDados.Rows.Clear();
                            int contagemItems = lvDados.Items.Count;
                            if (lvDados.Items.Count != 0)
                            {
                                int contador = 0, index = 0;
                                foreach (var lc in lvDados.Items)
                                {
                                    if (lc.Equals(razao))
                                    {
                                        index = contador;
                                    }
                                    contador++;
                                }
                                lvDados.SelectedIndex = index;
                                razao = lvDados.SelectedItem.ToString();
                            }
                            Controle = 1;
                            pesquisarListaCliente(razao, Controle);
                            cli.TipoOperacao = "";
                        }
                        if (cli.TipoOperacao == "Alterar")
                        {
                            dvDados.Rows.Clear();
                            razao = lvDados.SelectedItem.ToString();
                            Controle = 1;
                            pesquisarListaCliente(razao, Controle);
                            cli.TipoOperacao = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Houve uma falha na listagem de clientes");
                }
               
            }
        }
        private void FrmCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Lbl_Excluir_Historico_Click(object sender, EventArgs e)
        {
            Frm_ExcluirHistorico ExcHist = new Frm_ExcluirHistorico();
            if (lvDados.SelectedItem != null)
            {
                cli.Razao = lvDados.SelectedItem.ToString();
                ExcHist.VerificaHist(Convert.ToInt32(lbl_Id.Text));
                this.Close();
            }
            else {
                MessageBox.Show("Selecione Uma empresa para excluir o histórico");
            }
        }


        private void lvDados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dvDados_KeyPress(object sender, KeyPressEventArgs e)
        {
            String teste = "oi";
        }   
     }
}