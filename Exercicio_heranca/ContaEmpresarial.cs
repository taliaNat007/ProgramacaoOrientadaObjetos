using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca
{
    public class ContaEmpresarial : Conta
    {
        public double anuidade;
        public double limiteEmpretismo;
        public double totalEmprestimo;

        /*Métodos
         * FazerEmprestimo(valor double) : void
         * Sacar(valor double) : void
         */

        public ContaEmpresarial(double valor) : base(valor)
        {

        }
    }
}
