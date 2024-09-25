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

        public Compras(Int64 codigo)
        {
            this.codigo = codigo;
        }

        public MySqlDataReader SalvarCompra(string codprod, string quantidade)
        {

            MySqlDataReader compra = null;

            try
            {
                Console.WriteLine("Entrooooooooou");
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO SyComprasIndividuais (CodigoCompra, Data, CodigoProduto, Quantidade) VALUES (@codicompra, @datahoje, @codiprod, @qtd )", DAO_Conexao.con);
                insere.Parameters.AddWithValue("@codicompra", codigo);
                insere.Parameters.AddWithValue("@datahoje", datahoje);
                insere.Parameters.AddWithValue("@codiprod", codprod);
                insere.Parameters.AddWithValue("@qtd", quantidade);
                
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


        public MySqlDataReader EfetuarCompra()
        {

            MySqlDataReader compra = null;

            try
            {
                Console.WriteLine("entroooooooooouu efetuar compra");
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

        public MySqlDataReader fechamentododia(double lucro, double total, double troco)
        {
            MySqlDataReader dadosdodia = null;
            DAO_Conexao.con.Close();

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO SyFechamento (ValorLucro, Data, ValorTotal, ValorTroco) VALUES (@lucro, @datahoje, @total, @troco)", DAO_Conexao.con);
                comando.Parameters.AddWithValue("@lucro", lucro);
                comando.Parameters.AddWithValue("@datahoje", datahoje);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@troco", troco);
                dadosdodia = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return dadosdodia;
        }

        public MySqlDataReader EfetuarCompraDinheiro(double troco)
        {

            MySqlDataReader compra = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO SyComprasDinheiro (Codigo, Valor, FormaPagamento, TrocoDado, Data) VALUES (@codigo, @valor, @formapagamento, @troco, @datahoje)", DAO_Conexao.con);
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

        public MySqlDataReader totalvendidoDinheiro()
        {
            MySqlDataReader totaldia = null;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retornavalor = new MySqlCommand("SELECT * FROM SyComprasDinheiro WHERE Data = @datahoje", DAO_Conexao.con);
                retornavalor.Parameters.AddWithValue("@datahoje", datahoje);
                totaldia = retornavalor.ExecuteReader();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }

            return totaldia;
        }

        public MySqlDataReader consultarComprasDataDinheiro(DateTime dataescolhida)
        {
            MySqlDataReader informCompras = null;
            DAO_Conexao.con.Close();

            try
            {
                Console.WriteLine("Entrooooooooooooooooooouuuuuuuu Dinheiro");
                DAO_Conexao.con.Open();
                MySqlCommand retornavalor = new MySqlCommand("SELECT * FROM SyComprasDinheiro WHERE Data = @dataescolhida", DAO_Conexao.con);
                retornavalor.Parameters.AddWithValue("@dataescolhida", dataescolhida);
                informCompras = retornavalor.ExecuteReader();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }


            return informCompras;
        }

        public MySqlDataReader consultarComprasData(DateTime dataescolhida)
        {
            MySqlDataReader informCompras = null;
            DAO_Conexao.con.Close();

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retornavalor = new MySqlCommand("SELECT * FROM SyCompras WHERE Data = @dataescolhida", DAO_Conexao.con);
                retornavalor.Parameters.AddWithValue("@dataescolhida", dataescolhida);
                informCompras = retornavalor.ExecuteReader();
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }


            return informCompras;
        }


        public MySqlDataReader totalvendido()
        {
            MySqlDataReader totaldia = null;
            DAO_Conexao.con.Close();

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand retornavalor = new MySqlCommand("SELECT * FROM SyCompras WHERE Data = @datahoje", DAO_Conexao.con);
                retornavalor.Parameters.AddWithValue("@datahoje", datahoje);
                totaldia = retornavalor.ExecuteReader();
            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1.ToString());
            }
        

            return totaldia;
        }

        public MySqlDataReader excluiFechamento()
        {
            MySqlDataReader excluir = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand deletaFecha= new MySqlCommand("DELETE FROM SyCompras WHERE Data = @datahoje", DAO_Conexao.con);
                deletaFecha.Parameters.AddWithValue("@datahoje", datahoje);
                excluir = deletaFecha.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return excluir;

        }

        public int verificaFechamento()
        {
            int numFechamentos = 0;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand verificaFecha = new MySqlCommand("SELECT Count(*) FROM SyFechamento WHERE Data = @datahoje", DAO_Conexao.con);
                verificaFecha.Parameters.AddWithValue("@datahoje", datahoje);
                numFechamentos = Convert.ToInt32(verificaFecha.ExecuteScalar());
                Console.WriteLine("aaaaaaaaaaaaaaaa"+numFechamentos.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return numFechamentos;
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
