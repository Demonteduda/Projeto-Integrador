using MySql.Data.MySqlClient;
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
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Font = new Font("Cambria", 10, FontStyle.Bold);
            button2.Font = new Font("Cambria", 9, FontStyle.Bold);
            button3.Font = new Font("Cambria", 8, FontStyle.Bold);

           


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
            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbPagamento.SelectedIndex==0)
            {
                pagamento pg = new pagamento(txtValor.Text);
                pg.Show();
            }
            lbProdutos.Items.Clear();
        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCod.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro cd = new cadastro();
            cd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consulta cs = new consulta();
            cs.Show();
            produtos prod = null;
            DAO_Conexao.con.Close();
            prod = new produtos();
            MySqlDataReader re = prod.consultarProduto(int.Parse(txtCod.Text));
            while (re.Read())
            {
                lbProdutos.Items.Add(re);
            }

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                lbProdutos.Items.Add("Código: " + txtCod.Text + " - R$" + txtValor.Text);
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbProdutos.Items.Clear();
        }

        private void txtCod_Enter(object sender, EventArgs e)
        {

        }
    }
}
