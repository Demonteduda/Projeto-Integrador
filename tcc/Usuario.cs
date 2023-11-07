using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    class Usuario
    {
        private string email;
        private string senha;

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }

       public MySqlDataReader cadastrar()
        {
            MySqlDataReader cadastro = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into SyLogin (email,senha) values " +
                 "('" + email + "','" + Senha + "',')", DAO_Conexao.con);

                cadastro = insere.ExecuteReader();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
 
            return cadastro;
        }

        public MySqlDataReader consultarUsuario()
        {
            MySqlDataReader consul= null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM SyLogin", DAO_Conexao.con);
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           /* finally
            {
                DAO_Conexao.con.Close();
            }*/

            return consul;
        }
    

        public MySqlDataReader verificaLogin()
        {
            MySqlDataReader ve = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from SyLogin where email='" + email + "' and senha='" + senha + "'", DAO_Conexao.con);
                ve = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ve;
        }
    }
}
