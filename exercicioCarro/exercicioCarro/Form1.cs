using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioCarro
{
    public partial class Form1 : Form
    {

        //instanciar a classe
        Carro car = new Carro();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.Ligar()); //chamando o metodo da classe carro
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.Buzinar()); //chamando o metodo da classe carro
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(car.Desligar()); //chamando o metodo da classe carro
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //alteração de dados dos atributos
            car.modelo = txtModelo.Text;
            car.fabricante = txtFabricante.Text;
            car.cor = txtCor.Text;
            car.nroPortas = txtNroPortas.Text;

            //mostrando dados da classe
            MessageBox.Show("O modelo é: " + car.modelo +
                            "\n O fabricante é: " + car.fabricante +
                            "\n A cor é: " + car.cor +
                            "\n O Nro. de portas é: " + car.nroPortas);
        }
    }
}
