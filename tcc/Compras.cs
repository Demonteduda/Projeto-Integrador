using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc
{
    class Compras
    {
        String formapagamento;
        Int64 codigo;
        double valor;
        DateTime datahoje = DateTime.Today;

        public Compras()
        {

        }

        public Compras(string formapagamento, Int64 codigo, double valor)
        {
            this.formapagamento = formapagamento;
            this.codigo = codigo;
            this.valor = valor;
        }

        public MySqlDataReader EfetuarCompra()
        {

            MySqlDataReader compra = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO SyCompras (Codigo, Valor, FormaPagamento, Data) VALUES (@codigo, @valor, @formapagamento, @datahoje)", DAO_Conexao.con);
                insere.Parameters.AddWithValue("@codigo", codigo);
                insere.Parameters.AddWithValue("@valor", valor);
                insere.Parameters.AddWithValue("@formapagamento", formapagamento);
                insere.Parameters.AddWithValue("@datahoje", datahoje);
                compra = insere.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return compra;
        }


        public MySqlDataReader EfetuarCompraDinheiro(double troco)
        {

            MySqlDataReader compra = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO SyCompras (Codigo, Valor, FormaPagamento, TrocoDado, Data) VALUES (@codigo, @valor, @formapagamento, @troco, @datahoje)", DAO_Conexao.con);
                insere.Parameters.AddWithValue("@codigo", codigo);
                insere.Parameters.AddWithValue("@valor", valor);
                insere.Parameters.AddWithValue("@formapagamento", formapagamento);
                insere.Parameters.AddWithValue("@troco", troco);
                insere.Parameters.AddWithValue("@datahoje", datahoje);
                compra = insere.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return compra;
        }

        public int verificaNumeroCompra(Int64 numpedido)
        {
            int numcompra = 0;
                DAO_Conexao.con.Open();

            try
            {
                MySqlCommand verifica = new MySqlCommand("SELECT count(*) FROM SyCompras WHERE Codigo = @numpedido" , DAO_Conexao.con);
                verifica.Parameters.AddWithValue("@numpedido", numpedido);
                numcompra = Convert.ToInt32(verifica.ExecuteScalar());

            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return numcompra;
        }

        public string Formapagamento { get => formapagamento; set => formapagamento = value; }
        public Int64 Codigo { get => codigo; set => codigo = value; }
        public double Valor { get => valor; set => valor = value; }

    }
}
