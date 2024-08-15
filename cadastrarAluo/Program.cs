using cadastrarAluo;
using cadastrarAluo.Dao;
using cadastrarAluo.Models;

try
{
	Conexao.Conectar();
}
catch (Exception ex)
{

    Console.WriteLine("Erro" + ex.Message);
}

try
{
    // Cadastrando aluno 1
    Aluno aluno = new Aluno();

    aluno.IdAluno = 1;
    aluno.Nome = "Natália";
    aluno.Cpf = "058.102.632-24";
    aluno.Email = "fernandesnatalia@gmail.com";
    aluno.Telefone = "5569992075679";
    aluno.DataNascimento = new DateOnly(2003, 05, 28);

    AlunoDao alunoDao = new AlunoDao();
    alunoDao.Insert(aluno);
    
    // Cadastrando aluno 2
    Aluno aluno2 = new Aluno();

    aluno2.IdAluno = 2;
    aluno2.Nome = "Fátima";
    aluno2.Cpf = "348.387.402-04";
    aluno2.Email = "fat.fer457@gmail.com";
    aluno2.Telefone = "5569992839065";
    aluno2.DataNascimento = new DateOnly(2003, 05, 28);

    AlunoDao alunoDao2 = new AlunoDao();
    alunoDao2.Insert(aluno2);
}
catch (Exception ex)
{

    Console.WriteLine($"Erro! {ex.Message}");
}