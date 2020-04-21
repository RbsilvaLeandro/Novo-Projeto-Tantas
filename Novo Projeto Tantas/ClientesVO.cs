using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_Projeto_Tantas
{
    public class ClientesVO
    {
        private string TipoOperacaoCli;
        public string TipoOperacao
        {
            get { return TipoOperacaoCli; }
            set { TipoOperacaoCli = value; }
        }
        private int ClientealteradoCli;
        public int Clientealterado
        {
            get { return ClientealteradoCli; }
            set { ClientealteradoCli = value; }
        }
        private DateTime HorarioCompromisssoCliente;
        public DateTime HorarioCompromissso
        {
            get { return HorarioCompromisssoCliente; }
            set { HorarioCompromisssoCliente = value; }
        }
      
        private string ControleAvisosCliente;
        public string ControleAvisos
        {
            get { return ControleAvisosCliente; }
            set { ControleAvisosCliente = value; }
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
        //Variavel que recebe a data de inicio e fim para a pesquisa por data 
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
        //Variavel que controla a consulta por data = 2 ou por nome = 1;
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

    }
}
