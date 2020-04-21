using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_Projeto_Tantas
{
    public class UsuarioVO
    {
        //Variáveis para a verificação de Login e Senha
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
      
    }
}
