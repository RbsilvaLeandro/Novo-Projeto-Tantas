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
    public partial class FrmExclusaoLembrete : Form
    {
        public FrmExclusaoLembrete()
        {
            InitializeComponent();
        }
        public string idlembreteexclusao = "";
        public List<string> listaId = new List<string>();
        ClientesBO ClienteMetodo = new ClientesBO();
      
        private void FrmExclusaoLembrete_Load(object sender, EventArgs e)
        {

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
            ExcluirLembrete();
           
        }
        public void carregaGrid(ClientesVO cli)
        {
            int CodigoCliente = cli.codigo;
            GridLembretes.Rows.Add(cli.IdLembrete, cli.NovoContato.ToShortDateString(), cli.lembrete);
        }
        public void ExcluirLembrete()
        {
            string idlembreteexclusao = string.Join(",", listaId);
            ClientesVO cli = new ClientesVO();
           
                try
                {
                    if (ClienteMetodo.ExcluirVariosLembretes(idlembreteexclusao) == true)
                    {
                        MessageBox.Show("Cadastros Excluídos com sucesso");
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("É necessário selecionar um lembrete para excluir");
                }
            }
           
      

        private void GridLembretes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = 0;
            foreach (DataGridViewRow row in GridLembretes.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (chk.Selected == true)
                {
                    listaId.Add(GridLembretes.Rows[cont].Cells[0].Value.ToString());
                }
                cont++;
            }
        }
    }
}
