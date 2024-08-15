using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastrarAluo.Models;
using MySql.Data.MySqlClient;
namespace cadastrarAluo.Dao
{
    internal class AlunoDao
    {
        public void Insert (Aluno aluno)
        {
			try
			{
				string dataNascimento = aluno.DataNascimento.ToString("yyyy-MM-dd");
				string sql = " INSERT INTO Alunos(Id_Aluno, Nome, Cpf, Email, Telefone, Data_Nascimento)" +
								"VALUES(@IdAluno, @Nome, @Cpf, @Email, @Telefone,@DataNascimento)";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

				comando.Parameters.AddWithValue("@IdAluno", aluno.IdAluno);
				comando.Parameters.AddWithValue("@Nome", aluno.Nome);
				comando.Parameters.AddWithValue("@Cpf", aluno.Cpf);
				comando.Parameters.AddWithValue("@Email", aluno.Email);
				comando.Parameters.AddWithValue("@Telefone", aluno.Telefone);
				comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
				comando.ExecuteNonQuery();
				Console.WriteLine("Aluno Cadastrado com sucesso!");
				//Conexao.FecharConexao();
            }
			catch (Exception ex)
			{

				throw new Exception($" Erro ao cadastrar o aluno! {ex.Message}");
			}
        }



		public void Delete(Aluno aluno)
		{
			try
			{
				string sql = " DELETE FROM Alunos Where Id_Aluno = @IdAluno";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("Id_Aluno", aluno.IdAluno);
				comando.ExecuteNonQuery();
				Console.WriteLine("Cliente excluído com sucesso!");
				//Conexao.FecharConexao();
			}
			catch (Exception ex)
			{

				throw new Exception($"Erro ao excluir o cliente! {ex.Message}");
			}
		}



    }
}
