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
        public string nome1, quan;
        public string quantidade;
        public string qtd1, codi;
        public int cont = 0;
        public float total1 = 0;
        public float valor1 = 0;
        public float total2 = 0;
        public float subtotalAtual = 0;
        public double ValorFecha = 0;
        public double valorAcumulado;
        public double valorTextBox;

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

            cmbPagamento.Items.Add("Débito");
            cmbPagamento.Items.Add("Crédito");
            cmbPagamento.Items.Add("Dinheiro");
            cmbPagamento.Items.Add("Voucher");

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

        public MySqlDataReader MandarValor(double va)
        {
            MySqlDataReader manda = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into FechamentoSy (valorAcumulado) values " +
                 "('" + va + "')", DAO_Conexao.con);
                manda = insere.ExecuteReader();
            }

            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return manda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out valorTextBox))
            {
                // Recupera o valor acumulado das configurações do aplicativo
                valorAcumulado = Properties.Settings.Default.ValorAcumulado;

                // Adiciona o valor do TextBox ao valor acumulado
                valorAcumulado += valorTextBox;

                // Salva o novo valor acumulado nas configurações do aplicativo
                Properties.Settings.Default.ValorAcumulado = valorAcumulado;
                Properties.Settings.Default.Save();

                
              
                // Exibe o valor acumulado em uma MessageBox
                //MessageBox.Show($"Valor acumulado: {valorAcumulado}");

            }

            fechamento ft = new fechamento(valorAcumulado);

            

            if (cmbPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo de pagamento");
            }
            else
            {

             List<string> listaCodigo = new List<string>();
             List<string> listaNome = new List<string>();
             List<string> listaPreco = new List<string>();
             List<string> listaQuantidade = new List<string>();

                foreach (DataGridViewRow row in dataGridProdu.Rows)
                {
                    if (row.IsNewRow) continue; // Ignora a linha de novo item, se existir

                    // Pega os valores de cada célula e adiciona às respectivas listas(de acordo com o que é)
                    listaCodigo.Add(row.Cells[0].Value?.ToString() ?? string.Empty);
                    listaNome.Add(row.Cells[1].Value?.ToString() ?? string.Empty);
                    listaPreco.Add(row.Cells[2].Value?.ToString() ?? string.Empty);
                    listaQuantidade.Add(row.Cells[3].Value?.ToString() ?? string.Empty);


                     /*MostrarDados();
                    
                   void MostrarDados()
                        {
                            Console.WriteLine("Códigos: " + string.Join(", ", listaCodigo));
                            Console.WriteLine("Nomes: " + string.Join(", ", listaNome));
                            Console.WriteLine("Preços: " + string.Join(", ", listaPreco));
                            Console.WriteLine("Quantidades: " + string.Join(", ", listaQuantidade));
                        }*/
                }


                if (cmbPagamento.SelectedItem.ToString() == "Dinheiro")
                {
                    pagamento pg = new pagamento(total.ToString(), cmbPagamento.Text, listaCodigo, listaNome, listaPreco, listaQuantidade);
                    pg.Show();
                    //this.Close();
                }

                if (cmbPagamento.SelectedItem.ToString() == "Crédito")
                {
                    pagamento pg = new pagamento(total.ToString(), cmbPagamento.Text, listaCodigo, listaNome, listaPreco, listaQuantidade);
                    pg.Show();
                    //this.Close();
                }

                if (cmbPagamento.SelectedItem.ToString() == "Débito")
                {
                    pagamento pg = new pagamento(total.ToString(), cmbPagamento.Text, listaCodigo, listaNome, listaPreco, listaQuantidade);
                    pg.Show();
                    //this.Close();
                }

                if (cmbPagamento.SelectedItem.ToString() == "Voucher")
                {
                    pagamento pg = new pagamento(total.ToString(), cmbPagamento.Text, listaCodigo, listaNome, listaPreco, listaQuantidade);
                    pg.Show();
                    //this.Close();
                }
            }

           


        }

       

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int validacao = 0;


            if (dataGridProdu.Rows.Count > 0)
            {
                //pega a ultima linha do datagrid
                DataGridViewRow ultimaLinha = dataGridProdu.Rows[dataGridProdu.Rows.Count - 1];
                // Verifica se a ultima linha possui 'codi'
                if (ultimaLinha.Cells[0].Value.ToString() == codi)
                {
                    validacao = 1;

                    // Obtém o valor do produto da célula
                    float valorProduto = float.Parse(ultimaLinha.Cells[2].Value.ToString());

                    // Calcula o subtotal do produto atual considerando a nova quantidade selecionada
                    float subtotalProduto = valorProduto * cmbQuantidade.SelectedIndex;
                    // Atualiza as células com os novos valores
                    ultimaLinha.Cells[2].Value = subtotalProduto.ToString();
                    ultimaLinha.Cells[3].Value = cmbQuantidade.SelectedIndex;
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
            txtValor.Text = "R$"+total.ToString();

            txtCod.Focus();
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
            int quantTotal = 0;
            string valor = "";
            string nome1 = "";
            string quantidade = "";

            if (e.KeyChar == 13) // Se a tecla pressionada for Enter
            {
                codi = txtCod.Text;
                if (!string.IsNullOrEmpty(codi))
                {
                    bool produtoExistente = false;
                    bool produtocadastrado = false;

                    // Verificar se o produto já foi adicionado
                    foreach (DataGridViewRow row in dataGridProdu.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codi)
                        {
                            produtoExistente = true;
                            break;
                        }
                    }

                    produtos p1 = new produtos();
                    MySqlDataReader r = p1.consultarProduto(int.Parse(codi));

                    if (!produtoExistente)
                    {

                        while (r.Read())
                        {
                            if (codi == r["codigo"].ToString())
                            {
                                produtocadastrado = true;
                                valor = r["preco"].ToString();
                                nome1 = r["nome"].ToString();
                                quantidade = r["quantidade"].ToString();

                                dataGridProdu.Rows.Add(codi, nome1, valor, 1);

                                cmbQuantidade.Items.Clear();
                                for (int j = 0; j <= int.Parse(quantidade); j++)
                                {
                                    cmbQuantidade.Items.Add(j.ToString());
                                }

                                total += float.Parse(valor);
                              
                                break; // Encerrar o loop enquanto encontrar um produto
                            }
                        }
                        if (produtocadastrado == false)
                        {
                            MessageBox.Show("Não há produtos cadastrados com esse código!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {

                        while (r.Read())
                        {
                            if (codi == r["codigo"].ToString())
                            {
                                quantTotal = int.Parse(r["quantidade"].ToString());
                                valor = r["preco"].ToString();
                                nome1 = r["nome"].ToString();

                            }
                        }

                        foreach (DataGridViewRow row in dataGridProdu.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == codi)
                            {
                                // Subtraindo valor da quantidade total de acordo com a quantidade já adicionada:
                                quantTotal = quantTotal - int.Parse(row.Cells[3].Value.ToString());
                            }
                        }

                        if (quantTotal > 0)
                        {
                            // Passando a quantidade restante para a ComboBox de quantidade:
                            cmbQuantidade.Items.Clear();
                            for (int j = 0; j <= quantTotal; j++)
                            {
                                cmbQuantidade.Items.Add(j.ToString());
                            }
                            dataGridProdu.Rows.Add(codi, nome1, valor, 1);
                            total += float.Parse(valor);

                        }
                        else
                        {
                            MessageBox.Show("Quantidade no estoque esgotada para esse produto!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    DAO_Conexao.con.Close();
                    // Atualizar o total e limpar o campo de código
                    txtValor.Text = "R$"+total.ToString();
                    txtCod.Text = "";
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
                    MessageBox.Show("A tabela está vazia.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                total -= subtotalAtual;
                                MessageBox.Show("R$"+total.ToString());
                                break;
                            }
                        }

                        // Atualiza o valor total subtraindo o valor do produto multiplicado pela quantidade removida

                        
                        txtValor.Text = "R$"+total.ToString();

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
            fechamento fc = new fechamento();
            fc.Show();
            this.Hide();



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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Exibe a ComboBox para o usuário escolher o método de pagamento
            cmbPagamento.Visible = true;
        }

        private void cmbQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void cmbQuantidade_Enter(object sender, EventArgs e)
        {

        }
    }
}


