decimal num1, num2, div;

Console.WriteLine(" Digite o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Digite o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());


// EXCESSÃO
/*
 
 NÃO TEM NADA HAVER COM A ESTRUTURA DE CONDIÇÃO IF. 
 
 */
try
{
    //Excessão principal
    div = num1 / num2;

    Console.WriteLine(" A divisão entre os números é: " + div);
}
catch (Exception excessao)
{
    // Excessão que PREVINE um BUG no sistema, caso a operação não seja válida ele avisa. No caso abaixo, não é possível dividir nenhum número por ZERO.
    Console.WriteLine(" Não é permitido divisão por ZERO " + excessao.Message);
}
finally
{
    // Excesssão que ocorre independente das demais
    Console.WriteLine(" Volte Sempre!!!");
}