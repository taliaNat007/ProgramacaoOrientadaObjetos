using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_idade_aluno
{
    internal class Aluno
    {
        public string nome;
        public string matricula;
        public DateTime data_nasc; 
        public int idade_aluno;
        public Aluno(DateTime data_nascimento)
        {
            this.data_nasc = data_nascimento;
            DateTime data_atual = DateTime.Now;
            int idade = data_atual.Year - this.data_nasc.Year;

            if (data_atual.Month < this.data_nasc.Month)
            {
                idade -= 1;
            }
            else 
            {
                if (data_atual.Month == this.data_nasc.Month)
                {
                    if (data_atual.Day < this.data_nasc.Day)
                    {
                        idade = 1;
                    }
                }
            }
            this.idade_aluno = idade;
         }
    }
}
