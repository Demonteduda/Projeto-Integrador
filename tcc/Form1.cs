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
           // btnLogin.FlatStyle = FlatStyle.Flat;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202203", "cl202203", "cl*25042007"))
               Console.WriteLine("Conectado");
            else
               Console.WriteLine("Erro de conexão");

        }

        public class CirculatTextBox : TextBox
        {
        
            protected override void 
             OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Graphics graphics = e.Graphics;
                Pen pen = new Pen(Color.Black,2);
                graphics.DrawEllipse(pen, 0, 0, Width - 1, Height - 1);
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

            Form1 f1 = new Form1();
                f1.Close();
                Console.WriteLine("Cadastrado");
            Usuario lg = new Usuario(txtEmail.Text,txtSenha.Text);
            Console.WriteLine(txtEmail.Text);
            Console.WriteLine(txtSenha.Text);
            if(txtSenha.TextLength<4)
            {
                MessageBox.Show("Senha deve conter mais de 3 caracteres!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

             MySqlDataReader re = lg.verificaLogin();
            bool existe = false;
            if (re.Read())
            {
                existe = true;
            }
            if (existe)
            {
              /* Form2 f2 = new Form2();
                f2.Show();
            this.Hide();*/

            }
            else
            {
                MessageBox.Show("Login Ou Senha incorretos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            //txtSenha.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
