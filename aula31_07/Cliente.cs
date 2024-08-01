using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula31_07
{
    internal class Cliente
    {
        public int id_cliente;
        public string email;
        public string telefone;
        public Endereco endereco = new Endereco();

    }
}
