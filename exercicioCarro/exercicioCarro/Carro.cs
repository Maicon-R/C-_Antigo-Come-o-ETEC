using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioCarro
{
    class Carro
    {
        //atributos
        public String modelo;
        public String fabricante;
        public String cor;
        public String nroPortas;

        public String Ligar() //metodo ligar()
        {
            String mensagem = "O carro está ligado!";
            return mensagem;
        }

        public String Buzinar() //metodo buzinar()
        {
            String mensagem2 = "Buzinando!";
            return mensagem2;
        }

        public String Desligar() //metodo desligar()
        {
            String mensagem3 = "O carro está desligado!";
            return mensagem3;
        }

    }
}
