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
    public partial class fechamento : Form
    {
        public double valordia=0;
        public double valortroco=0;
        public double valorlucro=0;
        public fechamento()
        {
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            DateTime diahoje = DateTime.Today;
            String diaatual = diahoje.Day.ToString();
            String mesatual = diahoje.Month.ToString();
            String anoatual = diahoje.Year.ToString();

            //se dia ou mes forem menores que 10, um caractere 0 é adicionado para formar um padrao de dois caracteres numerais
            if (int.Parse(diaatual)<10)
            {
                diaatual = "0"+diaatual;
            }
            if(int.Parse(mesatual)<10)
            {
                mesatual = "0" + mesatual;
            }
            String diahoje1 = $"{diaatual}/{mesatual}/{anoatual}";
            lblDiaHoje.Text = lblDiaHoje.Text +": "+diahoje1;
            //lblDiaHoje.ForeColor = Color.MediumTurquoise;


            Compras comprashoje = new Compras();
            MySqlDataReader rc1 = comprashoje.totalvendido();

            while(rc1.Read())
            {
                valordia +=  double.Parse(rc1["Valor"].ToString());
            }
            DAO_Conexao.con.Close();
            MySqlDataReader r2 = comprashoje.totalvendidoDinheiro();
            while(r2.Read())
            {
                valordia += double.Parse(r2["Valor"].ToString());
                valortroco += double.Parse(r2["TrocoDado"].ToString());
            }
            DAO_Conexao.con.Close();
    
            comprashoje.totalvendidoDinheiro();
            valorlucro = valordia - valortroco;
            txtVendas.Text = "R$" + valordia.ToString();
            txtTroco.Text = "R$" + valortroco.ToString();
            txtLucro.Text = "R$" + valorlucro.ToString();
        }

        public fechamento(double valor)
        {
            InitializeComponent();
            valordia = valor;
            txtVendas.Text = valordia.ToString();
           
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void txtVendas_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void fechamento_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFecharodia_Click(object sender, EventArgs e)
        {
            Compras comprasdia = new Compras();
            // Se já houver um fechamento nesse mesmo dia exclui o anterior e adiciona o novo
            int num1 = comprasdia.verificaFechamento();
            if (num1 > 0)
            {
                DialogResult resposta = MessageBox.Show(
                    "Já existe um fechamento nesse dia! Deseja fazer um novo?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    Compras compraex = new Compras();
                    DAO_Conexao.con.Close();
                    compraex.excluiFechamento();
                    compraex.fechamentododia(valorlucro, valordia, valortroco);
                }
                else if (resposta == DialogResult.No)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Close();
                }
                // Se a resposta não for nem Yes nem No, não faz nada.
            }
            else
            {
                comprasdia.fechamentododia(valorlucro, valordia, valortroco);
            }

        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            DateTime dataescolhida = dateTimePicker1.Value;
            String dia = dataescolhida.Day.ToString();
            String mes = dataescolhida.Month.ToString();
            String ano = dataescolhida.Year.ToString();

           
            if (dataescolhida == null)
            {
                MessageBox.Show("Informe uma data para fazer a consulta!");
            }
            else
            {
                bool dataexistente = false;
                string codigo;
                string valortot;
                string formapagamento;
                string troco;
                dataGridView1.Rows.Clear();

                //se dia ou mes forem menores que 10, um caractere 0 é adicionado para formar um padrao de dois caracteres numerais
                if (int.Parse(dia) < 10)
                {
                    dia = "0" + dia;
                }
                if (int.Parse(mes) < 10)
                {
                    mes = "0" + mes;
                }  
                string dataesc = $"{dia}/{mes}/{ano}";
                DateTime dataescolhida1 = dataescolhida.Date;

                Compras c1 = new Compras();
                MySqlDataReader r1 = c1.consultarComprasData(dataescolhida1);
                while(r1.Read())
                {

                  
                    dataexistente = true;
                    codigo = r1["Codigo"].ToString();
                    valortot = r1["Valor"].ToString();
                    formapagamento = r1["FormaPagamento"].ToString();

                    dataGridView1.Rows.Add(dataesc, codigo, valortot, formapagamento, "R$0");
                    dataGridView1.ForeColor = Color.Black;
                                     
                }
                r1.Close();

                MySqlDataReader r2 = c1.consultarComprasDataDinheiro(dataescolhida1);

                if (!r2.HasRows)
                {
                    Console.WriteLine("Nenhum dado encontrado em r2.");
                }
                else
                {

                    while (r2.Read())
                    {

                        dataexistente = true;
                        codigo = r2["Codigo"].ToString();
                        valortot = r2["Valor"].ToString();
                        formapagamento = r2["FormaPagamento"].ToString();
                        troco = r2["TrocoDado"].ToString();

                        dataGridView1.Rows.Add(dataesc, codigo, valortot, formapagamento, "R$"+troco);
                        dataGridView1.ForeColor = Color.Black;

                    }
                }
                r2.Close();

                if (dataexistente==false)
                    {
                        MessageBox.Show("Não há compras nesse dia!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }

           
           
        }
    }
}
