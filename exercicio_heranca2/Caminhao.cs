using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_heranca2
{
    internal class Caminhao : Veiculo
    {
        public Caminhao() 
        { 

        }

        public override void CalcularPedagio()
        {
            precoPedagio = (qtdEixo * 7.00) * (1 + 0.1);

        }
    }
}
