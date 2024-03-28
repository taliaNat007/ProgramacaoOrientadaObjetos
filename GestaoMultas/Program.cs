string cpf = "";
cpf = "05810263224";
cpf = cpf.Replace(".", "").Replace(".","-");

Validacao.SetCpf(cpf);
Console.WriteLine(Validacao.GetCpf());