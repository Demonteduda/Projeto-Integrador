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
        public float total = 0;
        public string valor;
        public string nome1,quan;
        public string quantidade;
        public string qtd1, codi;
        public int cont = 0;
        public float total1 = 0;
        public float valor1 = 0;
        public float total2 = 0; 
        public Form2()
        {
            InitializeComponent();
            
            txtValor.Enabled = false;
            //initializeFullscreenImage();
            dataGridProdu.ReadOnly = true;
            //dataGridProdu.Rows.Clear();
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
            dataGridProdu.ClearSelection();

        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(codi);
            for(int i=0;i<dataGridProdu.RowCount;i++)
            {
                if (dataGridProdu.Rows[i].Cells[0].Value.ToString() == codi)
                {
                    dataGridProdu.Rows[i].Cells[3].Value = cmbQuantidade.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("Erro!!");
                }
            }
            
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
        { cmbQuantidade.Items.Clear();
            if(txtCod.Text !="")
            {
              if (e.KeyChar == 13)
            {
                codi = txtCod.Text;
                produtos p1 = new produtos();
                MySqlDataReader r = p1.consultarProduto(int.Parse(txtCod.Text));
                while (r.Read())
                { if (txtCod.Text == r["codigo"].ToString())
                        {
                            valor = r["preco"].ToString();
                            nome1 = r["nome"].ToString();
                            quantidade = r["quantidade"].ToString();
                            qtd1 = "1";
                            dataGridProdu.Rows.Add(txtCod.Text, nome1, valor, qtd1);
                            cont += 1;
                            total += float.Parse(valor);
                            int qtd = int.Parse(quantidade);
                            for (int i = 0; i <= qtd; i++)
                            cmbQuantidade.Items.Add(i.ToString());
                        }
                        else
                            MessageBox.Show("Um produto com esse código não está cadastrado.");
                        
                }
                DAO_Conexao.con.Close();          
                try
                {
                    txtValor.Text = total.ToString();
                    txtCod.Text = "";
                }
                catch(Exception)
                {
                
                    MessageBox.Show("Produto não cadastrado");
                }
                
                
            }
            
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridProdu.Rows.Count >0)
            {     
                dataGridProdu.Rows.Clear();
                txtValor.Text = "";
            }
            else
            {
           MessageBox.Show("A tabela está vazia.");

            }

            txtCod.Focus();
               
          
            
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
            produtos p2 = new produtos();
            if (dataGridProdu.Rows.Count == 0)
            {
                MessageBox.Show("Vazio");
            }
            else
            {

                MySqlDataReader r = p2.consultarProduto(int.Parse(dataGridProdu.SelectedRows[0].Cells[0].Value.ToString()));
                while (r.Read())
                {
                    Console.WriteLine(total2);
                    valor1 = float.Parse(r["preco"].ToString());
                    int codD = int.Parse(r["codigo"].ToString());

                    for (int i = 0; i < dataGridProdu.Rows.Count; i++)
                    {
                        if (int.Parse(dataGridProdu.Rows[i].Cells[0].Value.ToString()) == codD)
                        {

                            dataGridProdu.Rows.RemoveAt(i);
                            break;
                        }

                    }

                    total1 = float.Parse(txtValor.Text);
                    total2 = total1 - valor1;
                    txtValor.Text = total2.ToString();


                }
                DAO_Conexao.con.Close();
                try
                {


                }
                catch (Exception)
                {
                    MessageBox.Show("Produto não cadastrado");
                }

            }

            txtCod.Focus();


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
