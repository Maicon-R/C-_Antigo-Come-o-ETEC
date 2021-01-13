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
    public partial class telasplash : Form
    {
        public telasplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {
                barra.Value = barra.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Form1 abre = new Form1();
                abre.ShowDialog();
            }
        }
    }
}
