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
        public float subtotalAtual = 0;
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

pagamento pg = new pagamento(txtValor.Text);
                pg.Show();
                this.Close();
               dataGridProdu.ClearSelection();
            if (cmbQuantidade.SelectedIndex==0)
            {
                
            }
            

        }


        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int validacao = 0;

            foreach (DataGridViewRow row in dataGridProdu.Rows)
            {
                // Verifica se a célula na primeira coluna contém o valor 'codi'
                if (row.Cells[0].Value.ToString() == codi)
                {
                    validacao = 1;

                    // Obtém o valor do produto atual da célula
                    float valorProduto = float.Parse(row.Cells[2].Value.ToString());

                    // Calcula o subtotal do produto atual considerando a nova quantidade selecionada
                    float subtotalProduto = valorProduto * cmbQuantidade.SelectedIndex;

                    // Atualiza as células na grade com os novos valores
                    row.Cells[2].Value = subtotalProduto.ToString();
                    txtValor.Text = subtotalProduto.ToString();
                    row.Cells[3].Value = cmbQuantidade.SelectedIndex;
                }
            }

            // Calcula o novo total após a remoção do item da tabela
            float novoTotal = 0;
            foreach (DataGridViewRow row in dataGridProdu.Rows)
            {
                float subtotal = float.Parse(row.Cells[2].Value.ToString());
                novoTotal += subtotal;
            }
            total = novoTotal;
            txtValor.Text = total.ToString();

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
                    bool produtoCadastrado = false;

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
                                produtoCadastrado = true;
                                valor = r["preco"].ToString();
                                string nome1 = r["nome"].ToString();
                                string quantidade = r["quantidade"].ToString();
                                dataGridProdu.Rows.Add(codi, nome1, valor, 1);
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

                        // Se o produto não estiver cadastrado, exibir um aviso
                        if (!produtoCadastrado)
                        {
                            MessageBox.Show("Produto não cadastrado!");
                        }

                        // Atualizar o total e limpar o campo de código
                        txtValor.Text = total.ToString();
                        txtCod.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Produto já adicionado à tabela!");
                    }
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
                    txtValor.Text = "0";
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
        private void RemoverProduto(string codigo, int quantidade)
{
    foreach (DataGridViewRow row in dataGridProdu.Rows)
    {
        if (row.Cells[0].Value.ToString() == codigo)
        {
            float valorProduto = float.Parse(row.Cells[2].Value.ToString());
            int quantidadeAtual = int.Parse(row.Cells[3].Value.ToString());

            // Calcular subtotal do produto de acordo com a quantidade a ser removida
            float subtotalRemovido = valorProduto * quantidade;

            if (quantidadeAtual > quantidade)
            {
                // Se a quantidade atual for maior que a quantidade a ser removida, atualizar quantidade e subtotal
                row.Cells[3].Value = quantidadeAtual - quantidade;
                float subtotalAtual = valorProduto * (quantidadeAtual - quantidade);
                row.Cells[2].Value = subtotalAtual.ToString();
            }
            else
            {
                // Se a quantidade atual for igual ou menor que a quantidade a ser removida, remover a linha
                dataGridProdu.Rows.Remove(row);
            }

            // Atualizar o total subtraindo o subtotal do produto removido
            total -= subtotalRemovido;
            txtValor.Text = total.ToString();

            break; // Saia do loop após encontrar e processar o produto
        }
    }
}
        private void button5_Click(object sender, EventArgs e)
        {
            subtotalAtual = 0;
            produtos p2 = new produtos();

                if (dataGridProdu.SelectedRows.Count > 0)
                {
                    int codigoSelecionado = int.Parse(dataGridProdu.SelectedRows[0].Cells[0].Value.ToString());

                    // Consulta o produto selecionado
                    MySqlDataReader r = p2.consultarProduto(codigoSelecionado);
                    while (r.Read())
                    {
                        valor1 = float.Parse(r["preco"].ToString());

                        DialogResult result = MessageBox.Show(
                            "Deseja apagar mesmo?",
                            "Aviso",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button2);

                        if (result == DialogResult.Yes)
                        {
                            // Remove a quantidade de produtos selecionados
                            for (int i = 0; i < dataGridProdu.Rows.Count; i++)
                            {
                                if (int.Parse(dataGridProdu.Rows[i].Cells[0].Value.ToString()) == codigoSelecionado)
                                {


                                subtotalAtual = float.Parse(dataGridProdu.Rows[i].Cells[2].Value.ToString());
                                DataGridViewRow selectedRow = dataGridProdu.SelectedRows[0];
                                dataGridProdu.Rows.Remove(selectedRow);
                                  
                                    break;
                                }
                            }

                            // Atualiza o valor total subtraindo o valor do produto multiplicado pela quantidade removida
                            total1 = float.Parse(txtValor.Text);
                            total1 -= subtotalAtual;
                            txtValor.Text = total1.ToString();

                            // Se a tabela estiver vazia, define o total como 0
                            if (dataGridProdu.Rows.Count == 0)
                            {
                                total = 0;
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            // Não faz nada se o usuário optar por não apagar o produto
                        }
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para remover!");
            }

            if (dataGridProdu.Rows.Count == 0)
            {
                txtValor.Text = "0";
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
