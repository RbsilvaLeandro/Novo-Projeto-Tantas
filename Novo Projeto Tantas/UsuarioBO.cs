using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_Projeto_Tantas
{
    public class UsuarioBO
    {
        private string Usu_Login;
        public string usu_login
        {
            get { return Usu_Login; }
            set { Usu_Login = value; }

        }
        private string usuSenha;
        public string senhaUsuario
        {
            get { return usuSenha; }
            set { usuSenha = value; }
        }
        private string usuEmail;
        public string emailUsuario
        {
            get { return usuEmail; }
            set { usuEmail = value; }
        }
        private int FlagSenhaCli;
        public int FlagSenha
        {
            get { return FlagSenhaCli; }
            set { FlagSenhaCli = value; }
        }
        //Metodos    
        public Boolean conectar(int FlagSenha)
        {
            UsuarioVO usuVO = new UsuarioVO();
            usuVO.usu_login = this.Usu_Login;
            usuVO.senhaUsuario = this.senhaUsuario;
            usuVO.FlagSenha = FlagSenha;

            UsuarioDAO usuDAO = new UsuarioDAO();
            //Verifica se nome e senha estao cadastrados no Banco de Dados
            usuVO = usuDAO.consultarCadastro(usuVO);
            if (usuVO == null)
            {
                return false;
            }
            else
            {
                this.senhaUsuario = usuVO.senhaUsuario;
                this.Usu_Login = usuVO.usu_login;
                return true;
            }
        }
        public void EsqueciminhaSenha(string email)
        {
            UsuarioVO usuVO = new UsuarioVO();
            usuVO.emailUsuario = email;

            UsuarioDAO usuDAO = new UsuarioDAO();
            usuDAO.EsqueciMinhaSenha(usuVO);
        }
        public UsuarioVO verificaFlag()
        {
            UsuarioVO usuVO = new UsuarioVO();
            UsuarioDAO usuDAO = new UsuarioDAO();
            //Verifica se nome e senha estao cadastrados no Banco de Dados
            usuVO = usuDAO.verificaFlag();
            if (usuVO == null)
            {
                return null;
            }
            else return usuVO;
        }

    }
}
