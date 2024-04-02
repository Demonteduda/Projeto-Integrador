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
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                  string nome = r["nome"].ToString();
                  string codigo = r["codigo"].ToString();
                  string preco = r["preco"].ToString();
                  string quantidade = r["quantidade"].ToString();

                    // Adicionar uma nova linha ao DataGridView e definir os valores das células
                  dataGridView1.Rows.Add(codigo, nome, preco, quantidade);
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
    }
}
