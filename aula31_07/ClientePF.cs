using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula31_07
{
    internal class ClientePF : Cliente
    {
        public string nome;
        public string cpf;
        public string formacao;

        public ClientePF( )
        {
            string cep = " "; string logradouro = " "; string numero = " "; string bairro = " "; string cidade = " ";
            endereco.cep = cep;
            endereco.logradouro = logradouro;
            endereco.numero = numero;
            endereco.bairro = bairro;
            endereco.cidade = cidade;
        }

    }
}
