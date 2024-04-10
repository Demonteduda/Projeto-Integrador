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
               produtos p1 = new produtos();
                if (p1.verificaCadastro(int.Parse(txtCodigo.Text))==0)
                {

                    p1.cadastrarProduto(int.Parse(txtCodigo.Text), txtdescricao.Text, float.Parse(txtpreco.Text), int.Parse(txtqtd.Text));
                    MessageBox.Show("Produto Cadastrado!");
                    txtCodigo.Text = "";
                    txtdescricao.Text = "";
                    txtpreco.Text = "";
                    txtqtd.Text = "";

                }
                else
                    MessageBox.Show("Um produto com esse código já está Cadastrado");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                produtos p2 = new produtos();

                MySqlDataReader r = p2.consultarProduto(int.Parse(txtCodigo.Text));


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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                produtos p3 = new produtos();

                p3.atualizarProduto(int.Parse(txtCodigo.Text), txtdescricao.Text, float.Parse(txtpreco.Text), int.Parse(txtqtd.Text));
                MySqlDataReader r = p3.consultarProduto(int.Parse(txtCodigo.Text));
                while (r.Read())
                {
                    txtCodigo.Text = (r["codigo"].ToString());
                    txtdescricao.Text = (r["nome"].ToString());
                    txtpreco.Text = (r["preco"].ToString());
                    txtqtd.Text = (r["quantidade"].ToString());
                }
                MessageBox.Show("Produto Atualizado!");
                txtCodigo.Text = "";
                txtdescricao.Text = "";
                txtpreco.Text = "";
                txtqtd.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
