using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_heranca2
{
    internal class Passeio : Veiculo
    {

        public Passeio()
        {
            
        }

        public override void CalcularPedagio()
        {
            precoPedagio = qtdEixo * 3.00;

        }
    }
}
