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
        public float total;
        public string valor;
        public string nome1,quan;
        public string quantidade;
        public string qtd1, codi;
        public int cont;
        public Form2()
        {
            InitializeComponent();

            txtValor.Enabled = false;
            //initializeFullscreenImage();
            dataGridView1.ReadOnly = true;          
        }

        /* private void initializeFullscreenImage()
         {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

         }
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            txtCod.Select();

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

            if (cmbQuantidade.SelectedIndex==0)
            {
                pagamento pg = new pagamento(txtValor.Text);
                pg.Show();
                this.Close();
            }
            dataGridView1.ClearSelection();

        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro cd = new cadastro();
            cd.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            consulta cs = new consulta();
            cs.Show();
            produtos prod = null;
            DAO_Conexao.con.Close();
            prod = new produtos();

        
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                codi = txtCod.Text;
                produtos p1 = new produtos();
                MySqlDataReader r = p1.consultarProduto(int.Parse(txtCod.Text));
                while (r.Read())
                {
                    valor = r["preco"].ToString();
                    nome1 = r["nome"].ToString();
                    quantidade = r["quantidade"].ToString();
                    qtd1 = "1";
                    dataGridView1.Rows.Add(txtCod.Text, nome1, valor, qtd1);
                    cont += 1;
                }
                DAO_Conexao.con.Close();          
                try
                {
                    total += float.Parse(valor);
                    txtValor.Text = total.ToString();
                    txtCod.Text = "";
                }
                catch(Exception)
                {
                
                    MessageBox.Show("Produto não cadastrado");
                }
                int qtd = int.Parse(quantidade);
                for(int i=0; i<=qtd;i++)
                {
                    cmbQuantidade.Items.Add(i.ToString());
                }
                
            }
            
         

              //  p1.consultarPreco(int.Parse( txtCod.Text)) ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("A tabela está vazia.");
               
            }
            else
            {
                dataGridView1.ClearSelection();
                txtValor.Text = "";
                txtCod.Text = "";
                total = 0;
            }
            
        }

        private void txtCod_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cmbPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Abrir o ComboBox
                cmbQuantidade.DroppedDown = true;
                cmbQuantidade.SelectedIndex = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
       

        }

        private void btnQtd_Click(object sender, EventArgs e)
        {
            


        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
      /*
            if (txtCod != null)
            {
                if (cmbQuantidade.SelectedItem != null)
                {
                    Console.WriteLine("Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa===");
                    DAO_Conexao.con.Open();
                    produtos prod = new produtos();
                    if (prod.comprarProd(int.Parse(txtCod.Text), int.Parse(cmbQuantidade.SelectedItem.ToString()))
                        {
                        MessageBox.Show("Compra efetuada");
                    }
                      
                }
                else
                    MessageBox.Show("Informe a quantidade que deseja comprar!");
            }
            else MessageBox.Show("Digíte o código do produto que deseja comprar!");
        
      */
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void cmbQuantidade_Enter(object sender, EventArgs e)
        {

            //int qtd11= int.Parse(cmbQuantidade.SelectedItem.ToString());
            //Console.WriteLine("aaaaaaaaaaaaaaaaaaaa=  "+qtd11);
           // dataGridView1.Rows[cont].Cells[3].Value 
            
            // if(dataGridView1.SelectedRows.)
        }
    }
}
