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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202203", "cl202203", "cl*25042007"))
               Console.WriteLine("Conectado");
            else
               Console.WriteLine("Erro de conexão");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Usuario lg = new Usuario(txtEmail.Text,txtSenha.Text);
            Console.WriteLine(txtEmail.Text);
            Console.WriteLine(txtSenha.Text);
            MySqlDataReader re = lg.verificaLogin();
            bool existe = false;
            if (re.Read())
            {
                existe = true;
            }
            if (existe)
            {
                
                Form2 f2 = new Form2();
                f2.Show();
                Console.WriteLine("Cadastrado");
            }
            else
            {
                MessageBox.Show("Erro!!");
            }
            DAO_Conexao.con.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
