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
        public pagamento(string valor, string metodocompra)
        {
            InitializeComponent();

            //pegando a data do dia atual e atribuindo a variavel 'diahoje'
            DateTime hoje1 = DateTime.Today;
            String diahoje = hoje1.Day.ToString();
            String meshoje = hoje1.Month.ToString();
            String anoatual = hoje1.Year.ToString();
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
                    txtTroco.Text = (valor1 - double.Parse(txtValorEntregue.Text)).ToString();


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
            if (e.KeyChar == 13)
            {
                double troco = double.Parse(txtValorEntregue.Text) - double.Parse(txtTotalPago.Text);
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
