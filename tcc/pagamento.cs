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
    public partial class pagamento : Form
    {
       
        public pagamento(string valor)
        {
            InitializeComponent();
            txtTotalPago.Text = valor;
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void txtValorEntregue_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtTroco_Click(object sender, EventArgs e)
        {
            /*double troco = double.Parse(txtValorEntregue.Text) - double.Parse(txtTotalPago.Text);
            txtTroco.Text = ("R$"+troco);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorEntregue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                double troco = double.Parse(txtValorEntregue.Text) - double.Parse(txtTotalPago.Text);
                txtTroco.Text = ("R$" + troco);
            }
           
        }
    }
}
