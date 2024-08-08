using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_heranca2
{
    internal abstract class Veiculo
    {
        public string placa;
        public int qtdEixo;
        public int tipo;
        public double precoPedagio;
        public double valorFinal;

        /* SISTEMA DE COBRANÇA
         
        Carros de passeio:
            • 3,00 por eixo.
        Carros Utilitários:
            • 3,50 por eixo;
            • taxa de manutenção da estrada de 2% sobre o valor do pedágio;
        Ônibus:
            • 5,00 por eixo;
            • taxa de manutenção da estrada de 5% sobre o valor do pedágio;
        Caminhão:
            • 7,00 por eixo;
            • taxa de manutenção da estrada de 10% sobre o valor do pedágio;


        TIPOS DE VEÍCULOS

        Tipo 1:
            • Qualquer veículo(categoria) pertencente a pessoa física, não recebe desconto.
        Tipo 2:
            • Qualquer veículo(categoria) pertencente a pessoa jurídica recebe 5% de desconto.
        Tipo 3:
            • Qualquer veículo(categoria) oficial recebe 100% de desconto.
         */

        public Veiculo()
        {
            double precoPedagio = 0;
            this.precoPedagio = precoPedagio;
        }

        public abstract void CalcularPedagio();
        

        public void CalcularDesconto()
        {
            /*
              Tipo 1:
                • Qualquer veículo(categoria) pertencente a pessoa física, não recebe desconto.
              Tipo 2:
                • Qualquer veículo(categoria) pertencente a pessoa jurídica recebe 5% de desconto.
              Tipo 3:
                • Qualquer veículo(categoria) oficial recebe 100% de desconto
             */

            if (tipo == 1)
            {

            } else if (tipo == 2)
            {
                Console.WriteLine($" Valor do pedágio: {valorFinal} ");
            }else if (tipo == 3)
            {
                Console.WriteLine($" INSENTO DE PEDÁGIO ");
            }
        }

    }
}
