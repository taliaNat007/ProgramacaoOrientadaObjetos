using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_heranca2
{
    internal class Onibus : Veiculo
    {
        public Onibus() 
        { 

        }
        public override void CalcularPedagio()
        {
            precoPedagio = (qtdEixo * 5.00) * (1 + 0.05);

        }
    }
}
