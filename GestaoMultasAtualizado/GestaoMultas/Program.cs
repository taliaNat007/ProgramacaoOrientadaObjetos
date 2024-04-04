Console.WriteLine("Digite o CPF:");
string cpf = Console.ReadLine();

bool valido = ValidadorCPF.ValidarCPF(cpf);

if (valido)
{
    Console.WriteLine("CPF válido.");
}
else
{ 
    Console.WriteLine("CPF inválido.");
}

// Validacao.SetCpf(cpf);
//Console.WriteLine(Validacao.GetCpf());