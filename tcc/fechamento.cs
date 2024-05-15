using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    public partial class fechamento : Form
    {
        public double valor1;
        public fechamento()
        {
            InitializeComponent();

        }

        public fechamento(double valor)
        {
            InitializeComponent();
            valor1 = valor;
            txtVendas.Text = valor1.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void txtVendas_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void fechamento_Load(object sender, EventArgs e)
        {
            
        }
    }
}
