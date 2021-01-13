using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curso
{
    public partial class frmlogin : Form
    {

        Aluno alu = new Aluno();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            //passando valores das caixas de texto para atributos da classe
            alu.login = txtlogin.Text;
            alu.senha = txtsenha.Text;

            //chamada do metodo da classe ValidarLogineSenha()
            MessageBox.Show(alu.ValidarLogineSenha());

            
        }
    }
}
