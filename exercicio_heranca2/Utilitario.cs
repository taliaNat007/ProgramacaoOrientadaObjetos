using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_heranca2
{
    internal class Utilitario : Veiculo
    {
        public Utilitario() { }
        public override void CalcularPedagio()
        {
            precoPedagio = (qtdEixo * 3.50) * (1 + 0.02);

        }

    }
}
