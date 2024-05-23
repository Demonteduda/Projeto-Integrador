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

        string metodopagamento;
        double valor1;
        String hojedia;
        string numCompra;
        double troco = 0;
        public pagamento(string valor, string metodocompra)
        {
            InitializeComponent();

            //deixando as texts indisponíveis para alteração, para não ocorrer erros nos valores das vendas
            txtTotalPago.Enabled = false;
            txtTroco.Enabled = false;
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

            if (numcodigos>0)
            {

                    numrandom = numeroaleatorio.Next(1000, 10000);
                    numCompra = $"{hojedia}{numrandom.ToString()}";
            }



            lblCodigoProduto.Text = "Número da compra: " + numCompra;
            if (metodocompra == "Débito")
            {
                txtTotalPago.Text = valor;
                txtTroco.Text = "0";
                txtValorEntregue.Text = valor;
            }

            else if (metodocompra == "Crédito")
            {
                txtTotalPago.Text = valor;
                txtTroco.Text = "0";
                txtValorEntregue.Text = valor;
            }

            else if (metodocompra == "Voucher")
            {
                txtTotalPago.Text = valor;
                txtTroco.Text = "0";
                txtValorEntregue.Text = valor;
            }

            else if (metodocompra == "Dinheiro")
            {
                txtTotalPago.Text = valor;
            }
            metodopagamento = metodocompra;
            valor1 = double.Parse(valor);
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (metodopagamento == "Dinheiro")
            {
                if (double.Parse(txtValorEntregue.Text) >= valor1)
                {
                    troco = double.Parse(txtValorEntregue.Text) - double.Parse(txtTotalPago.Text);
                    Compras compra2 = new Compras(metodopagamento, Int64.Parse(numCompra), valor1);
                    compra2.EfetuarCompraDinheiro(troco); ;

                }
                else
                {
                    MessageBox.Show("Valor entregue menor do que o valor total da compra!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Compras compra1 = new Compras(metodopagamento, Int64.Parse(numCompra) , valor1);
                 compra1.EfetuarCompra();
            }

            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
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
            if (e.KeyChar == 13)
            {
                troco = double.Parse(txtValorEntregue.Text) - double.Parse(txtTotalPago.Text);
                txtTroco.Text = ("R$" + troco);
            }

        }

        private void txtValorEntregue_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagamento_Load(object sender, EventArgs e)
        {
            txtValorEntregue.Focus();
        }
    }
}
