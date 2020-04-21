using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net.Configuration;


namespace Novo_Projeto_Tantas
{
     public class UsuarioDAO
    {
        MySqlConnection conn = new MySqlConnection(Conexao.stringconnection1);
        public UsuarioVO consultarCadastro(UsuarioVO usu)
        {
            try
            {
                conn.Open();
                DataTable dt_usuario = new DataTable();
                String sql = "SELECT * FROM Usuario WHERE Login = '" + usu.usu_login + "' AND  Senha = '" + usu.senhaUsuario + "' ";
                MySqlDataAdapter da_usuario = new MySqlDataAdapter(sql, conn);
                da_usuario.Fill(dt_usuario);

                if (dt_usuario.Rows.Count == 0)
                {
                    usu = null;
                }
                else
                {
                    int resultado = 0;
                    if (usu.FlagSenha != 0)
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE Usuario SET FlagSenha = 0", conn);
                        resultado = cmd.ExecuteNonQuery();
                        cmd = new MySqlCommand("Update Usuario SET FlagSenha = 1 WHERE Login = '" + usu.usu_login + "' AND  Senha = '" + usu.senhaUsuario + "'", conn);
                        resultado = cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE Usuario SET FlagSenha = 0 ", conn);
                        resultado = cmd.ExecuteNonQuery();
                    }
                }
                return usu;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Usuário ou senha inválidos");
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public UsuarioVO EsqueciMinhaSenha(UsuarioVO usu)
        {
            try
            {
                conn = new MySqlConnection(Conexao.stringconnection1);
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar conexão com banco de dados!");
                return null;
            }
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT Nome,Senha FROM Usuario WHERE email = '" + usu.emailUsuario + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário não encontrado com o email informado");
                }
                else
                {

                    string nome = dt.Rows[0]["Nome"].ToString(), senha = dt.Rows[0]["Senha"].ToString(), emailUsu = usu.emailUsuario;
                    EnviaEmail email = new EnviaEmail();
                    email.EnviarEmail(nome, senha, emailUsu);
                    try
                    {
                        MessageBox.Show("Consulte seu email para recuperar a senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao enviar o email" + ex.Message);
                    }
                }
                return usu;
            }
            catch
            {
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public UsuarioVO verificaFlag()
        {
            try
            {
                UsuarioVO usu = new UsuarioVO();
                conn.Open();
                DataTable dt_usuario = new DataTable();
                String sql = "SELECT Login,Senha From Usuario Where FlagSenha = 1";
                MySqlDataAdapter da_usuario = new MySqlDataAdapter(sql, conn);
                da_usuario.Fill(dt_usuario);

                if (dt_usuario.Rows.Count == 0)
                {
                    usu = null;
                }
                else
                {
                    usu.usu_login = dt_usuario.Rows[0]["Login"].ToString();
                    usu.senhaUsuario = dt_usuario.Rows[0]["Senha"].ToString();
                }
                return usu;
            }
            catch (Exception exConn)
            {
                MessageBox.Show(exConn.Message);
                MessageBox.Show("Nenhum Usuário encontrado");
                conn.Close();
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
