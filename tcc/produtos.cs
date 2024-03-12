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



        public MySqlDataReader consultarPreco(int cod)
        {
            MySqlDataReader consul = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT preco FROM SyProduto WHERE codigo = '" + cod + "'", DAO_Conexao.con);
                Console.WriteLine("SELECT preco FROM SyProduto WHERE codigo = '" + cod + "'");
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
