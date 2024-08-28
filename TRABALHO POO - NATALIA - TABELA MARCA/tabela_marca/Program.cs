using tabela_marca;
using tabela_marca.Models;
using tabela_marca.DAO;

try
{
    Conexao.Conectar();

    /*
    Marca marcaupdate = new Marca();

    Console.WriteLine(" Digite o ID: ");
    marcaupdate.Id_marca = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine($" Digite um novo nome para a marca {marcaupdate.Nome}: ");
    marcaupdate.Nome = Console.ReadLine();
    Console.WriteLine($" Digite uma nova observação para a marca {marcaupdate.Nome}: ");
    marcaupdate.Observacao = Console.ReadLine();
    Console.WriteLine($" Digite a nova localidade da marca {marcaupdate.Nome}: ");
    marcaupdate.Localidade = Console.ReadLine();
    
    */


    MarcaDAO menu = new MarcaDAO();
    menu.Menu();

}
catch (Exception ex)
{
    Console.WriteLine($"ERRO! {ex.Message}");
}