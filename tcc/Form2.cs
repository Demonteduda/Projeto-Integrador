﻿using MySql.Data.MySqlClient;
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
        public float total;
        public string valor;
        public string nome1;
       
        public Form2()
        {
            InitializeComponent();

            txtValor.Enabled = false;
            //initializeFullscreenImage();

        }

        /* private void initializeFullscreenImage()
         {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

         }
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            txtCod.Select();

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

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbPagamento.SelectedIndex==0)
            {
                pagamento pg = new pagamento(txtValor.Text);
                pg.Show();
            }
            lbProdutos.Items.Clear();
        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro cd = new cadastro();
            cd.Show();
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
            if (e.KeyChar == 13)
            {
                produtos p1 = new produtos();
                MySqlDataReader r = p1.consultarProduto(int.Parse(txtCod.Text));
                while (r.Read())
                {
                    valor = r["preco"].ToString();
                    nome1 = r["nome"].ToString();
                }
                DAO_Conexao.con.Close();          
                try
                {
                    lbProdutos.Items.Add("Código: " + txtCod.Text + ", Nome:" + nome1 + " - R$" + valor);
                    total += float.Parse(valor);
                    txtValor.Text = total.ToString();
                    txtCod.Text = "";
                }
                catch(Exception ex)
                {
                    lbProdutos.Items.Clear();
                    MessageBox.Show("Produto não cadastrado");
                }
            }
            
         

              //  p1.consultarPreco(int.Parse( txtCod.Text)) ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCod.Select();
            if (lbProdutos.Items.Count < 0)
            {
                MessageBox.Show("O ListBox está vazio.");
               
            }
            else
            {
                lbProdutos.Items.Clear();
                txtValor.Text = "";
                txtCod.Text = "";
                total = 0;
            }
            
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
                cmbPagamento.DroppedDown = true;
                cmbPagamento.SelectedIndex = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
