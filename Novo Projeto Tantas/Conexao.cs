using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Novo_Projeto_Tantas
{
    public class Conexao
    {
        public static MySqlConnection objConexao = null;
        public static string stringconnection1 = "server=localhost;User Id=root;password=Alberto-Pc;database=Tantas;command timeout=120";

        public void tentarAbrirConexaoLocal()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }
        public void ConexaoBancoMySQL()
        {
            try
            {
                tentarAbrirConexaoLocal();
            }
            catch
            {
                MessageBox.Show("Não foi possível validar seu acesso. Tente novamente.");
            }
        }
    }
}

