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
    public partial class Form2 : Form
    {
        public int total;
        public Form2()
        {
            InitializeComponent();


            Form1 f1 = new Form1();
            f1.Enabled= false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCod_Click(object sender, EventArgs e)
        {
            
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtCod.Text + " - R$" + txtValor.Text);
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPagamento.SelectedIndex==0)
            {
                pagamento pg = new pagamento();
                pg.Show();
            }
            listBox1.Items.Clear();
        }
    }
}
