using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca
{
    public class ContaEstudante : Conta
    {
        public double limiteChequeEspecial = 100;
        public string cpf;
        public string nomeInstituicao;
        /*Método
         * Sacar(valor double) : void
         */

        public ContaEstudante(double valor): base (valor) 
        {

        }
       
        public override void SetSacar(double valor)
        {
            if (valor <= (saldo + limiteChequeEspecial))
            {
                Console.WriteLine(" Valor de saque PERMITIDO!");
            }
            else
            {
                Console.WriteLine(" Saldo INSUFICIENTE! ");
            }
        }
    }
}
