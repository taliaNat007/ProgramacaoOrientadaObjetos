using cadastrarAluo;
using cadastrarAluo.Dao;
using cadastrarAluo.Models;

try
{
    
    // Cadastrando aluno 1
    Aluno aluno = new Aluno();

    aluno.Nome = "Natália";
    aluno.Cpf = "058.102.632-24";
    aluno.Email = "fernandesnatalia@gmail.com";
    aluno.Telefone = "5569992075679";
    aluno.DataNascimento = new DateOnly(2003, 05, 28);

    AlunoDao alunoDao = new AlunoDao();
    alunoDao.Insert(aluno);
    
    // Deletar aluno 
    Aluno aluno1 = new Aluno();
    aluno1.IdAluno = 1;
    Aluno aluno5 = new Aluno();
    aluno5.IdAluno = 5;
   

    AlunoDao adao1 = new AlunoDao();
    adao1.Delete(aluno1);
    AlunoDao adao5 = new AlunoDao();
    adao5.Delete(aluno5);
    //alunoDao.Delete(aluno);

    Conexao.Conectar();

}
catch (Exception ex)
{

    Console.WriteLine($"Erro! {ex.Message}");
}