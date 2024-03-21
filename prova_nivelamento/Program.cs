
/*varíável utilizado para fazer o menu do usuário*/
int questao = 0;
Console.Write(@"                                            --- PROVA NIVELAMENTO ---

                    SELECIONE A QUESTÃO QUE DESEJA TESTAR

            QUESTÃO 1: A média final de um aluno em uma determinada disciplina é calculada com base no número de
            atividades avaliativas aplicadas pelo professor. Você foi escolhido para construir um programa
            que realize o calculo de média de cada aluno. Faça um programa que receba o nome e duas notas
            de um aluno, o programa deve calcular a média e informe a média do aluno e se ele foi aprovado
            ou não. Para ser aprovado a média deve ser igual ou superior a 60 pontos.

            QUESTÃO 2: O programa desenvolvido na atividade anterior só funciona para duas notas, faça um programa
            que receba o nome do aluno, a quantidade de atividades avaliativas, as notas das referidas
            atividades. Ao fim, calcule a média e apresente se o aluno foi aprovado ou não. 
            
            QUESTÂO 3: O programa da questão 2 funciona apenas para calculo de média, no entanto caso o professor
            faça a opção de média ponderada, o mesmo não irá atender a situação. Pensando nisso, faça uma
            opção (pode usar um menu ou outro programa) que receba a quantidade de atividades
            avaliativas, o peso de cada atividade. Posteriormente, leia o nome de um aluno, as notas obtidas
            em cada atividade, calcule e apresente a média e se o aluno foi ou não aprovado.
            ");
questao = Convert.ToInt32(Console.ReadLine());


// LIMPANDO O CABEÇALHO E APRESENTANDO APENAS OS DADOS QUE O USUÁRIO PRECISA INSERIR PARA REALIZAR O CÁCULO
Console.Clear();

// variáveis gerais
string nome;
double media = 0;

/*variável utilizada para receber quantas atividades o aluno desenvolveu*/
int qtd_atv;
switch (questao)
{
    // Resolução da Questão 1
    case 1:
        double nota1 = 0, nota2;

        Console.Write(@"                 Informe o nome do aluno: ");
        nome = Console.ReadLine();

        Console.Write(@"
       --- Agora preencha os dados da disciplina ---
        
        Digite a 1º nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write(@" 
        Digite a 2º nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2) / 2;

        // LIMPANDO A TELA E APRESENTANDO RESULTADO AO USUÁRIO
        Console.Clear();

        Console.WriteLine(@" 
            --- SITUAÇÃO DO ALUNO --- 
            ");

        if (media >= 60)
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está APROVADO !!");
            Console.WriteLine(@$"      Sua média é: {media}. ");
        }
        else
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está REPROVADO !!");
            Console.WriteLine($@"      Sua média é: {media}. ");
        }

        break;// final do case 1

    // Resolução da Questão 2
    case 2:
        Console.Write(@"                 Informe o nome do aluno: ");
        nome = Console.ReadLine();
        
        
        
        Console.Write(@"
                                    Quantas atividades avaliativa o aluno fez? ");
        qtd_atv = Convert.ToInt32(Console.ReadLine());

        double[] notas = new double[qtd_atv];
        double soma = 0;
        for (int i = 0; i < qtd_atv; i++)
        {
            Console.Write(@$"             Digite a nota da {i + 1}º atividade: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());

            soma = soma + notas[i];
        }

        media = soma / qtd_atv;

        // LIMPANDO A TELA E APRESENTANDO RESULTADO AO USUÁRIO
        Console.Clear();

        Console.WriteLine(@" 
            --- SITUAÇÃO DO ALUNO --- 
            ");

        if (media >= 60)
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está APROVADO !!");
            Console.WriteLine(@$"      Sua média é: {media}. ");
        }
        else
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está REPROVADO !!");
            Console.WriteLine($@"      Sua média é: {media}. ");
        }
        break;// final do case 2

    // Resolução da Questão 3
    case 3:
        Console.Write(@"                 Informe o nome do aluno: ");
        nome = Console.ReadLine();

        
        Console.Write(@"
                                    Quantas atividades avaliativa o aluno fez? ");
        qtd_atv = Convert.ToInt32(Console.ReadLine());

        double media_pond = 0;
        double[] notas_aux = new double[qtd_atv];
        double[] peso = new double[qtd_atv];

        double soma_nota = 0;
        double soma_peso = 0;
        double soma_arit = 0;
        for (int i = 0; i < qtd_atv; i++)
        {
            Console.Write(@$"             Digite o peso da {i + 1}º atividade: ");
            peso[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write(@$"             Digite a nota da {i + 1}º atividade: ");
            notas_aux[i] = Convert.ToDouble(Console.ReadLine());

            //soma para media aritmética
            soma_arit = soma_arit + notas_aux[i];
            // soma para media ponderada
            soma_peso +=  peso[i];
            soma_nota += peso[i] * notas_aux[i];
        }

        //calculando media aritmetica
        media = soma_arit / qtd_atv;
        // calculando media ponderada
        media_pond = soma_nota / soma_peso;
        // LIMPANDO A TELA E APRESENTANDO RESULTADO AO USUÁRIO
        Console.Clear();

        Console.WriteLine(@" 
            --- SITUAÇÃO DO ALUNO --- 
            ");

        if (media >= 60)
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está APROVADO !!");
            Console.WriteLine(@$"      Sua MÉDIA ARITMÉTICA é: {media}. ");
            Console.WriteLine(@$"      Sua MÉDIA PONDERADA é: {media_pond}. ");
        }
        else
        {
            Console.WriteLine(@$"      O Aluno '{nome}' está REPROVADO !!");
            Console.WriteLine($@"      Sua MÉDIA ARITMÉTICA é: {media}. ");
            Console.WriteLine($@"      Sua MÉDIA PONDERADA é: {media_pond}. ");
        }
        break; // final do case 3

    default:
        break;
}

