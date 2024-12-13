using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    class LoginDaoComandos
    {
        public bool tem;
        public String mensagem;
        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            return tem;
        }   
        
        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
