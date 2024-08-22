using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cadastrarAluo
{
    public static class Conexao
    {
        static MySqlConnection conexao;
        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=localhost;port=3360;uid=root;pwd=root;database=simulado";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao realizar a conexão com a base de dados!"+ex.Message);
            }
            return conexao;
        }

    }
}
