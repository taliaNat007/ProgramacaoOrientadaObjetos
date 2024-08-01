using Exercicio_heranca;
using System;
using System.Drawing;

Conta cont1 = new Conta(100);


Console.Write(@"      Qual opção de conta deseja acessar ?
                           Digite 1 |  CONTA COMUM
                           Digite 2 |  CONTA EMPRESARIAL
                           Digite 3 | CONTA ESTUDANTIL: ");
int conta = Convert.ToInt32(Console.ReadLine());

switch (conta)
{
    case 1:

        Console.WriteLine(@"    
                             ********* BEM VINDO A SUA CONTA COMUM ************ ");

        Console.Write(@"        Qual opção deseja realizar ? 
                           Digite 1 |  SAQUE
                           Digite 2 |  DEPOSITO: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {

            Console.WriteLine(" Digite o valor que deseja sacar:");
            double valor = Convert.ToDouble(Console.ReadLine());

            cont1.SetSacar(valor);
        }
        else
        {
            if (opc == 2)
            {
                Console.WriteLine(" Digite o valor que deseja depositar: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                cont1.SetDepositar(valor);
            }
        }
        break;
    case 2:
        Console.WriteLine(@"    
                                ********* BEM VINDO A SUA CONTA EMPRESARIAL ************
                        ");

        break;
    case 3:
        Console.WriteLine(@"    
                                ********* BEM VINDO A SUA CONTA ESTUDANTIL  ************
                         ");
        Console.Write(@"        Qual opção deseja realizar ? 
                           Digite 1 |  SAQUE
                           Digite 2 |  DEPOSITO: ");
        opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {

            Console.WriteLine(" Digite o valor que deseja sacar:");
            double valor = Convert.ToDouble(Console.ReadLine());

            cont1.SetSacar(valor);
        }
        else
        {
            if (opc == 2)
            {
                Console.WriteLine(" Digite o valor que deseja depositar: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                cont1.SetDepositar(valor);
            }
        }
        break;
    default:
        break;
}



