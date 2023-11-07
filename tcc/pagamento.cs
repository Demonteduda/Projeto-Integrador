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
       
        public pagamento()
        {
            InitializeComponent();
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
