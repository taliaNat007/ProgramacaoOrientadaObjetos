Matematica soma = new Matematica();
Matematica multiplicacao = new Matematica();

Console.WriteLine(" Digite um número para somar: ");
soma.n1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite um número para somar: ");
soma.n2 = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite um número para multiplicar: ");
multiplicacao.n1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite um multiplicar: ");
multiplicacao.n2 = double.Parse(Console.ReadLine());

double somafinal = soma.Soma();
double multiplicacaofinal = multiplicacao.Multiplicar();

Console.WriteLine($" A soma dos números {soma.n1} e {soma.n2} é: " + soma.Soma()) ;
Console.WriteLine($" A multiplicação dos números {multiplicacao.n1} e {soma.n2} é: " + multiplicacao.Multiplicar()) ;