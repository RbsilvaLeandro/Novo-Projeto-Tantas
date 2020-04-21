using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Diagnostics;



namespace Novo_Projeto_Tantas
{
    public partial class FrmMenu : Form
    {
        public UsuarioBO usuarioLogado;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.UsuLogado = this.usuarioLogado;
            cadastro.Show();

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svBKP = new SaveFileDialog();
            svBKP.ShowDialog();

            if (svBKP.FileName == "") return;

            try
            {
                DateTime backupTime = DateTime.Now;
                int Ano = backupTime.Year; int Mes = backupTime.Month; int Dia = backupTime.Day; int Hora = backupTime.Hour;
                int minuto = backupTime.Minute; int Segundo = backupTime.Second; int ms = backupTime.Millisecond;

                String tmestr = backupTime.ToString();
                tmestr = svBKP.FileName + Ano + "-" + Mes + "-" + Dia + "-" + Hora + "-" + minuto + ".sql";
                StreamWriter file = new StreamWriter(tmestr);
                ProcessStartInfo proc = new ProcessStartInfo();
                string cmd = string.Format(@"-u{0} -p{1} -h{2} {3} ", "root", "Alberto-Pc", "localhost", "tantas", "backup.sql");
                proc.FileName = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysqldump";

                proc.RedirectStandardInput = false;
                proc.RedirectStandardOutput = true;
                proc.Arguments = cmd;//"-u root -p smartdb > testdb.sql";
                proc.UseShellExecute = false;
               
               // proc.StandardOutputEncoding = Encoding.UTF8;
                Process p = Process.Start(proc);
                string res;

                res = p.StandardOutput.ReadToEnd();
                file.WriteLine(res);
                p.WaitForExit();
                file.Close();

                MessageBox.Show("Backup Gerado com Sucesso");
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar a cópia de segurança");
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Title = "Restore Database";
            op.FileName = "";
            op.Filter = "MySQL Dump (*.sql)|*.sql";
            DialogResult dr = op.ShowDialog();

            if (op.FileName == "") return;

            if (dr == DialogResult.OK)
            {
                string filepath = op.FileName;
                StreamReader file = new StreamReader(filepath);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe";
                psi.UseShellExecute = false;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", "root", "Alberto-Pc", "localhost", "tantas");
            
                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
                MessageBox.Show("Backup restaurado com sucesso!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}