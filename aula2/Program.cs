// CRIANDO A CLASSE ALUNO
public class Aluno
{
    public string nome;
    public string cpf;
    public string email;
}

//CRIANDO A CLASSE FUNCIONARIO
public class Funcionario
{
    public string nome;
    public string cpf;
    public string email;
    public string senha_acesso;
    public string sexo;
    public DateOnly data_nascimento;

    public void CalcularIdade( )
    {
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - data_nascimento.Year; 

        if (dataAtual.Month < data_nascimento.Month)
        {
            idade -= 1;
        }
        else
        {
            if (dataAtual.Month == data_nascimento.Month)
            {
                if (dataAtual.Day < data_nascimento.Day)
                {
                    idade -= 1;
                }
            }
        }
        Console.WriteLine($" Idade Atual: {idade} ");
    }
}

// PROGRAMA PRINCIPAL
public class Program
{
    static void Main(string[] args)
    {
        // CRIANDO O PRIMEIRO OBJETO DA CLASSE ALUNO/ ESTANCIANDO
        Aluno aluno = new Aluno();
        aluno.nome = "Natália";
        aluno.cpf = "058.102.632-24";
        aluno.email = "fernandesnatalia@gmail.com";

        // CRIANDO O PRIMEIRO OBJETO DA CLASSE FUNCIONÁRIO/ ESTANCIANDO
        Funcionario funcionario1 = new Funcionario();
        funcionario1.nome = "João";
        funcionario1.cpf = "256.456-87";
        funcionario1.email = "ferreirajoao@gmail.com";
        funcionario1.senha_acesso = "****57**";
        funcionario1.sexo = "Masculino";
        funcionario1.data_nascimento = new DateOnly (2000,08,25);

        
       // CRIANDI O SEGUNDO OBJETO DA CLASSE FUNCIONARIO / ESTANCIANDO
       Funcionario funcionario2 = new Funcionario();
       Console.Write(@"                    --- CADASTRANDO FUNCIONÁRIO ---           
       ");

       Console.Write(@"           insira o nome do funcionario: ");
       funcionario2.nome = Console.ReadLine();
       Console.Write(@"       
                               insira o cpf do funcionario: ");
       funcionario2.cpf = Console.ReadLine();
       Console.Write(@"       
                               insira o email do funcionario: ");
       funcionario2.email = Console.ReadLine();
       Console.Write(@"       
                               insira o senha de acesso do funcionario: ");
       funcionario2.senha_acesso = Console.ReadLine();
       Console.Write(@"       
                               insira o sexo do funcionario: ");
       funcionario2.sexo = Console.ReadLine();
       Console.Write(@"       
                               insira o data de nascimento do funcionario: ");
       funcionario2.data_nascimento = DateOnly.Parse(Console.ReadLine());

       // CRIANDo O TERCEIRO OBJETO DA CLASSE FUNCIONARIO / ESTANCIANDO
       Funcionario funcionario3 = new Funcionario();
       Console.Write(@"                    --- CADASTRANDO FUNCIONÁRIO --- 

       ");

       Console.Write(@"            insira o nome do funcionario: ");
       funcionario3.nome = Console.ReadLine();
       Console.Write(@"       
                               insira o cpf do funcionario: ");
       funcionario3.cpf = Console.ReadLine();
       Console.Write(@"       
                               insira o email do funcionario: ");
       funcionario3.email = Console.ReadLine();
       Console.Write(@"       
                               insira o senha de acesso do funcionario: ");
       funcionario3.senha_acesso = Console.ReadLine();
       Console.Write(@"       
                               insira o sexo do funcionario: ");
       funcionario3.sexo = Console.ReadLine();
       Console.Write(@"       
                               insira o data de nascimento do funcionario: ");
       funcionario3.data_nascimento = DateOnly.Parse(Console.ReadLine());

        // APRESENTANDO OS DADOS DO PRIMEIRO OBJETO DA CLASSE FUNCIONÁRIO
        Console.WriteLine(@$" 
                         --- DADOS DOS FUNCIONÁRIOS --- 
         
                              NOME: {funcionario1.nome}
                              CPF: {funcionario1.cpf} 
                              E-MAIL: {funcionario1.email} 
                              SENHA DE ACESSO: {funcionario1.senha_acesso} 
                              SEXO: {funcionario1.sexo}
                              DATA DE NASCIMENTO: {funcionario1.data_nascimento}");
                              funcionario1.CalcularIdade( );
        Console.WriteLine(@$"      
                              NOME: {funcionario2.nome}
                              CPF: {funcionario2.cpf} 
                              E-MAIL: {funcionario2.email} 
                              SENHA DE ACESSO: {funcionario2.senha_acesso} 
                              SEXO: {funcionario2.sexo}
                              DATA DE NASCIMENTO: {funcionario2.data_nascimento}");
                              funcionario2.CalcularIdade( );
        Console.WriteLine(@$" 
                              NOME: {funcionario3.nome}
                              CPF: {funcionario3.cpf} 
                              E-MAIL: {funcionario3.email} 
                              SENHA DE ACESSO: {funcionario3.senha_acesso}
                              SEXO: {funcionario3.sexo}
                              DATA DE NASCIMENTO: {funcionario3.data_nascimento}");
                              funcionario3.CalcularIdade();



        // APRESENTANDO OS DADOS DO PRIMEIRO OBJETO DA CLASSE ALUNO 
        Console.WriteLine(@$" 
                         --- DADOS DOS ALUNOS --- 
         
                              NOME: {aluno.nome}
                              CPF: {aluno.cpf} 
                              E-MAIL: {aluno.email} ");
    }
       
}

