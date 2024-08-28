using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabela_marca.Models;
using MySql.Data.MySqlClient;
namespace tabela_marca.DAO
{
    internal class MarcaDAO
    {
		public void Menu()
		{
			Conexao.Conectar();

			int menu = 0;

            Console.Write(@"	                                       ----- BEM VINDO ----- 
				Selecione abaixo a opção que deseja 
							1 | CADASTRAR
							2 | DELETAR
							3 | ATUALIZAR
							4 | LISTAR:   ");
			menu = Convert.ToInt32(Console.ReadLine());

           
					switch (menu)
					{
						// CADASTRAR/INSERT
						case 1:
							try
							{
								Console.WriteLine(@"                         
																		                           ---- CADASTRO ---- 
												");

								Marca marca = new Marca();

								Console.Write(@"          Digite o nome da marca: ");
								marca.Nome = Console.ReadLine();
								Console.Write(@"          Digite uma observação da marca: ");
								marca.Observacao = Console.ReadLine();
								Console.Write(@"          Digite a localidade da marca: ");
								marca.Localidade = Console.ReadLine();

								Insert(marca);
								Conexao.FecharConexao();

							}
							catch (Exception ex)
							{

								Console.WriteLine($"Erro ao cadastrar Marca! {ex.Message}");
							}
						break;

						//DELETAR/DELETE
						case 2:
							try
							{
								Console.WriteLine(@"                         
																		                           ---- EXCLUIR CADASTRO ---- 
												");

								Marca marca = new Marca();

								Console.Write(@"          Digite o ID da marca que deseja excluir: ");
								marca.Id_marca = Convert.ToInt32(Console.ReadLine());
								
								Delete(marca);
								Conexao.FecharConexao();

							}
							catch (Exception ex)
							{

								Console.WriteLine($"Erro ao Excluir Marca! {ex.Message}");
							}
						break; 

						//ATUALIZAR/UPDATE
						case 3:
							try
							{
								Console.WriteLine(@"                         
																		                           ---- ATUALIZAR CADASTRO ---- 
												");

								Marca marca = new Marca();

								Console.Write(@"          Digite o ID da marca que deseja atualizar: ");
								marca.Id_marca = Convert.ToInt32(Console.ReadLine());

								Console.WriteLine(@"                         
																		                           ---- CAMPO DE ATUALIZAÇÃO ---- 
												");

								Console.Write(@"          Digite o novo nome da marca: ");
								marca.Nome = Console.ReadLine();
								Console.Write(@"          Digite uma nova observação da marca: ");
								marca.Observacao = Console.ReadLine();
								Console.Write(@"          Digite a nova localidade da marca: ");
								marca.Localidade = Console.ReadLine();

								Update(marca);
								Conexao.FecharConexao();

							}
							catch (Exception ex)
							{

								Console.WriteLine($"Erro ao Atualizar Marca! {ex.Message}");
							}
						break; 

						//SELECIONAR/LISTAR
						case 4:
							try
							{
								var marcaDao = new MarcaDAO();

								List<Marca> marcas = marcaDao.List();	

								Console.WriteLine(@"                         
																		                           ---- CAMPO DE LISTAGEM ---- 
												"); 
								foreach (var marca in marcas)
								{
							Console.WriteLine($@" ID: {marca.Id_marca} | Nome: {marca.Nome} | Observação: {marca.Observacao} | Localidade: {marca.Localidade}");
								}
							}
							catch (Exception ex)
							{
								Console.WriteLine($"Erro! {ex.Message}");
							}
                    break;

						default:
									Console.Write(@"      Deseja Continuar ?
												Para CONTINUAR digite de 1 a 4.
												Para SAIR digite 0:"
											);
							break;
					}
        }

        public void Insert(Marca marca)
        {
			try
			{
				string sql = " INSERT INTO Marca(Nome, Observacao, Localidade)" +
					"VALUES(@nome, @observacao, @localidade)";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@nome", marca.Nome);
				comando.Parameters.AddWithValue("@observacao", marca.Observacao);
				comando.Parameters.AddWithValue("@localidade", marca.Localidade);
				comando.ExecuteNonQuery();
                Console.WriteLine("Marca Cadastrada com sucesso!");
				Conexao.FecharConexao();

            }
			catch (Exception ex)
			{

				throw new Exception ($"Erro ao cadastrar Marca! {ex.Message}");
			}
        }

		public void Delete(Marca marca)
		{
			try
			{
				string sql = "DELETE FROM Marca WHERE Id_marca= @id_marca";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@id_marca", marca.Id_marca);
				comando.ExecuteNonQuery ();
                Console.WriteLine("Marca excluída com sucesso!");
				Conexao.FecharConexao();
            }
			catch (Exception ex)
			{

				throw new Exception($"Erro ao excluir Marca {ex.Message}");
			}
		}

		public void Update(Marca marca)
		{
			try
			{
				string sql = "UPDATE Marca SET Nome = @nome, Observacao = @observacao, Localidade = @localidade WHERE Id_marca = @id_marca";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@nome", marca.Nome);
				comando.Parameters.AddWithValue("@observacao", marca.Observacao);
				comando.Parameters.AddWithValue("@localidade", marca.Localidade);
				comando.Parameters.AddWithValue("@id_marca", marca.Id_marca);
				comando.ExecuteNonQuery();
				Console.WriteLine("Marca Atualizada com sucesso!");
				Conexao.FecharConexao();
			}
			catch (Exception ex)
			{

				throw new Exception($"Erro ao atualizar marca {ex.Message}");
			}
        }

		public List<Marca> List()
		{
			List<Marca> marcas = new List<Marca>();

			try
			{
				var sql = "SELECT * FROM Marca ORDER BY Nome";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

				using (MySqlDataReader dr = comando.ExecuteReader()) 
				{
					while (dr.Read()) 
					{
						Marca marca = new Marca();
						marca.Id_marca = dr.GetInt32("Id_marca");
						marca.Nome = dr.GetString("Nome");
						marca.Observacao = dr.GetString("Observacao");
						marca.Localidade = dr.GetString("Localidade");
						marcas.Add(marca);
					}
				}
				Conexao.FecharConexao();
			}
			catch (Exception ex)
			{

                throw new Exception($"Erro ao listar marca {ex.Message}");
            }

            return marcas; 
		}
    }
}
