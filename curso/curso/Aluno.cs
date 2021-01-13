using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Aluno
    {
        //Atributos da classe aluno
        public string nome;
        public string login;
        public string senha;

        //método
        public string ValidarLogineSenha()
        {
            String resposta="";
            if (this.login.Equals("aluno") && this.senha.Equals("123"))
            {
                return resposta = "Acesso permitido!";
            }
            else
            {
                return resposta = "Acesso negado!";
            }
        }


    }
}
