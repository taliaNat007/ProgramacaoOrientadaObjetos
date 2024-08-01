using aula31_07;


int opc = 0;

Console.Write(@"   Qual tipo de cliente deseja cadastrar ?
                            Digite 1 | Cliente Físico
                            Digite 2 | Cliente Jurídico:  ");
opc = Convert.ToInt32(Console.ReadLine());

if (opc == 1)
{
    ClientePF cliPF = new ClientePF();

    Console.WriteLine(@"                
                                       *** ENDEREÇO *** ");

    Console.Write(@"  
                       Digite o CEP: ");
    cliPF.endereco.cep = Console.ReadLine();
    Console.Write(@"  
                       Digite o LOGRADOURO: ");
    cliPF.endereco.logradouro = Console.ReadLine();
    Console.Write(@"  
                       Digite o NUMERO: ");
    cliPF.endereco.numero = Console.ReadLine();
    Console.Write(@"  
                       Digite o BAIRRO: ");
    cliPF.endereco.bairro = Console.ReadLine();
    Console.Write(@"  
                       Digite o CIDADE: ");
    cliPF.endereco.cidade = Console.ReadLine();




    Console.WriteLine(@"         
                               *** CADASTRO - Cliente Físico *** ");

    Console.Write(@"   
                       Digite o ID do cliente: ");
    cliPF.id_cliente = Convert.ToInt32(Console.ReadLine());
    Console.Write(@"   
                       Digite o NOME do cliente:");
    cliPF.nome = Console.ReadLine();
    Console.Write(@"   
                       Digite o CPF do cliente: ");
    cliPF.cpf = Console.ReadLine();
    Console.Write(@"   
                       Digite a FORMAÇÃO do cliente: ");
    cliPF.formacao = Console.ReadLine();
    Console.Write(@"   
                       Digite o EMAIL do cliente: ");
    cliPF.email = Console.ReadLine();
    Console.Write(@"   
                       Digite o TELEFONE do cliente: ");
    cliPF.telefone = Console.ReadLine();

    
}
else
{
    if (opc == 2)
    {
        ClientePJ cliPJ = new ClientePJ();

        Console.WriteLine(@"                
                                       *** ENDEREÇO *** ");

        Console.Write(@"  
                       Digite o CEP: ");
        cliPJ.endereco.cep = Console.ReadLine();
        Console.Write(@"  
                       Digite o LOGRADOURO: ");
        cliPJ.endereco.logradouro = Console.ReadLine();
        Console.Write(@"  
                       Digite o NUMERO: ");
        cliPJ.endereco.numero = Console.ReadLine();
        Console.Write(@"  
                       Digite o BAIRRO: ");
        cliPJ.endereco.bairro = Console.ReadLine();
        Console.Write(@"  
                       Digite o CIDADE: ");
        cliPJ.endereco.cidade = Console.ReadLine();




        Console.WriteLine(@"         
                               *** CADASTRO - Cliente JURÍDICO *** ");

        Console.Write(@"   
                       Digite o ID do cliente: ");
        cliPJ.id_cliente = Convert.ToInt32(Console.ReadLine());
        Console.Write(@"   
                       Digite o NOME FANTASIA do cliente:");
        cliPJ.nome_fantasia = Console.ReadLine();
        Console.Write(@"   
                       Digite o CNPJ do cliente: ");
        cliPJ.cnpj = Console.ReadLine();
        Console.Write(@"   
                       Digite a RAZAO SOCIAL do cliente: ");
        cliPJ.razao_social = Console.ReadLine();
        Console.Write(@"   
                       Digite o EMAIL do cliente: ");
        cliPJ.email = Console.ReadLine();
        Console.Write(@"   
                       Digite o TELEFONE do cliente: ");
        cliPJ.telefone = Console.ReadLine();


    }
    else
    {
        Console.WriteLine("Tipo de Cliente não encontrado");
    }
}