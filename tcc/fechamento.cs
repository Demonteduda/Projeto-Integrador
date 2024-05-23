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
    }
}
