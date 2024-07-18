// programa principal
using calcular_idade_aluno;

Aluno a1 = new Aluno( new DateTime(2003, 05, 28));

a1.nome = "Natália";
a1.matricula = "2022202060013";


Console.WriteLine( $@"
                        Dados do Aluno
                        
                        Nome: {a1.nome}
                        Matricula: {a1.matricula}
                        Data Nascimento: {a1.data_nasc}
                        Idade: {a1.idade_aluno}"
                   );