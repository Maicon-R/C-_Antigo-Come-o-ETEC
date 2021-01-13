using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lanchonete lanche = new Lanchonete();//instancia da classe
 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//botão calcular conta
            lanche.quantidadeLanche = int.Parse(txtQuantidadeLanches.Text);
            lanche.quantidadeRefri = int.Parse(txtQuantidadeRefri.Text);

            lanche.calculoTotalCompra();

            //mostrar o valor total da conta na caixa de texto do form
            txtTotalCompra.Text = Convert.ToString(lanche.totalConta);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lanche.dinheiroRecebido = int.Parse(txtDinheiro.Text);

            lanche.calculoTroco();
            txtTroco.Text = Convert.ToString(lanche.troco);

        }
    }
}
