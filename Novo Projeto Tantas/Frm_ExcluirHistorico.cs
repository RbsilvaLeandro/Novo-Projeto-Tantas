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
    public partial class Frm_ExcluirHistorico : Form
    {
        ClientesBO ClienteMetodo = new ClientesBO();
        public List<string> listaHist = new List<string>();
        public Frm_ExcluirHistorico()
        {
            InitializeComponent();
        }

        private void ptbExcluir_Click(object sender, EventArgs e)
        {
            ExcluirHistorico();
            this.Close();
        }
        private void ExcluirHistorico()
        {
            string idlembreteexclusao = string.Join(",", listaHist);
            ClientesVO cli = new ClientesVO();
            try
            {
                ClienteMetodo.ExcluirHistoricoIndividual(idlembreteexclusao);
                            }
            catch
            {
                MessageBox.Show("Não foi possível excluir os lembretes");
            }
        }

        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            ExcluirHistorico();
            this.Close();
        }
        public void carregaGrid(ClientesVO cli)
        {
            int CodigoCliente = cli.codigo;
            GridHist.Rows.Add(cli.IdHistorico, cli.Razao, cli.data.ToString().Substring(0,10), cli.Historico);
        }
        public void VerificaHist(int idCliente)
        {
            ClientesVO cli = new ClientesVO();

            LinkedList<ClientesVO> ListaHist = new LinkedList<ClientesVO>();
            ListaHist = null;

            //Verifica se foi solicitado um usuario pelo seu código
            ListaHist = ClienteMetodo.pesquisarHistorico(idCliente);

            if (cli == null)
            {
                ListaHist.AddLast(cli);
            }
            else
            {
                Frm_ExcluirHistorico excHist = new Frm_ExcluirHistorico();

                    foreach (ClientesVO lista in ListaHist)
                    {
                        cli.Razao = lista.Razao;
                        cli.IdHistorico = lista.IdHistorico;
                        cli.Historico = lista.Historico;
                        cli.data = lista.data;
                        excHist.carregaGrid(cli);
                    }
                    excHist.Show();              
            }

        }

        private void ptbExcluir_Click_1(object sender, EventArgs e)
        {
            if (listaHist.Count > 0)
            {
                ExcluirHistorico();
                this.Close();
                FrmCadastro fr = new FrmCadastro();
                fr.ShowDialog();
            }
            else {
                MessageBox.Show("Selecione um histórico para excluir");
            }
        }

        private void GridHist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = 0;
            foreach (DataGridViewRow row in GridHist.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[4];
                if (chk.Selected == true)
                {
                    listaHist.Add(GridHist.Rows[cont].Cells[0].Value.ToString());
                }
                cont++;
            }
        }

        private void Frm_ExcluirHistorico_Load(object sender, EventArgs e)
        {

        }

        private void ptbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
            FrmCadastro fr = new FrmCadastro();
            fr.ShowDialog();
        }

    }
}
