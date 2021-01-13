using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches
{
    class Lanchonete
    {
        //atributos
        public int quantidadeLanche;
        public int quantidadeRefri;
        public double totalConta;
        public double dinheiroRecebido;
        public double troco;

        //metodo para calcular o total da compra
        public void calculoTotalCompra()
        {
            this.totalConta = this.quantidadeLanche * 6 + this.quantidadeRefri * 2;
        }

        public void calculoTroco()
        {
            this.troco = this.dinheiroRecebido - this.totalConta;
        }
    }
}