using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc
{
    class DAO_Conexao
    {
        public static MySqlConnection con { get; set; }

        public static Boolean getConexao(String local, String banco, string user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";" + "database=" + banco + "; password=" + senha + "; SslMode = none");
                retorno = true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

    }
}
