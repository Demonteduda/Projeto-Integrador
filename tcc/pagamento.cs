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
    public partial class pagamento : Form
    {
        List<string> listcod;
        List<string> listnome;
        List<string> listpreco;
        List<string> listqtd;
        string metodopagamento;
        double valor1;
        String hojedia;
        string numCompra;
        double troco = 0;
        public pagamento(string valor, string metodocompra, List<string> listcod1, List<string> listnome1, List<string> listpreco1, List<string> listqtd1)
        {
            InitializeComponent();

            listcod = listcod1;
            listnome = listnome1;
            listpreco = listpreco1;
            listqtd = listqtd1;


            //deixando as texts indisponíveis para alteração, para não ocorrer erros nos valores das vendas
            txtTotalPago1.Enabled = false;
            txtTroco1.Enabled = false;
            //pegando a data do dia atual e atribuindo a variavel 'diahoje'
            DateTime hoje1 = DateTime.Today;
            String diahoje = hoje1.Day.ToString();
            String meshoje = hoje1.Month.ToString();
            String anoatual = hoje1.Year.ToString();

            //se dia ou mes forem menores que 10, um caractere 0 é adicionado para formar um padrao de dois caracteres numerais
            if (int.Parse(diahoje) < 10)
            {
                diahoje = "0" + diahoje;
            }
            if (int.Parse(meshoje) < 10)
            {
                meshoje = "0" + meshoje;
            }
            hojedia = $"{diahoje}{meshoje}{anoatual}";


            Random numeroaleatorio = new Random();
            int numrandom = numeroaleatorio.Next(1000, 10000);

            //formando código de compra com a data atual+ um numero randomico
            numCompra = $"{hojedia}{numrandom.ToString()}";


            Compras compra1 = new Compras();
            int numcodigos = compra1.verificaNumeroCompra(Int64.Parse(numCompra));

            if (numcodigos > 0)
            {

                numrandom = numeroaleatorio.Next(1000, 10000);
                numCompra = $"{hojedia}{numrandom.ToString()}";
            }



            lblCodigoProduto.Text = "Número da compra: " + numCompra;
            if (metodocompra == "Débito")
            {
                txtTotalPago1.Text = valor;
                txtTroco1.Text = "0";
                txtValorEntregue1.Text = valor;
                txtValorEntregue1.Enabled = false;
            }

            else if (metodocompra == "Crédito")
            {
                txtTotalPago1.Text = valor;
                txtTroco1.Text = "0";
                txtValorEntregue1.Text = valor;
                txtValorEntregue1.Enabled = false;
            }

            else if (metodocompra == "Voucher")
            {
                txtTotalPago1.Text = valor;
                txtTroco1.Text = "0";
                txtValorEntregue1.Text = valor;
                txtValorEntregue1.Enabled = false;
            }

            else if (metodocompra == "Dinheiro")
            {
                txtTotalPago1.Text = valor;
            }
            metodopagamento = metodocompra;
            valor1 = double.Parse(valor);
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {



        }

        private void txtValorEntregue_Enter(object sender, EventArgs e)
        {

        }

        private void txtTroco_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorEntregue_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtValorEntregue_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagamento_Load(object sender, EventArgs e)
        {
            txtValorEntregue1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalPago_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblCodigoProduto_Click(object sender, EventArgs e)
        {

        }

        private void txtValorEntregue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                troco = double.Parse(txtValorEntregue1.Text) - double.Parse(txtTotalPago1.Text);
                txtTroco1.Text = ("R$" + troco);
            }
        }

        private void btnConcluirPagamento_Click(object sender, EventArgs e)
        {
            if (metodopagamento == "Dinheiro")
            {
                if (txtValorEntregue1.Text != "")
                {
                    if (double.Parse(txtValorEntregue1.Text) >= valor1)
                    {
                        troco = double.Parse(txtValorEntregue1.Text) - double.Parse(txtTotalPago1.Text);
                        Compras compra2 = new Compras(metodopagamento, Int64.Parse(numCompra), valor1);
                        compra2.EfetuarCompraDinheiro(troco);
                        //Mostrando dados da compra
                        MessageBox.Show("Códigos: " + string.Join(", ", listcod) + "\n Nomes: " + string.Join(",", listnome) + "" +
                        "\n Preços: " + string.Join(", ", listpreco) + "\n Quantidades: " + string.Join(",", listqtd));

                        // Verifica se ambas as listas têm o mesmo número de elementos
                        if (listcod.Count != listqtd.Count)
                        {
                            Console.WriteLine("As listas têm tamanhos diferentes. Não é possível processar.");
                            return;
                        }
                        // pelo tamanho das listas, chama o método salvarCompra e salva os valores
                        for (int i = 0; i < listcod.Count; i++)
                        {
                            Compras compraA = new Compras(Int64.Parse(numCompra));
                            string codprod = listcod[i];
                            string quantidade = listqtd[i];
                            compraA.SalvarCompra(codprod, quantidade);
                        }

                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Valor entregue menor do que o valor total da compra!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informe o valor pago pelo cliente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
            else
            {
                Compras compra1 = new Compras(metodopagamento, Int64.Parse(numCompra), valor1);
        compra1.EfetuarCompra();
                //Mostrando dados da compra

                // Verifica se ambas as listas têm o mesmo número de elementos
                if (listcod.Count != listqtd.Count)
                {
                    Console.WriteLine("As listas têm tamanhos diferentes. Não é possível processar.");
                    return;
                }
                // pelo tamanho das listas, chama o método salvarCompra e salva os valores
                for (int i = 0; i < listcod.Count; i++)
                {
                    Compras compraA = new Compras(Int64.Parse(numCompra));
                    string codprod = listcod[i];
                    string quantidade = listqtd[i];
                    compraA.SalvarCompra(codprod, quantidade);
                }
                MessageBox.Show("AAAAAAAAA Códigos: " + string.Join(", ", listcod) + "\n Nomes: " + string.Join(",", listnome) + "" +
                "\n Preços: " + string.Join(", ", listpreco)+ "\n Quantidades: " + string.Join(",", listqtd) );
                Form2 f2 = new Form2();
        f2.Show();
                this.Close();
    }

        }
    }
}
