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
public static class Validacao
{
    private static bool validar_cpf;
    private static bool validar_niv_chassi;

    public static void SetCpf(string cpf)
    {

        if (cpf.Length != 11)
        {
            validar_cpf = false;
        }
        else if (cpf.Length == 11)
        {
            validar_cpf = true;
        }
    }

    public static bool GetCpf() 
    { 
        return validar_cpf; 
    }
}

