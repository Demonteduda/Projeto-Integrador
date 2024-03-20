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
    public partial class consulta : Form
    {  
        string codigo, nome, preco1, qtd;
        private readonly object OrderDetailsTable;

        public consulta()
        {
            InitializeComponent();

  
        }

        private void consulta_Load(object sender, EventArgs e)
        {

          

            produtos p1 = new produtos();
         MySqlDataReader r = p1.consultarProdutos();
            while (r.Read())
            {
                codigo = r["codigo"].ToString();
                nome = r["nome"].ToString();
                preco1= r["preco"].ToString();
                qtd = r["quantidade"].ToString(); 
                lbxProdutos.Items.Add("Código: " + codigo + ", Nome:" + nome + " - R$" + preco1 +", Quamtidade:"+qtd);
            }
            DAO_Conexao.con.Close();
            try
            {
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
