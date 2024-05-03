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
            int i = 0;
    int validacao = 0;

    foreach (DataGridViewRow row in dataGridProdu.Rows)
    {
               
        // Verifique se a célula na primeira coluna contém o valor 'codi'
        if (row.Cells[0].Value.ToString() == codi)
        { 
            MessageBox.Show("ENTROU!!!!!!!!!!!!!!!!!");
            i++;
            validacao = 1;

            // Converta 'valor' do produto para valorFLOAT
            float valorFloat=total;
                    float sobra = total - float.Parse(valor);
                    if (i > 1) { valorFloat = total - sobra; }
                   
                    MessageBox.Show(valorFloat.ToString());
                // Calcule o total
                float tot = valorFloat * cmbQuantidade.SelectedIndex;
                    float tot1 = tot + float.Parse(txtValor.Text) - valorFloat;
                total = tot1;
                        MessageBox.Show(total.ToString());
                // Atualize as células na grade
                row.Cells[2].Value = tot.ToString();
                txtValor.Text = tot.ToString();
                row.Cells[3].Value = cmbQuantidade.SelectedIndex;
            
        }
    }

    if (validacao == 0)
    {
        MessageBox.Show("Erro!!");
    }

    txtCod.Focus();
}
         
        /*private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            int validacao = 0;   
            for(int i=0;i<dataGridProdu.RowCount;i++)
            {
                if (dataGridProdu.Rows[i].Cells[0].Value.ToString() == codi)
                {
                    validacao = 1;
                    float tot = float.Parse(valor) * cmbQuantidade.SelectedIndex;
                    float tot1 = tot + float.Parse(txtValor.Text) - float.Parse(valor)* int.Parse(dataGridProdu.Rows[i].Cells[3].Value.ToString()) ;
                    total = tot1;
                    dataGridProdu.Rows[i].Cells[2].Value = tot.ToString();
                    txtValor.Text = tot1.ToString();
                    dataGridProdu.Rows[i].Cells[3].Value = cmbQuantidade.SelectedIndex;
                }
               
            }
             if(validacao==0)
                {
                    MessageBox.Show("Erro!!");
                }
            txtCod.Focus();
        }*/

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

                if (e.KeyChar == 13) // Se a tecla pressionada for Enter
                {
                codi = txtCod.Text;
                    if (!string.IsNullOrEmpty(txtCod.Text))
                    {
                        string codi = txtCod.Text;
                        bool produtoExistente = false;

                        // Verificar se o produto já foi adicionado
                        foreach (DataGridViewRow row in dataGridProdu.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codi)
                            {
                                produtoExistente = true;
                                break;
                            }
                        }

                    if (!produtoExistente)
                    {
                        produtos p1 = new produtos();
                        MySqlDataReader r = p1.consultarProduto(int.Parse(codi));

                        while (r.Read())
                        {
                            if (codi == r["codigo"].ToString())
                            {
                                valor = r["preco"].ToString();
                                string nome1 = r["nome"].ToString();
                                string quantidade = r["quantidade"].ToString();
                                dataGridProdu.Rows.Add(codi, nome1, valor, quantidade);
                                cmbQuantidade.Items.Clear();
                                for (int j = 0; j <= int.Parse(quantidade); j++)
                                {
                                    cmbQuantidade.Items.Add(j.ToString());
                                }

                                cont += 1;
                                total += float.Parse(valor);
                                                       break; // Encerrar o loop enquanto encontrou o produto
                            }
                        }

                        DAO_Conexao.con.Close();

                        // Atualizar o total e limpar o campo de código
                        txtValor.Text = total.ToString();
                        txtCod.Text = "";
                    }
                    else
                        MessageBox.Show("Produto já adicionado à tabela!");
                    
                    }
                }

            

        }

            private void button4_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
           "Deseja apagar mesmo?",
           "Aviso",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (dataGridProdu.Rows.Count > 0)
                {
                    dataGridProdu.Rows.Clear();
                    txtValor.Text = "";
                    total = 0;
                    cmbQuantidade.Items.Clear();
                }
                else
                {
                    MessageBox.Show("A tabela está vazia.");

                }
            }
            else if (result == DialogResult.No)
            {
                
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

                    DialogResult result = MessageBox.Show(
                     "Deseja apagar mesmo?",
                     "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
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

                        if (dataGridProdu.Rows.Count == 0)
                        {
                            total = 0;
                        }
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                    else
                    MessageBox.Show("Produto não cadastrado");

                }
                DAO_Conexao.con.Close();             

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

        }
    }
}
