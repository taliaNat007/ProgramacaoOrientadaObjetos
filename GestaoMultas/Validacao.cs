// Classe estática: classes que não variam sua execução, não crio objetos
// dentro de uma classe estática seus componentes serão estáticos

/* questão 9; encontrar 1 elemtento estático dentro de uma classe não estática.
 * 
 * uma Classe nã estática pode ter elementos estáticos, já uma classe estática
 * não pode ter elemento Não estpático.
 * 
 * Atributos estáticos: atributos que pertencem a classe
 * Ex¹: media das notas de uma turma.
 * Atributos normais/não estáticos: pertencem ao objeto
 * Ex¹: nome do aluno
 * 
 */



public static class ValidadorCPF
{
    public static bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        int[] digitos = new int[11];
        for (int i = 0; i < 11; i++)
        {
            digitos[i] = int.Parse(cpf[i].ToString());
        }

        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += digitos[i] * (10 - i);
        }

        int digitoEsperado1 = (soma < 2) ? 0 : 11 - (soma % 11);

        if (digitos[9] != digitoEsperado1)
        {
            Console.WriteLine("CPF inválido. O Primeiro dígito verificador está incorreto.");
            return false;
        }

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += digitos[i] * (11 - i);
        }

        int digitoEsperado2 = (soma < 2) ? 0 : 11 - (soma % 11);

        if (digitos[10] != digitoEsperado2)
        {
            Console.WriteLine("CPF inválido. O segundo dígito verificador está incorreto.");
            return false;
        }

        return true;
    }
}



/*public static class Validacao
{
    private static bool validar_cpf;
    private static bool validar_niv_chassi;

    /*public static bool ValidarCpf(string cpf)
    {
        //cpf = cpf.Replace(".", "").Replace(".", "-");

        int [] digito = new int[11];
        cpf = "";

        for (int i = 0; i < 11; i++)
        {
            digito[i] = int.Parse(cpf[i].ToString());
        }

        int soma = 0;
        for (int i = 0;i < 9; i++) 
        {
            soma += digito[i] * (10 - i);
        }  

        int digitoEsperado1 = (soma < 2) ? 0 : 11 - (soma % 11);

        if (digito[9] != digitoEsperado1)
        {
            Console.WriteLine(" CPF INVÁLIDO! O Primeiro digito está incorreto");
            return false;
        }
        
        soma = 0;

        for (int i = 0; i < 10; i++)
        {
            soma += digito[i] * (11 - i);
        }

        int digitoEsperado2 = (soma < 2) ? 0 : 11 - (soma % 11);

        if (digito[10] != digitoEsperado2)
        {
            Console.WriteLine(" CPF INVÁLIDO! O Segundo digito está incorreto");
            return false;
        }

        return true;

        /*if (cpf.Length != 11)
        {
            validar_cpf = false;
        }
        else if (cpf.Length == 11)
        {
            validar_cpf = true;
        }
    }

    /*public static bool GetCpf() 
    { 
        return validar_cpf; 
    }
}*/

