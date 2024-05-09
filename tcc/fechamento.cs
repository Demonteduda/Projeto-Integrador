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
        public fechamento(double valor)
        {
            InitializeComponent();

            txtVendas.Text = valor.ToString();

        }


        public fechamento()
        {
            InitializeComponent();
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
