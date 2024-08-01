using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca
{
    public class Conta
    {
        public int nConta;
        public string agencia;
        public string titular;
        protected double saldo = 100;
        public double valor;
        public Conta(double valor)
        {
            this.valor = valor;
        }


        /* Métodos: 
         * Sacar(double valor) : void
         * Depositar(valor double) : void
         */

       
        public virtual void SetSacar(double valor)
        {
            

            if (valor <= saldo)
            {
                saldo = saldo - valor;
                Console.WriteLine(" Saldo atual: " + saldo);
            }
            else
            {
                Console.WriteLine(" SALDO INSUFICIENTE !!!");
            }

        }

       

        public void SetDepositar( double valor)
        {
            if(valor > 0)
            {
                saldo = saldo - valor;
                Console.WriteLine(" Saldo atual: " + saldo);
            }
            else if(valor <= 0)
            {
                Console.WriteLine(" Por favor, INSIRA UM VALOR MAIOR QUE ZERO (0) !!!");
            }
        }

     
    }
}
