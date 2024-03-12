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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                DAO_Conexao.con.Open();
                produtos p1 = new produtos();
                MySqlDataReader r = p1.cadastrarProduto(int.Parse(txtCodigo.Text), txtdescricao.Text, float.Parse(txtpreco.Text), int.Parse(txtqtd.Text));
                DAO_Conexao.con.Close();

                while (r.Read())
                {

                    txtCodigo.Text = (r["codigo"].ToString());
                    txtdescricao.Text = (r["nome"].ToString());
                    txtpreco.Text = (r["preco"].ToString());
                    txtqtd.Text = (r["quantidade"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }
    }
}
