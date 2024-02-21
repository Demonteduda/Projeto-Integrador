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

        public produtos()
        {

        }

        public produtos(int cod)
        {
            this.cod = cod;
        }

        public produtos(string nome, float preco, int cod)
        {
            this.nome = nome;
            this.preco = preco;
            this.cod = cod;
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
