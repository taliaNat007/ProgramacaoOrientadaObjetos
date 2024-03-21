

// Criando a classe Conta
public class Conta
{
    public string id;
    public string agencia;
    public string num_conta;
    public string nome_propri;
    private double saldo;

    // Método transferir
    public void Transferir (Conta destino, double valor)
    {
        destino.saldo += valor;
        saldo = valor;
    }

     //Criando método Depósito
   /* public double Depositar( double valor_acrescido)
    {
        
        if (valor_acrescido < 0)
        {
            Console.WriteLine(" Não deve depositar valor negativo!! ");
            return saldo;
        }
        else
        {
            saldo = saldo + valor_acrescido;
            Console.WriteLine("Saldo: " + saldo);
            return saldo;
        }
       
    }*/

    public void setSaldo (double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Saldo Inválido");
        }
        else
        {
            saldo += valor;
            Console.WriteLine("Saldo: " + saldo);
        }
    }

    public double getSaldo()
    {
        return saldo;
    } 
    public double getTransferir()
    {
        return saldo;
    }

   
}

public class Program
{
    static void Main (string[]args)
    {
        Conta conta = new Conta();

        Conta cliente1 = new Conta();
        cliente1.nome_propri = "João";
        cliente1.setSaldo(100);

        Conta cliente2 = new Conta();
        cliente2.nome_propri = "Natália";
        cliente2.setSaldo(1);

        Conta cliente3 = new Conta();
        cliente3.nome_propri = "Maria";
        cliente3.setSaldo(-100);
        
        
        Conta cliente4 = new Conta();
        cliente4.nome_propri = "Irineu";
        cliente4.setSaldo(-100);
        cliente4.Transferir(cliente4 , 100);

        Console.WriteLine(cliente1.nome_propri + " tem R$" + cliente1.getSaldo() + ",00");
        Console.WriteLine(cliente2.nome_propri + " tem R$"+ cliente2.getSaldo() + ",00");
        Console.WriteLine(cliente3.nome_propri + " tem R$"+ cliente3.getSaldo ()+ ",00");
        Console.WriteLine(cliente4.nome_propri + " Recebeu R$"+ cliente4.getTransferir ()+ ",00");



        /*  // Criando a instancia Conta
          Conta conta = new Conta();

          Console.WriteLine(" --- INSIRA OS DADOS À BAIXO DA SUA CONTA --- ");

          Console.WriteLine(" Insira o ID: ");
          conta.id = Console.ReadLine();
          Console.WriteLine(" Insira a agência: ");
          conta.agencia = Console.ReadLine();
          Console.WriteLine(" Insira o número da conta: ");
          conta.num_conta = Console.ReadLine();
          Console.WriteLine(" Insira o nome do titular da conta: ");
          conta.nome_propri = Console.ReadLine();
          Console.WriteLine(" Insira o Saldo da conta: ");
          conta.saldo = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine(" Insira o valor que deseja depositar: ");
          double valor = Convert.ToDouble(Console.ReadLine());

          conta.Depositar(valor);




          // Apresentando Dados do depósito
          Console.WriteLine(" --- Dados do depósito --- ");
          Console.WriteLine( " ID da conta: " + conta.id);
          Console.WriteLine( " Agência da conta: " + conta.agencia);
          Console.WriteLine( " Número da conta: " + conta.num_conta);
          Console.WriteLine( " Titular da conta: " + conta.nome_propri);
          Console.WriteLine( " Saldo da conta: " + conta.saldo);
          */
    }
}
