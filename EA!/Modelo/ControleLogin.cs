using EA_.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_.Modelo
{
    class ControleLogin
    {
        public string cargo ;
        public bool tem;
        public string mensagem = "";

        public bool acessar(String login, String senha, ref String cargo){
            VerificacaoLogin loginVerifica = new VerificacaoLogin();
            tem = loginVerifica.verificaLogin(login, senha,ref cargo);
            if (!loginVerifica.mensagem.Equals("")){
                this.mensagem = loginVerifica.mensagem;
            }
            //hkhkjhkjhkjhkjhkj
            return tem;
        }

        public ControleLogin(){
            //cargo = "";
        }


        public String Cadastrar(){
            return mensagem;
        }
    }
}
