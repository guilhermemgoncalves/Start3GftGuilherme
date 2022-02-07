using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2CalculaImposto
{
    public class IPI
    {

        double valor;

        public IPI(double valor)
        {
            this.valor = valor;
        }

        public double calculaImposto(double valor)
        {
            double taxa = 0 ;
            if (valor < 25000) 
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
            double desconto = taxa * valor;
            Console.WriteLine($"IPI: {desconto}");
            return desconto;
        }

    }
}
