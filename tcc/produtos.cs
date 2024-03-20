using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc
{
    class produtos
    {
        String nome;
        float preco;
        int cod;
        int qtd;

        public produtos()
        {

        }

        public produtos(int cod)
        {
            this.cod = cod;
        }

        public produtos(string nome, float preco, int cod, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.cod = cod;
            this.qtd = qtd;
        }

        public MySqlDataReader cadastrarProduto(int cod1, string nome1, float preco1, int qtd1)
        {
            MySqlDataReader cad = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into SyProduto (codigo, nome, preco, quantidade) values " +
                 "('" + cod1 + "','" + nome1 + "','" + preco1 + "','" + qtd1 + "')", DAO_Conexao.con);
                cad = insere.ExecuteReader();
            }

            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public int verificaCadastro(int codi)
        {
           int cont = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand verifica = new MySqlCommand("Select count(*) from  SyProduto where codigo=" + codi, DAO_Conexao.con);
                cont = Convert.ToInt32(verifica.ExecuteScalar());
            }

            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cont;

        }

        public bool atualizarProduto(int cod2, string nome2, float preco2, int qtd2)
        {
            bool atu= false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("update SyProduto set nome ='"+nome2+"', preco='"+preco2+"'," +
                    " quantidade ='"+qtd2+"'  where codigo ="+cod2, DAO_Conexao.con);
               insere.ExecuteNonQuery();
                atu = true;
            }

            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return atu;
        }

        public MySqlDataReader consultarProdutos()
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM SyProduto ", DAO_Conexao.con);
                Console.WriteLine("SELECT preco FROM SyProduto WHERE codigo");
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }



        public MySqlDataReader consultarProduto(int cod)
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM SyProduto WHERE codigo = '" + cod + "'", DAO_Conexao.con);
                Console.WriteLine("SELECT * FROM SyProduto WHERE codigo = '" + cod + "'");
                consul = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return consul;
        }

    }
}
