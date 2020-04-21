using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_Projeto_Tantas
{
    public class ClientesBO
    {
        private string TipoOperacaoCli;
        public string TipoOperacao
        {
            get { return TipoOperacaoCli; }
            set { TipoOperacaoCli = value; }
        }
        private string RazaoSocialCli;
        public string Razao
        {
            get { return RazaoSocialCli; }
            set { RazaoSocialCli = value; }
        }
        private string EnderecoCli;
        public string Enderco
        {
            get { return EnderecoCli; }
            set { EnderecoCli = value; }
        }
        private string NumeroCli;
        public string Numero
        {
            get { return NumeroCli; }
            set { NumeroCli = value; }
        }
        private string ContatoCli;
        public string Contato
        {
            get { return ContatoCli; }
            set { ContatoCli = value; }
        }
        private string EmailCli;
        public string Email
        {
            get { return EmailCli; }
            set { EmailCli = value; }
        }
        private string TelefoneCli;
        public string Telefone
        {
            get { return TelefoneCli; }
            set { TelefoneCli = value; }
        }
        private string CelularCli;
        public string Celular
        {
            get { return CelularCli; }
            set { CelularCli = value; }
        }
        private string HistoricoCli;
        public string Historico
        {
            get { return HistoricoCli; }
            set { HistoricoCli = value; }
        }
        private int CodigoCliente;
        public int codigo
        {
            get { return CodigoCliente; }
            set { CodigoCliente = value; }
        }
        private string CidadeCliente;
        public string Cidade
        {
            get { return CidadeCliente; }
            set { CidadeCliente = value; }
        }
        private string DataContato;
        public string data
        {
            get { return DataContato; }
            set { DataContato = value; }
        }
        private int ControleCli;
        public int controle
        {
            get { return ControleCli; }
            set { ControleCli = value; }
        }
        private string WebSiteCli;
        public string webSite
        {
            get { return WebSiteCli; }
            set { WebSiteCli = value; }
        }
        private DateTime inicioCli;
        public DateTime inicio
        {
            get { return inicioCli; }
            set { inicioCli = value; }
        }
        private DateTime fimCli;
        public DateTime fim
        {
            get { return fimCli; }
            set { fimCli = value; }
        }
        private string ParametrodePesquisaCli;
        public string ParametrodePesquisa
        {
            get { return ParametrodePesquisaCli; }
            set { ParametrodePesquisaCli = value; }
        }
        private int BuscaTxtCli;
        public int BuscaTXT
        {
            get { return BuscaTxtCli; }
            set { BuscaTxtCli = value; }
        }
        private DateTime NovoContatoCli;
        public DateTime NovoContato
        {
            get { return NovoContatoCli; }
            set { NovoContatoCli = value; }
        }
        private string DataCompromissoCli;
        public string DataCompromisso
        {
            get { return DataCompromissoCli; }
            set { DataCompromissoCli = value; }
        }
        private string BuscaCompromissosCli;
        public string BuscaCompromissos
        {
            get { return BuscaCompromissosCli; }
            set { BuscaCompromissosCli = value; }
        }
        private string LembreteCli;
        public string lembrete
        {
            get { return LembreteCli; }
            set { LembreteCli = value; }
        }
        private string idHistoricoCli;
        public string IdHistorico
        {
            get { return idHistoricoCli; }
            set { idHistoricoCli = value; }
        }
        private List<string> ListaGridCli;
        public List<string> ListaGrid
        {
            get { return ListaGridCli; }
            set { ListaGridCli = value; }
        }
        private List<string> ListaCompromissosCli;
        public List<string> ListaCompromissos
        {
            get { return ListaCompromissosCli; }
            set { ListaCompromissosCli = value; }
        }
        private Boolean CriaListaCliente;
        public Boolean CriaLista
        {
            get { return CriaListaCliente; }
            set { CriaListaCliente = value; }
        }
        private int IdLembreteCliente;
        public int IdLembrete
        {
            get { return IdLembreteCliente; }
            set { IdLembreteCliente = value; }
        }
        private List<string> ListaExcLembreteCliente;
        public List<string> ExcLembrete
        {
            get { return ListaExcLembreteCliente; }
            set { ListaExcLembreteCliente = value; }
        }
        private int FlagLembrete;
        public int Flag
        {
            get { return FlagLembrete; }
            set { FlagLembrete = value; }
        }
        private string DestinatarioCliente;
        public string Destinatario
        {
            get { return DestinatarioCliente; }
            set { DestinatarioCliente = value; }
        }
        private string ControleAvisosCliente;
        public string ControleAvisos
        {
            get { return ControleAvisosCliente; }
            set { ControleAvisosCliente = value; }
        }
        private DateTime HorarioCompromisssoCliente;
        public DateTime HorarioCompromissso
        {
            get { return HorarioCompromisssoCliente; }
            set { HorarioCompromisssoCliente = value; }
        }
        private int ClientealteradoCli;
        public int Clientealterado
        {
            get { return ClientealteradoCli; }
            set { ClientealteradoCli = value; }
        }
        public ClientesVO InserirCliente(string RazaoSocial, string EnderecoCliente, string Numero, string Contato, string Email, string WebSite, string Telefone, string Historico, string Cidade, int codcli, DateTime novocontato, List<string> listaDados)
        {

            ClientesVO cliVO = new ClientesVO();
            cliVO.Razao = RazaoSocial;
            cliVO.Enderco = EnderecoCliente;
            cliVO.Numero = Numero;
            cliVO.Contato = Contato;
            cliVO.Email = Email;
            cliVO.webSite = WebSite;
            cliVO.Telefone = Telefone;
            cliVO.Celular = Celular;
            cliVO.Historico = Historico;
            cliVO.Cidade = Cidade;
            cliVO.codigo = codcli;
            cliVO.NovoContato = novocontato;
            cliVO.lembrete = lembrete;
            cliVO.ListaGrid = listaDados;


            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.inserirCliente(cliVO);
        }
        public int InserirLembrete(DateTime data, int codigo, string lembrete, List<string> ListaLembretes, Boolean CriaLista, string horario)
        {
            ClientesVO cliVO = new ClientesVO();
            cliVO.codigo = codigo;
            cliVO.lembrete = lembrete;
            cliVO.DataCompromisso = data.ToShortDateString();
            cliVO.ListaCompromissos = ListaLembretes;
            cliVO.HorarioCompromissso = Convert.ToDateTime(horario);
            cliVO.CriaLista = CriaLista;

            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.InserirLembrete(data, codigo, lembrete, ListaLembretes, CriaLista,cliVO.HorarioCompromissso);
        }
        public LinkedList<ClientesVO> pesquisarHistorico(int Id)
        {
            LinkedList<ClientesVO> listaClientes = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.codigo = Id; 
            listaClientes = cliDAO.pesquisarHistExc(cliVO);
            return listaClientes;
        }
        public LinkedList<ClientesVO> pesquisaListaClientes(string RazaoSocial, int controle)
        {
            LinkedList<ClientesVO> listaClientes = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.Razao = RazaoSocial;
            cliVO.controle = controle;
            listaClientes = cliDAO.pesquisarListaClientes(cliVO);
            return listaClientes;
        }
        public LinkedList<ClientesVO> pesquisaCliente(ClientesVO cli)
        {
            LinkedList<ClientesVO> listaRazaoSocial = new LinkedList<ClientesVO>();
            ClientesDAO cliDAO = new ClientesDAO();

            listaRazaoSocial = cliDAO.pesquisarCliente(cli);
            return listaRazaoSocial;
        }
        public LinkedList<ClientesVO> pesquisaListaCompromissoa(string RazaoSocial, int idCliente, string data, string busca)
        {
            LinkedList<ClientesVO> listaCompromissos = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.Razao = RazaoSocial;
            cliVO.codigo = idCliente;
            cliVO.DataCompromisso = data;
            cliVO.BuscaCompromissos = busca;
            listaCompromissos = cliDAO.pesquisarCompromisso(cliVO);
            return listaCompromissos;
        }
        public ClientesVO PesquisaRazao(int codigo)
        {
            ClientesVO cli = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cli = cliDAO.pesquisaRazao(codigo);
            return cli;
        }
        public string PesquisaUltimoCliente()
        {
            string razao = "";
            ClientesVO cli = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            razao = cliDAO.pesquisaUltimoCliente();
            return razao;
        }
        public Boolean ExcluirLembrete(int IdLembrete)
        {
            ClientesVO cli = new ClientesVO();
            cli.IdLembrete = IdLembrete;
            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.ExcluirLembrete(cli.IdLembrete);
        }
        public int DesativarCliente(int IdCliente)
        {
            ClientesVO cli = new ClientesVO();
            cli.codigo = Convert.ToInt32(IdCliente);
            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.DesativarCliente(cli.codigo);
        }
        public LinkedList<ClientesVO> pesquisaListaCompromissoExc(int idCliente, string dataExc)
        {
            LinkedList<ClientesVO> listaCompromissosExc = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.codigo = idCliente;
            cliVO.DataCompromisso = dataExc;
            listaCompromissosExc = cliDAO.pesquisarCompromissoExc(cliVO);
            return listaCompromissosExc;
        }
        public LinkedList<ClientesVO> pesquisaHistExc(int idCliente)
        {
            LinkedList<ClientesVO> listaHistExc = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.codigo = idCliente;
            listaHistExc = cliDAO.pesquisarCompromissoExc(cliVO);
            return listaHistExc;
        }
        public string ExcluirVariosHistoricos(string IdHistorico)
        {
            ClientesVO cli = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cli.IdHistorico = IdHistorico;
            return cliDAO.ExcluirHistoricoIndividual(cli.IdHistorico);
        }
        public Boolean ExcluirVariosLembretes(string IdLembrete)
        {
            ClientesVO cli = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.ExcluirVariosLembrete(IdLembrete);
        }
        public int AlterarLembrete(int idLembrete, string Lembrete, int Flag,string horario)
        {

            ClientesVO cliVO = new ClientesVO();
            cliVO.HorarioCompromissso = Convert.ToDateTime(horario);
            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.AlterarLembrete(idLembrete, lembrete, Flag,cliVO.HorarioCompromissso);
        }
        public LinkedList<ClientesVO> pesquisaListaCompromissoPessoal(string data,string Busca)
        {
            LinkedList<ClientesVO> listaCompromissosPessoal = new LinkedList<ClientesVO>();
            ClientesVO cliVO = new ClientesVO();
            ClientesDAO cliDAO = new ClientesDAO();
            cliVO.DataCompromisso = data;
            cliVO.BuscaCompromissos = Busca;
            listaCompromissosPessoal = cliDAO.pesquisarCompromissoPessoal(cliVO);
            return listaCompromissosPessoal;
        }
        public string ExcluirHistoricoIndividual(string idHist)
        {
            ClientesVO cli = new ClientesVO();
            cli.IdHistorico = idHist;
            ClientesDAO cliDAO = new ClientesDAO();
            return cliDAO.ExcluirHistoricoIndividual(cli.IdHistorico);
        }
    }

}

